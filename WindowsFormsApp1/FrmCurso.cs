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
            if (cmbNomeCurso.SelectedIndex == 0) // Violão
            {
                txtHorario.Text = "392"; // 2 anos
                txtValor.Text = "1440"; // 60 por mês
            }
            else if (cmbNomeCurso.SelectedIndex == 1) //Guitarra
            {
                txtHorario.Text = "392"; // 2 anos
                txtValor.Text = "1560"; // 65 por mês
            }
            else if (cmbNomeCurso.SelectedIndex == 2) // Baixo
            {
                txtHorario.Text = "392"; // 2 anos
                txtValor.Text = "1560"; // 65 por mês
            }
            else if (cmbNomeCurso.SelectedIndex == 3) // Bateria
            {
                txtHorario.Text = "392"; // 2 anos
                txtValor.Text = "1680"; // 70 por mês
            }
            else if (cmbNomeCurso.SelectedIndex == 4) // Teclado
            {
                txtHorario.Text = "392"; // 2 anos
                txtValor.Text = "1560"; // 65 por mês
            }
            else // Canto
            {
                txtHorario.Text = "392"; // 2 anos
                txtValor.Text = "1200"; // 50 por mês 
            }
        }

        // GRAVAR CURSOS
        private void button1_Click(object sender, EventArgs e)
        {
            int horario = Convert.ToInt32(txtHorario.Text);
            double valor = Convert.ToDouble(txtValor.Text);

            Curso curso = new Curso(
               cmbNomeCurso.Text, horario, valor
                );
            curso.Inserir(curso);
            MessageBox.Show("Curso inserido com sucesso!");
        }

        // ALTERAR CURSOS
        private void button4_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txtValor.Text);

            Curso curso = new Curso();
            curso.Id_curso = int.Parse(txtIdCurso.Text);
            curso.Nome_curso = cmbNomeCurso.Text;
            curso.Valor_curso = valor;
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
                        int horario = Convert.ToInt32(txtHorario.Text);
                        double valor = Convert.ToDouble(txtValor.Text);
                        horario = curso.CargaHoraria_curso;
                        valor = curso.Valor_curso;
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

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Curso curso = new Curso();
            foreach (var item in curso.ListarTodos())
            {
                listBox1.Items.Add(item.Id_curso + " - " + item.Nome_curso + " - " +
                    item.CargaHoraria_curso + " - " + item.Valor_curso);
            }
        }
    }
}
