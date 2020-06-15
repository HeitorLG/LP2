using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMetodos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            // r      ss            r
            //arara  assessoria   sorocaba
            int posicao;
            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while (posicao >=0 )
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                    txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                    txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            }

        }

        private void frmExercicio3_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            // este botão faz o mesmo do botão acima, mas usando o método Replace
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray(); //Joga a string para um array
            Array.Reverse(arr); // Invertando o array
            s = "";
            foreach (char c in arr)
                s = s + c.ToString();
            MessageBox.Show(s);

            //Ou

            string ss = txtPalavra1.Text;
            char[] arr1 = ss.ToCharArray();
            Array.Reverse(arr1);
            ss = new string(arr);
            MessageBox.Show(ss);

        }
    }
}
