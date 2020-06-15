using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            int numero = objRandom.Next(Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text));

            MessageBox.Show("O numero sorteado é :" + numero);


        }
    }
}
