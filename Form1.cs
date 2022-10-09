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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            SelectionSort selectionSort = new SelectionSort();
            selectionSort.ShowDialog();
        }

        private void btnComboSort_Click(object sender, EventArgs e)
        {
            CombSort combSort = new CombSort();
            combSort.ShowDialog();
        }
    }
}
