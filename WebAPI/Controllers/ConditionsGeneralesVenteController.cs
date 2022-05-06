using System;
using Dto;
using Dto.ConditionsGeneralesVenteDto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Entities.ConditionsGeneralesVenteEntitie;
using Queries.Interface;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConditionsGeneralesVenteController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICrudInterface<ConditionsGeneralesVente> _crudService;

        public ConditionsGeneralesVenteController(IMapper mapper, ICrudInterface<ConditionsGeneralesVente> crudService)
        {
            _mapper = mapper;
            _crudService = crudService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _crudService.GetAll().ToList();

            if (result.Any())
            {
                var resultDto = result.Select(entity => _mapper.Map<ConditionsGeneralesDto>(entity)).ToList();
                return Ok(resultDto);
            }

            return StatusCode(404);

        }

        [HttpGet("{id}")]
        public IActionResult GetConditionsGeneralesById(Guid id)
        {
            var result = _crudService.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }

            return StatusCode(404);
        }
        [HttpPost]
        public IActionResult Post(ConditionsGeneralesPostDto ConditionsGeneralesPostDto)
        {
            try
            {
                var ConditionsGeneralesVente = _mapper.Map<ConditionsGeneralesVente>(ConditionsGeneralesPostDto);
                _crudService.Post(ConditionsGeneralesVente);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

    }
}