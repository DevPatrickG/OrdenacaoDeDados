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
    public partial class BubbleSort : Form
    {
        
        int[] o = new int[80];
        

    public BubbleSort()
        {
            InitializeComponent();
        }


        private void btnCriarOrd_Click(object sender, EventArgs e)
        {
            //Habilitar o Botão da ordenação após o click
            btnOrdenaArray.Enabled = true;
            geraElementos(o);
            int x = 0; 
            lblArray.Text = "Dados na ordem original:\n";
            for(int i = 0; i < o.Length; i++)
            {
                
                if(x.Equals(10))
                {
                    lblArray.Text += "\n";
                    x = 0;
                }
                lblArray.Text += " " + o[i];
                x++;
            }

        }

        //MÉTODO PARA GERAR NÚMEROS ALEATÓRIOS
        public int[] geraElementos(int[] o)
        {            
            Random numAleatorio = new Random();
            int vlrInteiro;

            for (int i = 0; i < o.Length  ; i++)
            {
                //GERAR NÚMEROS DE 0 Até 999
                vlrInteiro = numAleatorio.Next(0, 999);
                o[i] += vlrInteiro;

            }
            return o;
        }

        private void btnOrdenaArray_Click(object sender, EventArgs e)
        {
            tecnicaBS(o);
            int x = 0;
            lblOrdenaArray.Text = "Dados Ordenados:\n";
            for(int i = 0; i < o.Length; i++)
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
        

        public void tecnicaBS(int[] x)
        {
            for (int i = 1; i < x.Length; i++)
                for (int j = 0; j < x.Length - 1; j++)
                    //SE O VALOR DO ELEMENTO FOR MAIOR QUE O VALOR DO PRÓXIMO ELEMENTO VAI PARA A VALIDAÇÃO
                    if (x[j] > x[j + 1])
                    {
                        int arrayAux;
                        //VARIAVEL arrayAux recebe o valor do elemento atual
                        arrayAux = x[j];
                        //o Elemento Atual recebe o valor do próximo elemento
                        x[j] = x[j + 1];
                        //o Próximo elemento recebe o valor da variável auxiliar
                        x[j + 1] = arrayAux;
                    }                   
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
