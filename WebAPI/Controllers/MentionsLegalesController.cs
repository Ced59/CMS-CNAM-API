using System;
using Dto;
using Dto.MentionsLegalesDto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Entities.MentionsLegalesEntitie;
using Queries.Interface;


namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MentionsLegalesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICrudInterface<MentionsLegales> _crudService;
        public MentionsLegalesController(IMapper mapper, ICrudInterface<MentionsLegales> crudService)
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
                var resultDto = result.Select(entity => _mapper.Map<MentionsLegalesDto>(entity)).ToList();
                return Ok(resultDto);
            }

            return StatusCode(404);

        }

        [HttpGet("{id}")]
        public IActionResult GetMentionsLegalesById(Guid id)
        {
            var result = _crudService.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }

            return StatusCode(404);
        }

        [HttpPost]
        public IActionResult Post(MentionsLegalesDto MentionsLegalesPostDto)
        {
            try
            {
                var MentionsLegales = _mapper.Map<MentionsLegales>(MentionsLegalesPostDto);
                _crudService.Post(MentionsLegales);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

    }
}

 
