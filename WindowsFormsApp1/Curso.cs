using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolarMusicApp;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class Curso
    {
        public int Id_curso { get; set; }
        public string Nome_curso { get; set; }
        public string CargaHoraria_curso { get; set; }
        public decimal Valor_curso { get; set; }

        public Curso()
        {

        }

        public Curso(string nome_curso, string cargaHoraria_curso, decimal valor_curso)
        {
            Nome_curso = nome_curso;
            CargaHoraria_curso = cargaHoraria_curso;
            Valor_curso = valor_curso;
        }

        public Curso(int id_curso, string nome_curso, string cargaHoraria_curso, decimal valor_curso)
        {
            Id_curso = id_curso;
            Nome_curso = nome_curso;
            CargaHoraria_curso = cargaHoraria_curso;
            Valor_curso = valor_curso;
        }

        public bool EfetuarLogin(Curso curso)
        {
            return true;
        }
        public void Inserir(Curso curso)
        {
            MySqlCommand cmd = Banco.AbriConexao();
            cmd.CommandText = "insert tb_curso values(null, @nome, @cargaHoraria_curso, @valor_curso, default);";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = curso.Nome_curso;
            cmd.Parameters.Add("@cargaHoraria", MySqlDbType.VarChar).Value = curso.CargaHoraria_curso;
            cmd.Parameters.Add("@valorCurso", MySqlDbType.VarChar).Value = curso.Valor_curso;
            cmd.ExecuteNonQuery();
        }
        public void Alterar(Curso curso)
        {
            MySqlCommand cmd = Banco.AbriConexao();
            cmd.CommandText = "update tb_curso set nome_curso=@nome_curso, cargaHoraria_curso=@cargaHoraria_curso, valor_curso=@valorCurso_curso  where id_curso =@id_curso";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = curso.Nome_curso;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = curso.Id_curso;
            cmd.Parameters.Add("@cargaHoraria", MySqlDbType.VarChar).Value = curso.CargaHoraria_curso;
            cmd.Parameters.Add("@valorCurso", MySqlDbType.VarChar).Value = curso.Valor_curso;
            cmd.ExecuteNonQuery();
        }
        public List<Curso> ListarTodos()
        {
            List<Curso> cursos = new List<Curso>();
            var cmd = Banco.AbriConexao();
            cmd.CommandText = "select * from tb_curso ";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cursos.Add(
                    new Curso(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetDecimal(3)
                        ));
            }
            return cursos;
        }
        public void ObterPorId(int id_usuario)
        {
            var cmd = Banco.AbriConexao();
            cmd.CommandText = "select * from tb_usuario where id_usuario = " + id_usuario;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id_usuario = dr.GetInt32(0);
                Nome_curso = dr.GetString(1);
                CargaHoraria_curso = dr.GetString(2);
                Valor_curso = dr.GetDecimal(3);
            }
        }
    }
}
