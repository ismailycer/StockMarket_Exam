using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class SellOrder
	{
		public Guid SellOrderID { get; set; }

		public string StockSymbol { get; set; }

		[Required(ErrorMessage = "Stock Name can't be null or empty")]
		public string StockName { get; set; }

		public DateTime DateAndTimeOfOrder { get; set; }

		[Range(1, 100000, ErrorMessage = "You can buy maximum of 100000 shares in single order. Minimum is 1.")]
		public uint Quantity { get; set; }

		[Range(1, 1000000, ErrorMessage = "The maximum price of stock is 1,000,000.00 . Minimum is 1.00")]
		public double Price { get; set; }
	}
}
