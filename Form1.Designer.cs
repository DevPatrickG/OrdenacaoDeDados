
namespace ProjetoOrdenacaoDeDados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnComboSort = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(12, 249);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(127, 66);
            this.btnBubbleSort.TabIndex = 0;
            this.btnBubbleSort.Text = "Técnica Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Location = new System.Drawing.Point(473, 327);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(127, 66);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "SAIR";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(164, 249);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(149, 66);
            this.btnSelectionSort.TabIndex = 2;
            this.btnSelectionSort.Text = "Técnica Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnComboSort
            // 
            this.btnComboSort.Location = new System.Drawing.Point(340, 249);
            this.btnComboSort.Name = "btnComboSort";
            this.btnComboSort.Size = new System.Drawing.Size(127, 66);
            this.btnComboSort.TabIndex = 3;
            this.btnComboSort.Text = "Técnica Comb Sort";
            this.btnComboSort.UseVisualStyleBackColor = true;
            this.btnComboSort.Click += new System.EventHandler(this.btnComboSort_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoOrdenacaoDeDados.Properties.Resources.baixados;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 173);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "MONITORAMENTO DA FLORESTA AMAZÔNICA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnComboSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnBubbleSort);
            this.Name = "Form1";
            this.Text = "MENU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnComboSort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

