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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar uma instancia de Form1 (FormAluno)
            FrmAluno frmAluno = new FrmAluno();
            frmAluno.MdiParent = this;
            frmAluno.Show();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfessor frmProfessor = new FrmProfessor();
            frmProfessor.MdiParent = this;
            frmProfessor.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmUsuario frmLogin = new FrmUsuario();
            frmLogin.ShowDialog();
            if (Program.usuarioLogado != null)
            {
                Text = "FrmPrincipal - " + Program.usuarioLogado.Nome_usuario;
            }

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCurso frmCurso = new FrmCurso ();
            frmCurso.MdiParent = this;
            frmCurso.Show();
        }

        private void matriculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatricula frmMatricula = new FrmMatricula();
            frmMatricula.MdiParent = this;
            frmMatricula.Show();
        }
    }
}
