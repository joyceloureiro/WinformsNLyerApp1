using Dapper;
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
    public class ProdutoRepository
    {
        public List<Produto> ObterRelatorioEstoque()
        {
            var sql = @"SELECT p.IDProduto AS Codigo,
	           p.NomeProduto AS Nome, 
	           p.PrecoUnitario AS Preço,
	           P.UnidadesEmEstoque AS Estoque,
	           c.NomeCategoria As Categoria
               FROM Produtos p 
               INNER JOIN Categorias c
               ON p.IDCategoria = c.IDCategoria
               WHERE p.UnidadesEmEstoque > 0";

            try
            {
                using (var connection = new SqlConnection(SqlServer.StarConexao()))
                {
                    var resultdo = connection.Query<Produto>(sql);
                    return resultdo.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

            
     }
}
