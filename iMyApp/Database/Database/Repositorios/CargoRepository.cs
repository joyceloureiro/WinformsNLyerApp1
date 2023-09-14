using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System.Data;

namespace Database.Repositorios
{
    public class CargoRepository
    {
        public bool Inserir(Cargo cargo)
        {
            try
            {
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

                using (var connection = new SqlConnection(SqlServer.StarConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    cmd.Parameters.AddWithValue("@CriadosEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@AlteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@AlteradoPor", cargo.AlteradoPor);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }
            }

            catch (Exception )
            {

                throw ;
            }
        }

        public bool Atualizar(Cargo cargo)
        {
            try
            {
                var sql = @"";

                using (var connection = new SqlConnection(SqlServer.StarConexao()))
                {
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Deletar(int cargoId)
        {
            try
            {
                var sql = @"";

                using (var connection = new SqlConnection(SqlServer.StarConexao()))
                {
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Id", cargoId);

                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ObterTodos(int cargoId)
        {
            var sql = @"";

            SqlDataAdapter dataAdapter = null;
            var dataTable = new DataTable();

            try
            {
                using (var connection = new SqlConnection(SqlServer.StarConexao()))
                {
                    var cmd = connection.CreateCommand();

                    cmd.CommandText = sql;

                    dataAdapter = new SqlDataAdapter(cmd.CommandText, connection);
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        /*public int Inserir(Cargo cargo)
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
        */
    }
}
