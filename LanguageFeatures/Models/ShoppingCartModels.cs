using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
	public class ShoppingCartModels
	{
		public string abc { get; set; }
		public string currentSortBy { get; set; }
		public string currentSortOrder { get; set; }
		public string currentBeginWith { get; set; }
		public string newSortBy { get; set; }
		public string newSortOrder { get; set; }
		public string newBeginWith { get; set; }
		public List<DataModels.Product> Products { get; set; }
		public string isSubmit { get; set; }
		public int currentPage { get; set; }
		public int newPage { get; set; }
		public int currentPageSize { get; set; }
		public int newPageSize { get; set; }
		public int numOfProducts { get; set; }
		public int numOfPages{ get; set; }
		public string insertRecordAckMsg { get; set; }
		public string insertedRowID { get; set; }
        public decimal totalPrices
		{
			get
			{
				decimal n = 0;

				if (Products != null)
				{
					foreach (DataModels.Product product in Products)
					{
						n += product.Price;
					}
				}

				return n;
			}
		}
	}
}