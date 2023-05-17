using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Blazor101.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        private IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }


        [HttpGet]
        public async Task<IEnumerable<Stock>> Get()
        {
            var stocks = await _stockService.GetStocks();
            return stocks;
        }
    }
}

