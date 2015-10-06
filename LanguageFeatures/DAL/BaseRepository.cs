using LanguageFeatures.DataModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.DAL
{
	public class BaseRepository : IDisposable
	{
		private InventoryEntities _ctx = null;

		protected InventoryEntities ctx
		{
			get
			{
				if (_ctx == null) _ctx = new InventoryEntities();
				return _ctx;
			}
		}

		public void Dispose()
		{
			// throw new NotImplementedException();
			if (_ctx != null) _ctx.Dispose();
		}

		protected string cachePrefix = "Product_";

		protected void ClearCache()
		{
			// clear all related cache (151002)
			List<string> itemsToRemove = new List<string>();
			IDictionaryEnumerator enumerator = HttpRuntime.Cache.GetEnumerator();

			while (enumerator.MoveNext())
			{
				if (enumerator.Key.ToString().StartsWith(cachePrefix))
				{
					itemsToRemove.Add(enumerator.Key.ToString());
				}
			}

			foreach (string itemToRemove in itemsToRemove)
			{
				HttpRuntime.Cache.Remove(itemToRemove);
			}
		}
	}
}