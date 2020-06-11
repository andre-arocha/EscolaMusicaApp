using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscolarMusicApp;

namespace WindowsFormsApp1
{
    public partial class FrmRelacoes : Form
    {
        public FrmRelacoes()
        {
            InitializeComponent();
        }

        // Fechar pagina Relações
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // prreenche o Datagrid com os dados das matriuclas ativas ()
            dgvRelacoes.Rows.Clear();
            Matricula matricula = new Matricula();
            DataTable dt = new DataTable();
            var dr = matricula.ListarRelacoesAtivas();
            int i = 0;
            while (dr.Read())
            {
                dgvRelacoes.Rows.Add();
                dgvRelacoes.Rows[i].Cells[0].Value = dr.GetValue(0);
                dgvRelacoes.Rows[i].Cells[1].Value = dr.GetValue(1);
                dgvRelacoes.Rows[i].Cells[2].Value = dr.GetValue(2);
                dgvRelacoes.Rows[i].Cells[3].Value = dr.GetValue(3);
                dgvRelacoes.Rows[i].Cells[4].Value = dr.GetValue(4);
                dgvRelacoes.Rows[i].Cells[5].Value = dr.GetValue(5);
                dgvRelacoes.Rows[i].Cells[6].Value = dr.GetValue(6);
                dgvRelacoes.Rows[i].Cells[7].Value = dr.GetValue(7);
                dgvRelacoes.Rows[i].Cells[8].Value = dr.GetValue(8);
                i++;
            }
        }
    

        private void FrmRelacoes_Load(object sender, EventArgs e)
        {

        }
    }
}
