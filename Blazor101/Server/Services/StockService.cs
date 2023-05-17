using System;

namespace Blazor101.Server.Services
{
    public class StockService : IStockService
    {
        private List<Stock> allStocks;

        public StockService()
        {
            allStocks = new List<Stock>();

            allStocks.Add(new Stock("AAPL", 170, StockType.Stock));
            allStocks.Add(new Stock("AMZN", 110, StockType.Stock));
            allStocks.Add(new Stock("MSFT", 200, StockType.Stock));
            allStocks.Add(new Stock("TSLA", 165, StockType.Stock));
            allStocks.Add(new Stock("VOO", 230, StockType.ETF));
            allStocks.Add(new Stock("QQQ", 150, StockType.ETF));
        }


        public async Task<Stock?> GetStock(string symbol)
        {
            await Task.Delay(100);
            return allStocks.Find(s => s.Symbol == symbol);
        }

        public async Task<IEnumerable<Stock>> GetStocks()
        {
            await Task.Delay(100);
            return allStocks;
        }
    }
}

