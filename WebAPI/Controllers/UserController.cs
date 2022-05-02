using AutoMapper;
using Dto.UsersDto;
using Entities.UsersEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Queries;
using Queries.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Extensions;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UserCrudQueryHandler _crudService;
        private readonly UserService _userService;

        public UserController(IMapper mapper, UserCrudQueryHandler crudService, UserService userService)
        {
            _mapper = mapper;
            _crudService = crudService;
            _userService = userService;
        }

        [HttpGet]
        [Route("users")]
        public IActionResult GetAll()
        {
            List<User> result = _crudService.GetAll().ToList();

            if (result.Any())
            {
                List<UserDto> resultDto = result.Select(entity => _mapper.Map<UserDto>(entity)).ToList();

                return Ok(resultDto);
            }

            return StatusCode(404);
        }

        [HttpGet]
        [Route("user/{id}")]
        public IActionResult Get(Guid id)
        {
            User result = _crudService.GetById(id);

            if (result != null)
            {
                return Ok(_mapper.Map<UserDto>(result));
            }

            return StatusCode(404);
        }

        [HttpPost]
        [Route("signup"), AllowAnonymous()]
        public IActionResult Post(UserPostDto userDto)
        {
            try
            {
                User user = _mapper.Map<User>(userDto);
                _crudService.Post(user);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("user")]
        public IActionResult Put(UserDto userDto)
        {
            try
            {
                User user = _mapper.Map<User>(userDto);
                _crudService.Put(user);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("login"), AllowAnonymous()]
        public IActionResult Authenticate([FromBody] Credential cred)
        {
            if (cred == null || string.IsNullOrEmpty(cred.login) || string.IsNullOrEmpty(cred.pwd))
            {
                return BadRequest(new { message = "Credentials incomplete" });
            }

            try
            {
                AuthenticateResponse response = _userService.Authenticate(cred);

                return Ok(response);
            }
            catch
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }

        }

    }
}
