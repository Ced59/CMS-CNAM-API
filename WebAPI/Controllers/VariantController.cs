using System;
using System.Linq;
using AutoMapper;
using Dto.CommentairesDto;
using Dto.VariantsDto;
using Entities.ProduitsEntities;
using Microsoft.AspNetCore.Mvc;
using Queries.Interface;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

        [HttpGet("{id}")]
        public IActionResult GetVariantById(Guid id)
        {
            var result = _crudService.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }

            return StatusCode(404);
        }

        [HttpPost]
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
