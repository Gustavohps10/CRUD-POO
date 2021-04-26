using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD_de_JOGOS___POO
{
    class Jogo
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string data_lancamento { get; set; }
        public string desenvolvedor { get; set; }
        public string genero { get; set; }

        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\MeusProgramas\\C#\\CRUD de JOGOS - POO\\CRUD de JOGOS - POO\\DbJogos.mdf;Integrated Security = True");

        public void Inserir(string nome, string data_lancamento, string desenvolvedor, string genero)
        {
            string sql = "INSERT INTO Jogo(nome, data_lancamento, desenvolvedor, genero) VALUES ('"+nome+"','"+data_lancamento+"', '"+desenvolvedor+ "', '" +genero+ "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Jogo> ListaJogos()
        {
            List<Jogo> li = new List<Jogo>();
            string sql = "SELECT *FROM Jogo";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Jogo j = new Jogo();
                j.id = (int)dr["Id"];
                j.nome = dr["nome"].ToString();
                j.data_lancamento = dr["data_lancamento"].ToString();
                j.desenvolvedor = dr["desenvolvedor"].ToString();
                j.genero = dr["genero"].ToString();
                li.Add(j);
            }
            return li;
        }

        public void Localiza(int id)
        {
            string sql = "SELECT *FROM Jogo WHERE Id = '"+id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nome = rd["nome"].ToString().Trim();
                desenvolvedor = rd["desenvolvedor"].ToString().Trim();
                genero = rd["genero"].ToString().Trim();
                data_lancamento = rd["data_lancamento"].ToString();
            }
        }

        public void Atualizar(int id, string nome, string data_lancamento, string desenvolvedor, string genero)
        {
            string sql = "UPDATE Jogo SET nome = '" + nome + "', data_lancamento='" + data_lancamento + "', desenvolvedor='" + desenvolvedor + "', genero='" + genero + "' WHERE Id='"+id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Deletar(int id)
        {
            string sql = "DELETE FROM Jogo WHERE Id='" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
