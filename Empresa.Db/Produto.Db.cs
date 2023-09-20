using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Empresa.Models;
using System.Runtime.Remoting;

namespace Empresa.Db
{
   public class ProdutoDb
    {
        public void Incluir(Produto produto) 

        {
            string sql = "INSERT INTO Produto (Id,Nome) Values(@Id,@Nome)";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id",produto.Id);
            cmd.Parameters.AddWithValue("@Nome", produto.Nome);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        public void Alterar(Produto produto)

        {
            string sql = "UPDATE Produto SET Nome =@Nome WHERE Id=@Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", produto.Id);
            cmd.Parameters.AddWithValue("@Nome", produto.Nome);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        public void Excluir(int Id)

        {
            string sql = "DELETE Produto WHERE Id=@Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id",Id);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        public List<Produto> Listar()
        {

            string sql = "SELECT Id,Nome FROM Produto";
            var cn = new SqlConnection(Db.Conexao);

            var cmd = new SqlCommand(sql, cn);

            List<Produto> lista = new List<Produto>();

            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var produto = new Produto();
                produto.Id = Convert.ToInt32(reader["Id"]);
                produto.Nome = reader["Nome"].ToString();
                
                lista.Add(produto);
            }
            reader.Close();
            cn.Close();
            return lista;

        }

    }
}
