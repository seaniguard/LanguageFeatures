using LanguageFeatures.DataModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
	public class ProductModels
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		private string _FullName = null;
		public string FullName
		{
			get
			{
				if (_FullName == null)
				{
					_FullName = FirstName + " " + LastName;
				}

				return _FullName;
			}
			set
			{
				_FullName = value;
			}
		}
	}

	//public class Product
	//{
	//	public string ProductID { get; set; }
	//	public string Name { get; set; }
	//	public string Description { get; set; }
	//	public decimal Price { get; set; }
	//	public string Category { get; set; }
	//}

	public class ShoppingCart : IEnumerable<Product>
	{
		public List<Product> Products { get; set; }
		public decimal totalPrices
		{
			get
			{
				decimal n = 0;

				foreach(Product product in Products)
				{
					n += product.Price;
				}

				return n;
			}
		}

		public IEnumerator<Product> GetEnumerator()
		{
			return Products.GetEnumerator();
        }

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
    }

	public static class MyExtensionMethods
	{
		public static decimal TotalPrices(this ShoppingCart cartParam)
		{
			decimal total = 0;
			foreach (Product prod in cartParam.Products)
			{
				total += prod.Price;
			}
			return total;
		}
	}
}