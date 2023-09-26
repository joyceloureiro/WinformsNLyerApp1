using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System.Data;

namespace Database.Repositorios
{
    /// <summary>
    /// <c>CargoRepository</c> - Executa comandos SQL (CRUD) na tabela de [dbo].[Cargo]
    /// <exemple>Exemplo:
    ///     var repositorio = new CargoRepository();
    /// </exemple>
    /// </summary>
    public class CargoRepository
    {
        /// <summary>
        /// Insere um novo registro na tabela Cargo
        /// <example>Exemplo:
        /// <code>
        ///     var repositorio = new CargoRepository();
        ///     var cargo = new Cargo("Nome", "Status");
        ///     var resultado = cargpRepositorio.Incluir(cargo);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="cargo">Entidade->Cargo</param>
        /// <returns>true ou false</returns>
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

        public bool Atualizar(Cargo cargo,int id)
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
                    cmd.Parameters.AddWithValue("@id", id);

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
