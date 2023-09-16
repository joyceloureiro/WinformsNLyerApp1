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
                            ([Nome]
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
                    cmd.Parameters.AddWithValue("@criadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@criadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@alteradoPor", cargo.AlteradoPor);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                    connection.Close();
                }
            }

            catch (Exception)
            {

                throw;
            }
        }

        public bool Atualizar(Cargo cargo, int cargoId)
        {
            try
            {
                var sql = @"Update Cargo set Nome = @nome, Status = @status, AlteradoEm = @alteradoEm WHERE Id = @Id;";

                using (var connection = new SqlConnection(SqlServer.StarConexao()))
                {
                    connection.Open();

                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@Id", cargoId);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;

                    connection.Close() ;
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
               
                var sql = @"DELETE FROM Cargo WHERE Id = @id; ";

                using (var connection = new SqlConnection(SqlServer.StarConexao()))
                {                   
                    connection.Open();

                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Id", cargoId);

                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;

                    connection.Close() ;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ObterTodos()
        {
            var sql = @"SELECT Id,Nome, Status, AlteradoEm  FROM Cargo";

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


    }
}
