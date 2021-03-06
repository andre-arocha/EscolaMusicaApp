﻿using EscolarMusicApp;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
        public Curso Curso { get; set; }
        public string Situacao { get; set; }
        public double ValorCurso { get; set; }
        public DateTime DataMatricula { get; set; }
        public Usuario Usuario { get; set; }

        public Matricula()
        {
            Aluno = new Aluno();
            Usuario = new Usuario();
            Curso = new Curso();

        }

        public Matricula(int id, Aluno aluno, Curso curso, string situacao, double valorCurso, DateTime dataMatricula, Usuario usuario)
        {
            Id = id;
            Aluno = aluno;
            Curso = curso;
            Situacao = situacao;
            ValorCurso = valorCurso;
            DataMatricula = dataMatricula;
            Usuario = usuario;
        }

        public Matricula(Aluno aluno, Curso curso, Usuario usuario)
        {
            Aluno = aluno;
            Curso = curso;
            Usuario = usuario;
        }

        public void Inserir(Aluno aluno, Curso curso, Usuario usuario)
        {
            var cmd = Banco.AbriConexao();
            cmd.CommandText = "insert tb_matricula values(null, @alunoId, @cursoId, 'A', @valorCurso, now(), @usuarioId);";
            cmd.Parameters.Add("@alunoId", MySqlDbType.Int32).Value = aluno.Id;
            cmd.Parameters.Add("@cursoId", MySqlDbType.Int32).Value = curso.Id_curso;
            cmd.Parameters.Add("@valorCurso", MySqlDbType.Decimal).Value = curso.Valor_curso;
            cmd.Parameters.Add("@usuarioId", MySqlDbType.Int32).Value = usuario.Id_usuario;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public MySqlDataReader ListarAtivas()
        {
            var cmd = Banco.AbriConexao();
            cmd.CommandText = "select Id_matricula as ID, nome_aluno as Aluno, nome_curso as Curso, " +
                "data_matricula as Data from vw_matricula where situacao = 'A' ";
            return cmd.ExecuteReader();
        }

        public MySqlDataReader ListarRelacoesAtivas()
        {
            var cmd = Banco.AbriConexao();
            cmd.CommandText = "select " +
                "id_matricula as IdMatricula, " +
                "id_aluno as IdAluno, " +
                "nome_aluno as Aluno," +
                "email_aluno as Email, " +
                "telefone_aluno as Telefone, " +
                "id_curso as IdCurso, " +
                "nome_curso as Curso, " +
                "carga_horaria_curso as Carga_Horaria, " +
                "valor_curso as Valor, " +
                "id_professor as IdProfessor, " +
                "nome_professor as professor, " +
                "data_matricula as Data " +
                "from vw_relacoes where situacao = 'A' ";
            return cmd.ExecuteReader();
        }

    }
}
