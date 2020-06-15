using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for (var x = 0; x <= richTextBox1.Text.Length - 1; x++)
            {
                //if (char.IsNumber(Convert.ToChar(richTextBox1.Text.Subtring(x, 1))))

                if (Char.IsNumber(richTextBox1.Text[x]))
                    contador += 1; //contador=contador+1
            }
            MessageBox.Show("Caracteres numéricos:" + contador);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0;

            //hoje tem chuva
            //4 - desenvolvedor 5 - usuário

            while(x<richTextBox1.Text.Length)
            {
                if(Char.IsWhiteSpace(richTextBox1.Text[x]))
                {
                    MessageBox.Show("Primeiro caracter branco :" + (x + 1));
                    break;
                }
                x += 1; // x=x+1;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (char c in richTextBox1.Text)
            {
                if (Char.IsLetter(c))
                    contador += 1;
            }

            MessageBox.Show("Caracteres Alfabéticos" + contador);

        }

    }
}
