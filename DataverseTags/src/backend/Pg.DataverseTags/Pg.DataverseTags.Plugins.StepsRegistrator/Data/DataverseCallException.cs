using System;

namespace Pg.DataverseTags.Plugins.StepsRegistrator.Data
{
	internal class DataverseCallException : Exception
	{
		public DataverseCallException(string message, Exception innerException) : base(message, innerException) { } 
	}
}
