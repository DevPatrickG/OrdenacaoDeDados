using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrdenacaoDeDados
{
    public partial class CombSort : Form
    {
        int[] o = new int[80];
        public CombSort()
        {
            InitializeComponent();
        }
    
        private void btnOrdenaArray_Click(object sender, EventArgs e)
        {
            Comb_Sort(ref o);
            
       
            int x = 0;
            lblOrdenaArray.Text = "Dados Ordenados:\n";
            for (int i = 0; i < o.Length; i++)
            {
                if (x.Equals(10))
                {
                    lblOrdenaArray.Text += "\n";
                    x = 0;
                }
                lblOrdenaArray.Text += " " + o[i];
                x++;
            }
        }
     
        private void btnCriarOrd_Click(object sender, EventArgs e)
        {
            //Habilita o botão de ordenação após o click
            btnOrdenaArray.Enabled = true;
            geraElementos(o);
            int x = 0;
            lblArray.Text = "Dados na ordem original:\n";
            for (int i = 0; i < o.Length; i++)
            {

                if (x.Equals(10))
                {
                    lblArray.Text += "\n";
                    x = 0;
                }
                lblArray.Text += " " + o[i];
                x++;
            }

        }
        public int[] geraElementos(int[] o)
        {
            Random numAleatorio = new Random();
            int vlrInteiro;

            for (int i = 0; i < o.Length; i++)
            {
                //GERAR NÚMEROS DE 0 Até 999
                vlrInteiro = numAleatorio.Next(0, 999);
                o[i] += vlrInteiro;

            }
            return o;
        }
        public static void Comb_Sort(ref int[] o)
        {
            //Lacunas recebe o valor do tamanho do array
            double lacunas = o.Length;
            bool permutas = true;

            while (lacunas > 1 || permutas)
            {
                // lacunas recebe seu operador e dividindo pelo valor da folga.
                lacunas /= 1.247330950103979; // O Valor 1.247330950103979 é o padrão para o a foruma de calculo do Comb Sort.

                if (lacunas < 1)
                    lacunas = 1;

                int i = 0;
                permutas = false;

                //O Repetir só parará até ordenar a estrutura
                while (i + lacunas < o.Length)
                {
                    //Sob_lacunas recebe o valor do contador mais a concatenação da divisão de lacunas
                    int sob_lacunas = i + (int)lacunas;

                    /*Se o valor da posição for maior que o Sub valor acoplado, então a variavel temporaria recebe o valor da posição atual.
                    e o Sub valor acoplado recebe o valor da vaiavel temporaria*/
                    if (o[i] > o[sob_lacunas])
                    {
                        int temp = o[i];
                        o[i] = o[sob_lacunas];
                        o[sob_lacunas] = temp;
                        permutas = true;
                    }

                    ++i;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
