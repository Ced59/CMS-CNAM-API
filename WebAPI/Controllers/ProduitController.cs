using System;
using System.Linq;
using AutoMapper;
using Dto.CommentairesDto;
using Dto.ProduitsDto;
using Entities.ProduitsEntities;
using Microsoft.AspNetCore.Mvc;
using Queries.Interface;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProduitController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICrudInterface<Produit> _crudService;

        public ProduitController(IMapper mapper, ICrudInterface<Produit> crudService)
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
                var resultDto = result.Select(entity => _mapper.Map<ProduitDto>(entity)).ToList();
                return Ok(resultDto);
            }

            return StatusCode(404);

        }

        [HttpGet("{id}")]
        public IActionResult GetProduitById(Guid id)
        {
            var result = _crudService.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }

            return StatusCode(404);
        }

        [HttpPost]
        public IActionResult Post(ProduitPostDto ProduitPostDto)
        {
            try
            {
                var Produit = _mapper.Map<Produit>(ProduitPostDto);
                _crudService.Post(Produit);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }

    }
}
