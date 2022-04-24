using System;
using System.Linq;
using AutoMapper;
using Dto.CommentairesDto;
using Dto.DescriptionsDto;
using Entities.CommentairesEntities;
using Entities.DescriptionsEntitie;
using Microsoft.AspNetCore.Mvc;
using Queries;
using Queries.Interface;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DescriptionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICrudInterface<Description> _crudService;
        private  DescriptionCrudQueryHandler _description = new DescriptionCrudQueryHandler();

        public DescriptionController(IMapper mapper, ICrudInterface<Description> crudService)
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
                var resultDto = result.Select(entity => _mapper.Map<DescriptionDto>(entity)).ToList();
                return Ok(resultDto);
            }

            return StatusCode(404);

        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetDescription(int id)
        {
            var result = _crudService.GetById(id);

            if (result!= null)
            {
                return Ok(result);
            }

            return StatusCode(404);
        }

        [HttpGet]
        [Route("Produit/{idProduct}")]
        public IActionResult GetDescriptionByProduct(int idProduct)
        {
            
            var result = _description.GetByProductId(idProduct);

            if (result != null)
            {
                return Ok(result);
            }

            return StatusCode(404);
        }

        [HttpPost]
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
