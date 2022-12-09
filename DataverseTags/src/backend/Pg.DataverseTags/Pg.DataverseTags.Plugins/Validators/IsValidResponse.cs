using System.Collections.Generic;

namespace Pg.DataverseTags.Plugins.Validators
{
	internal class IsValidResponse
	{
		public bool IsValid { get; set; }
		public List<string> Errors { get; set; }
	}
}
