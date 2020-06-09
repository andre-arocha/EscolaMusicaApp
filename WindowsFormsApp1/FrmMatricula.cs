﻿using EscolarMusicApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMatricula : Form
    {
        public FrmMatricula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            var listaAluno = aluno.ListarTodos();
            cmbAluno.DataSource = listaAluno;
            cmbAluno.DisplayMember = "Nome";
            cmbAluno.ValueMember = "Id";

            Curso curso = new Curso();
            var listaCurso = curso.ListarTodos();
            cmbCurso.DataSource = listaCurso;
            cmbCurso.DisplayMember = "Nome_curso";
            cmbCurso.ValueMember = "Id_curso";

        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.ObterPorId(Convert.ToInt32(cmbAluno.SelectedValue));

            Curso curso = new Curso();
            curso.ObterPorId(Convert.ToInt32(cmbCurso.SelectedValue));

            Matricula matricula = new Matricula();
            matricula.Inserir(aluno, curso, Program.usuarioLogado);

            MessageBox.Show("Matrícula realizada com sucesso.");
        }


    }
}
