using System;
namespace Blazor101.Server.Services
{
	public interface IStockService
	{
		Task<IEnumerable<Stock>> GetStocks();

		Task<Stock?> GetStock(string symbol);
	}
}

