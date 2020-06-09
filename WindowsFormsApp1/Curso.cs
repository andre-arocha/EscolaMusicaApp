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
        public int CargaHoraria_curso { get; set; }
        public double Valor_curso { get; set; }

        public Curso()
        {
            CargaHoraria_curso = 0;
        }
        public Curso(int id_curso, string nome_curso, int cargaHoraria_curso, double valor_curso)
        {
            Id_curso = id_curso;
            Nome_curso = nome_curso;
            CargaHoraria_curso = cargaHoraria_curso;
            Valor_curso = valor_curso;
        }

        public Curso(string nome_curso, int cargaHoraria_curso, double valor_curso)
        {
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
            cmd.CommandText = "insert tb_curso values(null, @nome_curso, @cargaHoraria_curso, @valor_curso);";
            cmd.Parameters.Add("@nome_curso", MySqlDbType.VarChar).Value = curso.Nome_curso;
            cmd.Parameters.Add("@cargaHoraria_curso", MySqlDbType.VarChar).Value = curso.CargaHoraria_curso;
            cmd.Parameters.Add("@valor_curso", MySqlDbType.VarChar).Value = curso.Valor_curso;
            cmd.ExecuteNonQuery();

        }
        public void Alterar(Curso curso)
        {
            MySqlCommand cmd = Banco.AbriConexao();
            cmd.CommandText = "update tb_curso set nome_curso=@nome_curso, valor_curso=@valor_curso where id_curso =@id_curso";
            cmd.Parameters.Add("@nome_curso", MySqlDbType.VarChar).Value = curso.Nome_curso;
            cmd.Parameters.Add("@id_curso", MySqlDbType.Int32).Value = curso.Id_curso;
            cmd.Parameters.Add("@valor_curso", MySqlDbType.VarChar).Value = curso.Valor_curso;
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
                        dr.GetInt32(2),
                        dr.GetDouble(3)
                        ));
            }
            return cursos;
        }

        public void ObterPorId(int id_curso)
        {
            var cmd = Banco.AbriConexao();
            cmd.CommandText = "select * from tb_curso where id_curso = " + id_curso;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id_curso = dr.GetInt32(0);
                Nome_curso = dr.GetString(1);
                CargaHoraria_curso = dr.GetInt32(2);
                Valor_curso = dr.GetDouble(3);
            }
        }
    }
}
