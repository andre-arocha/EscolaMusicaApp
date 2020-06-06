using EscolarMusicApp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Matricula
    {
        public int Id { get; set; }
        public Aluno Aluno { get; set; }
        public Turma Turma { get; set; }
        public string Situacao { get; set; }
        public double ValorCurso { get; set; }
        public DateTime DataMatricula { get; set; }
        public Usuario Usuario { get; set; }

        public Matricula()
        {
            Aluno = new Aluno();
            Usuario = new Usuario();
            Turma = new Turma();

        }

        public Matricula(int id, Aluno aluno, Turma turma, string situacao, double valorCurso, DateTime dataMatricula, Usuario usuario)
        {
            Id = id;
            Aluno = aluno;
            Turma = turma;
            Situacao = situacao;
            ValorCurso = valorCurso;
            DataMatricula = dataMatricula;
            Usuario = usuario;
        }

        public Matricula(Aluno aluno, Turma turma, double valorCurso, Usuario usuario)
        {
            Aluno = aluno;
            Turma = turma;
            ValorCurso = valorCurso;
            Usuario = usuario;
        }

        public void Inserir()
        {
            var cmd = Banco.AbriConexao();
            cmd.CommandText = "insert tb_matricula values(null, @alunoId,@turmaId,'A',@valorCurso,now(),@idUsuario);";
            cmd.Parameters.Add("@alunoId", MySqlDbType.Int32).Value = Aluno.Id;
            cmd.Parameters.Add("@turmaId", MySqlDbType.Int32).Value = Turma.Id;
            cmd.Parameters.Add("@valorCurso", MySqlDbType.Decimal).Value = Turma.Curso.Valor_curso;
            cmd.Parameters.Add("@usuarioId", MySqlDbType.Int32).Value = Usuario.Id_usuario;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

    }
}
