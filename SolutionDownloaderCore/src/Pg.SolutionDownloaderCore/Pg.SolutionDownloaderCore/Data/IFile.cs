namespace Pg.SolutionDownloaderCore.Data
{
	public interface IFile
	{
		void WriteAllBytes(string path, byte[] bytes); 
	}
}
