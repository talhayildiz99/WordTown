using System.Data.OleDb;

namespace WordTown
{
    class DatabaseClass
    {
        public static string databaseString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Hp\Desktop\C# Projelerim\İngilizce Kelime Hazinesi\dbSozluk\dbSozluk.accdb""";
        public static OleDbConnection oleDbConnection;

        public static void DatabaseInstantiate()
        {
            oleDbConnection = new OleDbConnection(databaseString);
        }
    }
}
