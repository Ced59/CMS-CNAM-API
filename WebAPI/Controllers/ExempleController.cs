using Dto;
using Dto.ExemplesDto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ExempleController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ExempleController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        [Route("exemples")]
        public IEnumerable<ExempleDto> GetAll()
        {

            return new List<ExempleDto>();
        }

        [HttpGet]
        [Route("exemple")]
        public ExempleDto Get(int id)
        {
            return new ExempleDto();
        }

        [HttpPost]
        [Route("exemple")]
        public void Post(ExempleDto exempleDto)
        {

        }

        [HttpPut]
        [Route("exemple")]
        public void Put(ExempleDto exempleDto)
        {

        }

    }
}
