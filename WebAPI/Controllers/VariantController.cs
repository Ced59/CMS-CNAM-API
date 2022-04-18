using System;
using System.Linq;
using AutoMapper;
using Dto.CommentairesDto;
using Dto.VariantsDto;
using Entities.CommentairesEntities;
using Entities.VariantsEntitie;
using Microsoft.AspNetCore.Mvc;
using Queries.Interface;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class VariantController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICrudInterface<Variant> _crudService;

        public VariantController(IMapper mapper, ICrudInterface<Variant> crudService)
        {
            _mapper = mapper;
            _crudService = crudService;
        }

        [HttpGet]
        [Route("variants")]
        public IActionResult GetAll()
        {
            var result = _crudService.GetAll().ToList();

            if (result.Any())
            {
                var resultDto = result.Select(entity => _mapper.Map<VariantDto>(entity)).ToList();
                return Ok(resultDto);
            }

            return StatusCode(404);

        }

        [HttpPost]
        [Route("variant")]
        public IActionResult Post(VariantPostDto VariantPostDto)
        {
            try
            {
                var variant = _mapper.Map<Variant>(VariantPostDto);
                _crudService.Post(variant);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

    }
}
