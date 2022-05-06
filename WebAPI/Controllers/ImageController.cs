using System;
using System.Linq;
using AutoMapper;
using Dto.ImagesDto;
using Entities.ProduitsEntities;
using Microsoft.AspNetCore.Mvc;
using Queries.Interface;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICrudInterface<Image> _crudService;

        public ImageController(IMapper mapper, ICrudInterface<Image> crudService)
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
                var resultDto = result.Select(entity => _mapper.Map<ImageDto>(entity)).ToList();
                return Ok(resultDto);
            }

            return StatusCode(404);

        }

        [HttpGet("{id}")]
        public IActionResult GetImageById(Guid id)
        {
            var result = _crudService.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }

            return StatusCode(404);
        }

        [HttpPost]
        public IActionResult Post(ImagePostDto ImagePostDto)
        {
            try
            {
                var Image = _mapper.Map<Image>(ImagePostDto);
                _crudService.Post(Image);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }

    }
}
