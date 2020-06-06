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

        private void button1_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor(
                txtNomePro.Text, txtCpfPro.Text, txtEmailPro.Text, txtTelefonePro.Text
                );
            professor.Inserir(professor);
            MessageBox.Show("Professor inserido com sucesso!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIdPro.Focus();
        }

        private void LimparCampos()
        {
            txtIdPro.Clear();
            txtNomePro.Clear();
            txtCpfPro.Clear();
            txtEmailPro.Clear();
            txtTelefonePro.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Id_pro = int.Parse(txtIdPro.Text);
            professor.Nome_pro = txtNomePro.Text;
            professor.Telefone_pro = txtTelefonePro.Text;
            professor.Alterar(professor);
            MessageBox.Show("Professor Alterado com sucesso!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (txtIdPro.ReadOnly == true)
            {
                txtIdPro.ReadOnly = false;
                button3.Text = "Buscar";

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
                        txtNomePro.Text = professor.Nome_pro;
                        txtCpfPro.Text = professor.Cpf_pro;
                        txtEmailPro.Text = professor.Email_pro;
                        txtTelefonePro.Text = professor.Telefone_pro;
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

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Professor professor = new Professor();
            foreach (var item in professor.ListarTodos())
            {
                listBox1.Items.Add(item.Id_pro + " - " + item.Nome_pro + " - " +
                    item.Email_pro + " - " + item.DataCadastro_pro);
            }
        }
    }
}
