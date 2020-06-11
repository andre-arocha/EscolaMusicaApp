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
    public partial class FrmProfessor : Form
    {
        public FrmProfessor()
        {
            InitializeComponent();
        }

        // Botão adicionar professor
        private void buttonADD_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor(
               txtNomePro.Text, txtCpfPro.Text, txtEmailPro.Text, txtTelefonePro.Text
               );
            professor.Inserir(professor);
            MessageBox.Show("Professor inserido com sucesso!");
            this.LimparCampos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIdPro.Focus();
        }

        private void LimparCampos()
        {
            txtIdPro.Clear();
            txtNomePro.Clear();
            txtNomePro1.Clear();
            txtCpfPro.Clear();
            txtEmailPro.Clear();
            txtEmailPro1.Clear();
            txtTelefonePro.Clear();
            txtTelefonePro1.Clear();
        }

        // Botão alterar professor
        private void buttaoALTERAR_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Id_pro = int.Parse(txtIdPro.Text);
            professor.Nome_pro = txtNomePro1.Text;
            professor.Email_pro = txtEmailPro1.Text;
            professor.Telefone_pro = txtTelefonePro1.Text;
            professor.Alterar(professor);
            MessageBox.Show("Professor Alterado com sucesso!");
        }

        // Burcar professores por ID
        private void buttonBUSCARID_Click(object sender, EventArgs e)
        {
            if (txtIdPro.ReadOnly == true)
            {
                txtIdPro.ReadOnly = false;
                buttonBUSCARID.Text = "Buscar";

                txtIdPro.Focus();
                LimparCampos();
            }
            else
            {
                if (txtIdPro.Text != string.Empty)
                {
                    Professor professor = new Professor();
                    professor.ObterPorId(int.Parse(txtIdPro.Text));
                    if (professor.Id_pro > 0)
                    {
                        txtNomePro1.Text = professor.Nome_pro;
                        txtEmailPro1.Text = professor.Email_pro;
                        txtTelefonePro1.Text = professor.Telefone_pro;
                    }
                    else
                    {
                        MessageBox.Show("Professor não cadastrado!");
                    }
                    txtIdPro.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Digite um código para buscar...");
                    txtIdPro.Focus();
                }
            }
        }

        // Botão Listar todos os professor cadastrados
        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Professor professor = new Professor();
            foreach (var item in professor.ListarTodos())
            {
                listBox1.Items.Add(item.Id_pro + " - " + item.Nome_pro + " - " +
                    item.Email_pro + " - " + item.DataCadastro_pro);
            }
        }

        // Botão fechar
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
