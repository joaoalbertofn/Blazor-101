using System;
namespace Blazor101.Shared.Models
{
	public class Stock
	{
		public string? Symbol { get; set; }
        public double CurrentPrice { get; set; }
		public StockType Type { get; set; }

		public Stock() {}

		public Stock(string symbol, double price, StockType type)
		{
			Symbol = symbol;
			CurrentPrice = price;
			Type = type;
        }
    }

	public enum StockType
	{
		Stock,
		ETF,
		Crypto
	}
}

