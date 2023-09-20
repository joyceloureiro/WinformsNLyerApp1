using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class FuncionarioRepository
    {
        public bool Inserir(Funcionario funcionario)
        {
            try
            {

                var sql = @"INSERT INTO [dbo].[CadastroFuncionario]
                           ([Nome]
                           ,[Nacionalidade]
                           ,[DataDeNascimento]
                           ,[EstadoCivil]
                           ,[Endereco]
                           ,[Rg]
                           ,[Telefone]
                           ,[Sexo]
                           ,[Cic]
                           ,[DataDeAdimissao])
                                                VALUES
                            (@nome, 
                            @nacionalidade, 
                            @dataDeNascimento, 
                            @estadoCivil,
                            @endereco,
                            @rg,
                            @telefone, 
                            @sexo, 
                            @cic, 
                            @dataDeAdimissao)";

                using (var connection = new SqlConnection(SqlServer.StarConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@nacionalidade, ", funcionario.Nacionalidade);
                    cmd.Parameters.AddWithValue("@dataDeNascimento", funcionario.DataDeNascimento);
                    cmd.Parameters.AddWithValue("@estadoCivil", funcionario.EstadoCivil);
                    cmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                    cmd.Parameters.AddWithValue("@rg", funcionario.Rg);
                    cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                    cmd.Parameters.AddWithValue("@sexo ", funcionario.Sexo);
                    cmd.Parameters.AddWithValue("@cic", funcionario.Cic);
                    cmd.Parameters.AddWithValue("@dataDeAdimissao", funcionario.DataDeAdimissao);
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

    }
}
