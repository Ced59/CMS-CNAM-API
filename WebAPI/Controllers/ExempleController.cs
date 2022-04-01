using System;
using Dto;
using Dto.ExemplesDto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Entities.ExemplesEntitie;
using Queries.Interface;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ExempleController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICrudInterface<Exemple> _crudService;

        public ExempleController(IMapper mapper, ICrudInterface<Exemple> crudService)
        {
            _mapper = mapper;
            _crudService = crudService;
        }

        [HttpGet]
        [Route("exemples")]
        public IActionResult GetAll()
        {
            var result = _crudService.GetAll().ToList();

            if (result.Any())
            {
                var resultDto = new List<ExempleDto>();

                foreach (var entity in result)
                {
                    resultDto.Add(_mapper.Map<ExempleDto>(entity));
                }

                return Ok(resultDto);
            }

            return StatusCode(404);
        }

        [HttpGet]
        [Route("exemple")]
        public IActionResult Get(int id)
        {
            var result = _crudService.GetById(id);

            if (result != null)
            {
                return Ok(_mapper.Map<ExempleDto>(result));
            }

            return StatusCode(404);
        }

        [HttpPost]
        [Route("exemple")]
        public IActionResult Post(ExemplePostDto exempleDto)
        {
            try
            {
                var exemple = _mapper.Map<Exemple>(exempleDto);
                _crudService.Post(exemple);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("exemple")]
        public IActionResult Put(ExempleDto exempleDto)
        {
            try
            {
                var exemple = _mapper.Map<Exemple>(exempleDto);
                _crudService.Put(exemple);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

    }
}
