using System;
using System.Collections.Generic;

namespace Pg.DataverseTags.Plugins.Validators
{
	internal class IsValidResponse
	{
		public bool IsValid { get; set; }
		public List<string> Errors { private get; set; } = new List<string>();

		public string GetErrors()
		{
			return string.Join(Environment.NewLine, Errors); 
		}
	}
}
