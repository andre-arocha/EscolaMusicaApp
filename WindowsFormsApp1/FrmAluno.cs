using EscolarMusicApp;
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
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();
        }

        // Foco cursos da pagina
        private void Form1_Load(object sender, EventArgs e)
        {
            txtId.Focus();
            txtNome.Focus();
        }

        // Botão pra Adicionar aluno
        private void buttonADD_Click(object sender, EventArgs e)
        {
            string sexo = cmbSexo.Text;
            sexo = sexo.Substring(0, 1);
            Aluno aluno = new Aluno(
                txtNome.Text, txtCpf.Text, sexo, txtEmail.Text, txtTelefone.Text
                );
            aluno.Inserir(aluno);
            MessageBox.Show("Aluno inserido com sucesso!");
            this.LimparCampos();
        }

        // Listar Todos os alunos cadastrados os alunos cadastrados  no ListBox
        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Aluno aluno = new Aluno();
            foreach (var item in aluno.ListarTodos())
            {
                listBox1.Items.Add(item.Id + " - " + item.Nome + " - " +
                    item.Email + " - " + item.DataCadastro);
            }
        }

        // Limpar todos as caixas de texto
        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtNome1.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtEmail1.Clear();
            txtTelefone.Clear();
            txtTelefone1.Clear();
            cmbSexo.Text = "";
            cmbSexo1.Text = "";
        }

        // botão buscar por ID
        private void buttonBUSCARID_Click(object sender, EventArgs e)
        {
            if (txtId.ReadOnly == true)
            {
                txtId.ReadOnly = false;
                buttonBUSCARID.Text = "Buscar";

                txtId.Focus();
                LimparCampos();
            }
            else
            {
                if (txtId.Text != string.Empty)
                {
                    Aluno aluno = new Aluno();
                    aluno.ObterPorId(int.Parse(txtId.Text));
                    if (aluno.Id > 0)
                    {
                        txtNome1.Text = aluno.Nome;
                        if (aluno.Sexo == "M")
                        {
                            cmbSexo1.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbSexo1.SelectedIndex = 1;
                        }
                        txtEmail1.Text = aluno.Email;
                        txtTelefone1.Text = aluno.Telefone;
                    }
                    else
                    {
                        MessageBox.Show("Aluno não cadastrado!");
                    }
                    txtId.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Digite um código para buscar...");
                    txtId.Focus();
                }
            }
        }

        // Botão alterra aluno
        private void buttaoALTERAR_Click(object sender, EventArgs e)
        {
            string sexo = cmbSexo1.Text;
            sexo = sexo.Substring(0, 1);
            Aluno aluno = new Aluno();
            aluno.Id = int.Parse(txtId.Text);
            aluno.Nome = txtNome1.Text;
            aluno.Sexo = sexo;
            aluno.Email = txtEmail1.Text;
            aluno.Telefone = txtTelefone1.Text;
            aluno.Alterar(aluno);
            MessageBox.Show("Aluno Alterado com sucesso!");
        }

        // Botão fechar pagina
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

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
    }
}