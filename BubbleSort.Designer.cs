
namespace ProjetoOrdenacaoDeDados
{
    partial class BubbleSort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriarOrd = new System.Windows.Forms.Button();
            this.lblArray = new System.Windows.Forms.Label();
            this.btnOrdenaArray = new System.Windows.Forms.Button();
            this.lblOrdenaArray = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarOrd
            // 
            this.btnCriarOrd.Location = new System.Drawing.Point(51, 62);
            this.btnCriarOrd.Name = "btnCriarOrd";
            this.btnCriarOrd.Size = new System.Drawing.Size(149, 92);
            this.btnCriarOrd.TabIndex = 0;
            this.btnCriarOrd.Text = "Original Array";
            this.btnCriarOrd.UseVisualStyleBackColor = true;
            this.btnCriarOrd.Click += new System.EventHandler(this.btnCriarOrd_Click);
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(312, 62);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(0, 15);
            this.lblArray.TabIndex = 1;
            // 
            // btnOrdenaArray
            // 
            this.btnOrdenaArray.Enabled = false;
            this.btnOrdenaArray.Location = new System.Drawing.Point(51, 205);
            this.btnOrdenaArray.Name = "btnOrdenaArray";
            this.btnOrdenaArray.Size = new System.Drawing.Size(149, 92);
            this.btnOrdenaArray.TabIndex = 3;
            this.btnOrdenaArray.Text = "Ordena Array";
            this.btnOrdenaArray.UseVisualStyleBackColor = true;
            this.btnOrdenaArray.Click += new System.EventHandler(this.btnOrdenaArray_Click);
            // 
            // lblOrdenaArray
            // 
            this.lblOrdenaArray.AutoSize = true;
            this.lblOrdenaArray.Location = new System.Drawing.Point(312, 205);
            this.lblOrdenaArray.Name = "lblOrdenaArray";
            this.lblOrdenaArray.Size = new System.Drawing.Size(0, 15);
            this.lblOrdenaArray.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Location = new System.Drawing.Point(661, 350);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(127, 66);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "SAIR";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVoltar.Location = new System.Drawing.Point(12, 350);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(127, 66);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // BubbleSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblOrdenaArray);
            this.Controls.Add(this.btnOrdenaArray);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.btnCriarOrd);
            this.Name = "BubbleSort";
            this.Text = "BubbleSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarOrd;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Button btnOrdenaArray;
        private System.Windows.Forms.Label lblOrdenaArray;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVoltar;
    }
}