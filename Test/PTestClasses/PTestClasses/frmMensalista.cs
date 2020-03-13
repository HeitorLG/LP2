using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTestClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
 
            {
                InitializeComponent();
            }
       

       

        private void button1_Click(object sender, EventArgs e)
        {
            Mensalista mensalista = new Mensalista();

            mensalista.NomeEmpregado = txtNome.Text;
            mensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            mensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            mensalista.SalarioMensal = Convert.ToDouble(txtSalarioMensal.Text);


            MessageBox.Show("Nome" + mensalista.NomeEmpregado + "\n" +
                             "Matricula=" + mensalista.Matricula + "\n" +
                             "Tempo Trabalho" + mensalista.TempoTrabalho().ToString() + "\n" +
                             "Salario Final=" + mensalista.SalarioBruto().ToString("N2"));

        }

        private void btnInstaciarMensalistaParametros_Click(object sender, EventArgs e)
        {
            Mensalista mensalista = new Mensalista( Convert.ToInt32(txtMatricula.Text),
                txtNome.Text,
                Convert.ToDateTime(txtDataEntrada.Text),
                Convert.ToDouble(txtSalarioMensal.Text));

            MessageBox.Show("Nome = " + mensalista.NomeEmpregado + "\n" +  
                             "Matricula = "  +  mensalista.Matricula + "\n" + 
                             "Salario = " +     mensalista.SalarioBruto().ToString("N2") + "\n" +
                                                    
                             "Tempo de Trabalho = " + mensalista.TempoTrabalho().ToString());
        }

    }
}
