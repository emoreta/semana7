using S7EdisonMoreta9A.Droid;
using SQLite;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(SqLiteCliente))]
namespace S7EdisonMoreta9A.Droid
{
    public class SqLiteCliente
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            var path = Path.Combine(documentPath, "uisrael.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}