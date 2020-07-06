using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PALUNO
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=DESKTOP-E2G6BCA\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros =/ +" + ex.Message);
            }
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        { 
              frmCidade frmCid = new frmCidade();
              frmCid.MdiParent = this;
              frmCid.WindowState = FormWindowState.Maximized;
              frmCid.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluno frmAlu = new frmAluno();
            frmAlu.MdiParent = this;
            frmAlu.WindowState = FormWindowState.Maximized;
            frmAlu.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre frmsobre = new sobre();
            frmsobre.MdiParent = this;
            frmsobre.WindowState = FormWindowState.Maximized;
            frmsobre.Show();
        }
    }
}
