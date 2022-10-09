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
    public partial class SelectionSort : Form
    {
        public SelectionSort()
        {
            InitializeComponent();
        }

        int[] unsortedList = new int[80];

        public void btnArrayOriginal_Click(object sender, EventArgs e)
        {
            //Habilita o botão de ordenação após o click
            btnOrdenaArray.Enabled = true;
            geraElementos(unsortedList);
            int x = 0;
            lblArrayOriginal.Text = "Dados na ordem original:\n";
            for (int i = 0; i < unsortedList.Length; i++)
            {

                if (x.Equals(10))
                {
                    lblArrayOriginal.Text += "\n";
                    x = 0;
                }
                lblArrayOriginal.Text += " " + unsortedList[i];
                x++;
            }
        }
        public void btnOrdenaArray_Click(object sender, EventArgs e)
        {
            Selection_Sort(unsortedList);
        }
        //MÉTODO PARA GERAR NÚMEROS ALEATÓRIOS
        public int[] geraElementos(int[] unsortedList)
        {
            Random numAleatorio = new Random();
            int vlrInteiro;

            for (int i = 0; i < unsortedList.Length; i++)
            {
                //GERAR NÚMEROS DE 0 Até 999
                vlrInteiro = numAleatorio.Next(0, 999);
                unsortedList[i] += vlrInteiro;

            }
            return unsortedList;
        }

        public void Selection_Sort(int[] unsortedList)
        {
            int minIndex = 0;
            int MinimumValueFound = 0;


            for (int MainIndex = 0; MainIndex < unsortedList.Length; MainIndex++)
            {
                minIndex = MainIndex;

                for (int RemainingIndex = MainIndex + 1; RemainingIndex < unsortedList.Length; RemainingIndex++)
                {
                    //SE O SEGUNDO ELEMENTO FOR MENOR QUE O PRIMEIRO ELEMENTO
                    if (unsortedList[RemainingIndex] < unsortedList[minIndex])
                    {
                        minIndex = RemainingIndex;
                    }
                }

                //A Variavel MinimumValueFound recebe o menor valor dos elementos
                MinimumValueFound = unsortedList[minIndex];
                //Recebe o maior valor dos elementos
                unsortedList[minIndex] = unsortedList[MainIndex];
                //o Elemento prosseguido recebe menor valor entre os elementos
                unsortedList[MainIndex] = MinimumValueFound;

           
            }
            int x = 0;
            lblArrayOrdenado.Text = "Dados Ordenados:\n";
            
          for (int i = 0; i < unsortedList.Length; i++)
          {
              if (x.Equals(10))
              {
                  lblArrayOrdenado.Text += "\n";
                  x = 0;
              }
              lblArrayOrdenado.Text += " " + unsortedList[i];
              x++;
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

