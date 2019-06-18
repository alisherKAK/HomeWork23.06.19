using System.IO;

namespace HomeWork23_06_19.Services
{
    public delegate void CatalogMoveDelegate(string from, string to);

    public class CatalogMover
    {
        public CatalogMoveDelegate CatalogMoveDelegate = new CatalogMoveDelegate(MoveCatalog);

        private static void MoveCatalog(string from, string to)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(from);
            if (directoryInfo.Exists && Directory.Exists(to) == false)
            {
                directoryInfo.MoveTo(to);
            }
        }
    }
}
