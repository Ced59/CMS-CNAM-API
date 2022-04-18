using System;
using System.Linq;
using AutoMapper;
using Dto.CommentairesDto;
using Dto.StocksDto;
using Entities.CommentairesEntities;
using Entities.StocksEntitie;
using Microsoft.AspNetCore.Mvc;
using Queries.Interface;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class StockController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICrudInterface<Stock> _crudService;

        public StockController(IMapper mapper, ICrudInterface<Stock> crudService)
        {
            _mapper = mapper;
            _crudService = crudService;
        }

        [HttpGet]
        [Route("stocks")]
        public IActionResult GetAll()
        {
            var result = _crudService.GetAll().ToList();

            if (result.Any())
            {
                var resultDto = result.Select(entity => _mapper.Map<StockDto>(entity)).ToList();
                return Ok(resultDto);
            }

            return StatusCode(404);

        }

        [HttpPost]
        [Route("stock")]
        public IActionResult Post(StockPostDto StockPostDto)
        {
            try
            {
                var Stock = _mapper.Map<Stock>(StockPostDto);
                _crudService.Post(Stock);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

    }
}
