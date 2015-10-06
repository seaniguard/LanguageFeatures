using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.MyEnums
{
	public enum MyError
	{
		Success = 0,
		Invalid = 1,
		Duplicated = 2,
		UnknownError = 99
	}
}