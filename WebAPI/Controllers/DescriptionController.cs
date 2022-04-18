using System;
using System.Linq;
using AutoMapper;
using Dto.CommentairesDto;
using Dto.DescriptionsDto;
using Entities.CommentairesEntities;
using Entities.DescriptionsEntitie;
using Microsoft.AspNetCore.Mvc;
using Queries.Interface;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class DescriptionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICrudInterface<Description> _crudService;

        public DescriptionController(IMapper mapper, ICrudInterface<Description> crudService)
        {
            _mapper = mapper;
            _crudService = crudService;
        }

        [HttpGet]
        [Route("descriptions")]
        public IActionResult GetAll()
        {
            var result = _crudService.GetAll().ToList();

            if (result.Any())
            {
                var resultDto = result.Select(entity => _mapper.Map<DescriptionDto>(entity)).ToList();
                return Ok(resultDto);
            }

            return StatusCode(404);

        }

        [HttpPost]
        [Route("description")]
        public IActionResult Post(DescriptionPostDto DescriptionPostDto)
        {
            try
            {
                var Description = _mapper.Map<Description>(DescriptionPostDto);
                _crudService.Post(Description);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

    }
}
