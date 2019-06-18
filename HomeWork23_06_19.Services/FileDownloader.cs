using System.Net;

namespace HomeWork23_06_19.Services
{
    public delegate void FileDownloadDelegate(string url, string fileName);

    public class FileDownloader
    {
        public FileDownloadDelegate FileDownloadDelegate = new FileDownloadDelegate(DownloadFile);

        private static void DownloadFile(string url, string fileName)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(url, fileName);
                }
            }
            catch(WebException)
            {

            }
        }
    }
}
