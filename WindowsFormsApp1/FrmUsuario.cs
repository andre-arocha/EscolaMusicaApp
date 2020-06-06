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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtEmailUsu.Text, txtSenhaUsu.Text);
            if (usuario.EfetuarLogin(usuario))
            {
                this.Close();
                Program.usuarioLogado = usuario;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!");
            }
        }
    }
}
