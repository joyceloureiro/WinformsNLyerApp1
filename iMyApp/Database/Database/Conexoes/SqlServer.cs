using System.Configuration;

namespace Database.Conexoes
{
    internal static class SqlServer
    {
        internal static string StarConexao()
        {
            return @"Server=.\SQLEXPRESS;Database=iMyApp;User Id=sa;Password=sql2022;Trusted_Connection=False;TrustServerCertificate=True;";
        }
       

    }
}
