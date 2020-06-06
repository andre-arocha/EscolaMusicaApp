using EscolarMusicApp;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Professor
    {
        public int Id_pro { get; set; }
        public string Nome_pro { get; set; }
        public string Cpf_pro { get; set; }
        public string Email_pro { get; set; }
        public string Telefone_pro { get; set; }
        public DateTime DataCadastro_pro { get; set; }

        public Professor()
        {

        }

        public Professor(string nome_pro, string cpf_pro, string email_pro, string telefone_pro)
        {
            Nome_pro = nome_pro;
            Cpf_pro = cpf_pro;
            Email_pro = email_pro;
            Telefone_pro = telefone_pro;
        }

        public Professor(int id_pro, string nome_pro, string cpf_pro, string email_pro, string telefone_pro, DateTime dataCadastro_pro)
        {
            Id_pro = id_pro;
            Nome_pro = nome_pro;
            Cpf_pro = cpf_pro;
            Email_pro = email_pro;
            Telefone_pro = telefone_pro;
            DataCadastro_pro = dataCadastro_pro;
        }

        public bool EfetuarLogin(Professor professor)
        {
            return true;
        }

        public void Inserir(Professor professor)
        {
            MySqlCommand cmd = Banco.AbriConexao();
            cmd.CommandText = "insert tb_professor values(null, @nome_pro, @cpf_pro, @email_pro, @telefone_pro, default);";
            cmd.Parameters.Add("@nome_pro", MySqlDbType.VarChar).Value = professor.Nome_pro;
            cmd.Parameters.Add("@cpf_pro", MySqlDbType.VarChar).Value = professor.Cpf_pro;
            cmd.Parameters.Add("@email_pro", MySqlDbType.VarChar).Value = professor.Email_pro;
            cmd.Parameters.Add("@telefone_pro", MySqlDbType.VarChar).Value = professor.Telefone_pro;
            cmd.ExecuteNonQuery();
        }

        public void Alterar(Professor professor)
        {
            MySqlCommand cmd = Banco.AbriConexao();
            cmd.CommandText = "update tb_professor set nome_professor=@nome_pro, email_professor=@email_pro, telefone_professor=@telefone_pro where id_professor =@id_pro";
            cmd.Parameters.Add("@nome_pro", MySqlDbType.VarChar).Value = professor.Nome_pro;
            cmd.Parameters.Add("@id_pro", MySqlDbType.Int32).Value = professor.Id_pro;
            cmd.Parameters.Add("@email_pro", MySqlDbType.VarChar).Value = professor.Email_pro;
            cmd.Parameters.Add("@telefone_pro", MySqlDbType.VarChar).Value = professor.Telefone_pro;
            cmd.ExecuteNonQuery();
        }

        public List<Professor> ListarTodos()
        {
            List<Professor> professores = new List<Professor>();
            var cmd = Banco.AbriConexao();
            cmd.CommandText = "select * from tb_professor ";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                professores.Add(
                new Professor(dr.GetInt32(0),
                              dr.GetString(1),
                              dr.GetString(2),
                              dr.GetString(3),
                              dr.GetString(4),
                              dr.GetDateTime(5)
                              ));
            }
            return professores;
        }
        public void ObterPorId(int id_pro)
        {
            var cmd = Banco.AbriConexao();
            cmd.CommandText = "select * from tb_professor where id_professor = " + id_pro;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id_pro = dr.GetInt32(0);
                Nome_pro = dr.GetString(1);
                Cpf_pro = dr.GetString(2);
                Email_pro = dr.GetString(3);
                Telefone_pro = dr.GetString(4);
                DataCadastro_pro = dr.GetDateTime(5);
            }
        }
    }
}

