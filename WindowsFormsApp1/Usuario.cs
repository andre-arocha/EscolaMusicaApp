using EscolarMusicApp;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public class Usuario
    {
        public int Id_usuario { get; set; }
        public string Nome_usuario { get; set; }
        public string Email_usuario { get; set; }
        public string Senha_usuario { get; set; }
        public string Situacao_usuario { get; set; }

        // Métodos Construtores
        public Usuario()
        {

        }

        public Usuario(int id_usuario, string nome_usuario, string email_usuario, string senha_usuario, string situacao_usuario)
        {
            Id_usuario = id_usuario;
            Nome_usuario = nome_usuario;
            Email_usuario = email_usuario;     // Todos
            Senha_usuario = senha_usuario;
            Situacao_usuario = situacao_usuario;
        }

        public Usuario(string nome_usuario, string email_usuario, string senha_usuario, string situacao_usuario)
        {
            Nome_usuario = nome_usuario;
            Email_usuario = email_usuario;      // Sem Id
            Senha_usuario = senha_usuario;
            Situacao_usuario = situacao_usuario;
        }
        public Usuario(string nome_usuario, string email_usuario, string senha_usuario)
        {
            Nome_usuario = nome_usuario;
            Email_usuario = email_usuario;    // Sem Situação
            Senha_usuario = senha_usuario;
        }

        public Usuario(string email_usuario, string senha_usuario)
        {
            Email_usuario = email_usuario;    // Sem Nome e Situação
            Senha_usuario = senha_usuario;
        }


        public bool EfetuarLogin(Usuario usuario)
        {
            bool valido = false;
            MySqlCommand cmd = Banco.AbriConexao();
            cmd.CommandText = "select * from tb_usuario where senha_usuario = md5(@senha) and email_usuario = @email;";
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.Senha_usuario;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = usuario.Email_usuario;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id_usuario = dr.GetInt32(0);
                Nome_usuario = dr.GetString(1);
                Situacao_usuario = dr.GetString(4);
                valido = true;
            }
            return valido;
        }

    }
}
