using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace P30481923044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[,] vetor = new double[4, 4];
            string valor = "";
    
            double resultadoMes = 0;
            double totalFinal = 0;


            for (int i = 0; i < vetor.GetLength(0); i++)
            {
                resultadoMes = 0;
                for (int x = 0; x < vetor.GetLength(1); x++)
                {
                    valor = Interaction.InputBox("Digite valor das vendas da semana: " + (x + 1)
                      , "Valores do mês " + (i + 1));
                    if (valor == "")
                        break;
                    if (!double.TryParse(valor, out vetor[i, x]))
                    {
                        MessageBox.Show("Digite um valor numerico");
                        x--;
                    }
                    resultadoMes = resultadoMes + vetor[i, x];
                    lstbxResultado.Items.Add("Total da semana "+ (x+1) + " R$:" + valor + " do mês: " + (i+1));
                    
                }
                totalFinal = totalFinal + resultadoMes;
                lstbxResultado.Items.Add("Total do mês: " +(i+1)+ " R$: " +resultadoMes);
            }
            lstbxResultado.Items.Add("Total Geral: R$" + totalFinal);

         
        }
    }
    
}
