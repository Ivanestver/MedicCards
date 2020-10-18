using System.Data.OleDb;

namespace MedicCards
{
    class Db
    {
        //private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\MedicCards\MedicCards\MyBase.mdf;Integrated Security = True";
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBase.mdb";

        OleDbConnection connection = new OleDbConnection(connectionString);

        public OleDbConnection getConnection()
        {
            return connection;
        }
    }
}
