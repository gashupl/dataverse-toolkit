namespace Pg.SolutionDownloaderCore.Data
{
	internal class DataverseCallException : Exception
	{
		public DataverseCallException(string message, Exception innerException) : base(message, innerException) { } 
	}
}
