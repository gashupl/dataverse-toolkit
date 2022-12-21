namespace Pg.SolutionDownloaderCore.Data
{
	internal class FileWrapper : IFile
	{
		public void WriteAllBytes(string path, byte[] bytes)
		{
			File.WriteAllBytes(path, bytes);
		}
	}
}
