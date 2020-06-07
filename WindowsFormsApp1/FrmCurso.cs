using Org.BouncyCastle.Cms;
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
    public partial class FrmCurso : Form
    {
        public FrmCurso()
        {
            InitializeComponent();
        }

        // CURSOS
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNomeCurso.SelectedIndex == 0)
            {
                txtHorario.Text = "392";
                txtValor.Text = "1440.00";
            }
            else if (cmbNomeCurso.SelectedIndex == 1)
            {
                txtHorario.Text = "392";
                txtValor.Text = "1800.00";
            }
            else if (cmbNomeCurso.SelectedIndex == 2)
            {
                txtHorario.Text = "392";
                txtValor.Text = "1680.00";
            }
            else if (cmbNomeCurso.SelectedIndex == 3)
            {
                txtHorario.Text = "392";
                txtValor.Text = "1920.00";
            }
            else 
            {
                txtHorario.Text = "392";
                txtValor.Text = "1200.00";
            }
        }

        // GRAVAR CURSOS
        private void button1_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso(
               cmbNomeCurso.Text, txtHorario.Text, txtValor.Text
                );
            curso.Inserir(curso);
            MessageBox.Show("Curso inserido com sucesso!");
        }

        // ALTERAR CURSOS
        private void button4_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Id_curso= int.Parse(txtIdCurso.Text);
            curso.Nome_curso = cmbNomeCurso.Text;
            curso.Valor_curso = txtValor.Text;
            curso.Alterar(curso);
            MessageBox.Show("Curso alterado com sucesso!");
        }

        // LIMPAR CAMPOS
        public void LimparCampos()
        {
            txtIdCurso.Clear();
            cmbNomeCurso.Text = "";
            txtHorario.Clear();
            txtValor.Clear();
        }

       
        // BUSCAR POR ID
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtIdCurso.ReadOnly == true)
            {
                txtIdCurso.ReadOnly = false;
                button3.Text = "Buscar";

                txtIdCurso.Focus();
                LimparCampos();
            }
            else
            {
                if (txtIdCurso.Text != string.Empty)
                {
                   Curso curso = new Curso();
                    curso.ObterPorId(int.Parse(txtIdCurso.Text));
                    if (curso.Id_curso > 0)
                    {
                        cmbNomeCurso.Text = curso.Nome_curso;
                        txtHorario.Text = curso.CargaHoraria_curso;
                        txtValor.Text = curso.Valor_curso;
                    }
                    else
                    {
                        MessageBox.Show("Curso não cadastrado!");
                    }
                    txtIdCurso.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Digite um código para buscar...");
                    txtIdCurso.Focus();
                }
            }
        }

        // FECHAR TABELA CURSO
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
