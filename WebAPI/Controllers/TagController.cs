using System;
using System.Linq;
using AutoMapper;
using Dto.CommentairesDto;
using Dto.TagsDto;
using Entities.CommentairesEntities;
using Entities.TagsEntitie;
using Microsoft.AspNetCore.Mvc;
using Queries.Interface;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class TagController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICrudInterface<Tag> _crudService;

        public TagController(IMapper mapper, ICrudInterface<Tag> crudService)
        {
            _mapper = mapper;
            _crudService = crudService;
        }

        [HttpGet]
        [Route("tags")]
        public IActionResult GetAll()
        {
            var result = _crudService.GetAll().ToList();

            if (result.Any())
            {
                var resultDto = result.Select(entity => _mapper.Map<TagDto>(entity)).ToList();
                return Ok(resultDto);
            }

            return StatusCode(404);

        }

        [HttpPost]
        [Route("tag")]
        public IActionResult Post(TagPostDto TagPostDto)
        {
            try
            {
                var Tag = _mapper.Map<Tag>(TagPostDto);
                _crudService.Post(Tag);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

    }
}
