using System.Configuration;

namespace Database.Conexoes
{
    internal static class SqlServer
    {
        internal static string StarConexao()
        {
            return "Server=localhost;Database=iMyApp;User Id=sa;Password=sql2022;";
        }
       

    }
}
