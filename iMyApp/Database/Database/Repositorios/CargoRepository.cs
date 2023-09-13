using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;

namespace Database.Repositorios
{
    public class CargoRepository
    {
        public int Inserir(Cargo cargo)
        {
            var stringConexao = SqlServer.StarConexao();
            var sqlConnection = new SqlConnection(stringConexao);

            sqlConnection.Open();

            var sql = @"INSERT INTO [dbo].[Cargo]
                           ([Id]
                           ,[Nome]
                           ,[Status]
                           ,[CriadoEm]
                           ,[CriadoPor]
                           ,[AlteradoEm]
                           ,[AlteradoPor])
                     VALUES
                           (@nome, 
                            @status,
                            @criadoEm,
                            @criadoPor,
                            @alteradoEm,
                            @alteradoPor)";

            var cmd = new SqlComand();
            cmd.ComandText = sql;
            cmd.Para("@nome",);


            stringConexao.Clone();

        }

    }
}
