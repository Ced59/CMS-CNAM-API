using System;
using System.Linq;
using AutoMapper;
using Dto.CommentairesDto;
using Entities.CommentairesEntities;
using Microsoft.AspNetCore.Mvc;
using Queries.Interface;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class CommentaireController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICrudInterface<Commentaire> _crudService;

        public CommentaireController(IMapper mapper, ICrudInterface<Commentaire> crudService)
        {
            _mapper = mapper;
            _crudService = crudService;
        }

        [HttpGet]
        [Route("commentaires")]
        public IActionResult GetAll()
        {
            var result = _crudService.GetAll().ToList();

            if (result.Any())
            {
                var resultDto = result.Select(entity => _mapper.Map<CommentaireDto>(entity)).ToList();
                return Ok(resultDto);
            }

            return StatusCode(404);

        }

        [HttpPost]
        [Route("commentaire")]
        public IActionResult Post(CommentairePostDto commentairePostDto)
        {
            try
            {
                var commentaire = _mapper.Map<Commentaire>(commentairePostDto);
                _crudService.Post(commentaire);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }

    }
}
