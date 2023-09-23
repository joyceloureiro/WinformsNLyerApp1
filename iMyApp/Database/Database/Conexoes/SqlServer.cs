using System.Configuration;

namespace Database.Conexoes
{
    /// <summary>
    /// A <c>SqlServer</c> é uma clase estatica com uma string 
    /// de conexao com SqlServer
    /// </summary>
    internal static class SqlServer
    {
        /// <summary>
        /// Metodo que <c>StrConexao()</c> retorna a string de conexao sql
        /// </summary>
        /// <returns></returns>
        internal static string StarConexao()
        {
            return @"Server=.\SQLEXPRESS;Database=Nothwind;User Id=sa;Password=sql2022;Trusted_Connection=False;TrustServerCertificate=True;";

        }
       

    }
}
