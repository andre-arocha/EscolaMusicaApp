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

        // Lista de cursos
        private void cmbNomeCurso_SelectedIndexChanged(object sender, EventArgs e)
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

        // Adicionar curso
        private void buttonADD_Click(object sender, EventArgs e)
        {
            int horario = Convert.ToInt32(txtHorario.Text);
            double valor = Convert.ToDouble(txtValor.Text);

            Curso curso = new Curso(
               cmbNomeCurso.Text, horario, valor
                );
            curso.Inserir(curso);
            MessageBox.Show("Curso inserido com sucesso!");
        }

        // Botão alterar cursos
        private void buttaoALTERAR_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor1.Text); 
            Curso curso = new Curso();
            curso.Id_curso = int.Parse(txtIdCurso.Text);
            curso.Nome_curso = cmbNomeCurso.Text;
            curso.Valor_curso = valor;
            curso.Alterar(curso);
            MessageBox.Show("Curso alterado com sucesso!");
        }

        // Limpar campos oo curso
        public void LimparCampos()
        {
            txtIdCurso.Clear();
            cmbNomeCurso.Text = "";
            cmbNomeCurso1.Text = "";
            txtHorario.Clear();
            txtValor.Clear();
            txtValor1.Clear();
        }


        // Botão buscra cursos por ID
        private void buttonBUSCARID_Click(object sender, EventArgs e)
        {
            if (txtIdCurso.ReadOnly == true)
            {
                txtIdCurso.ReadOnly = false;
                buttonBUSCARID.Text = "Buscar";

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
                        if (curso.Nome_curso== "Violão")
                        {
                            cmbNomeCurso1.SelectedIndex = 0;
                        }
                        else if (curso.Nome_curso == "Guitarra")
                        {
                            cmbNomeCurso1.SelectedIndex = 1;
                        }
                        else if (curso.Nome_curso == "Baixo")
                        {
                            cmbNomeCurso1.SelectedIndex = 2;
                        }
                        else if (curso.Nome_curso == "Bateria")
                        {
                            cmbNomeCurso1.SelectedIndex = 3;
                        }
                        else if (curso.Nome_curso == "Teclado")
                        {
                            cmbNomeCurso1.SelectedIndex = 4;
                        }
                        else
                        {
                            cmbNomeCurso1.SelectedIndex = 5;
                        }
                        double valor = Convert.ToDouble(txtValor.Text);
                        curso.Valor_curso = valor;
                    }
                    else
                    {
                        MessageBox.Show("Curso não cadastrado!");
                    }
                    txtIdCurso.ReadOnly = true;
                    txtIdCurso.Focus();
                }
                else
                {
                    MessageBox.Show("Digite um código para buscar...");
                    txtIdCurso.Focus();
                }
            }
        }

        // Botão listar todos
        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Curso curso = new Curso();
            foreach (var item in curso.ListarTodos())
            {
                listBox1.Items.Add(item.Id_curso + " - " + item.Nome_curso + " - " +
                    item.CargaHoraria_curso + " - " + item.Valor_curso);
            }
        }
        

        // BotÃO fechar tabela
        private void buttonFECHAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFECHAR1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFECHAR2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
