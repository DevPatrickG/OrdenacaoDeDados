
namespace ProjetoOrdenacaoDeDados
{
    partial class SelectionSort
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
            this.btnOrdenaArray = new System.Windows.Forms.Button();
            this.btnArrayOriginal = new System.Windows.Forms.Button();
            this.lblArrayOriginal = new System.Windows.Forms.Label();
            this.lblArrayOrdenado = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrdenaArray
            // 
            this.btnOrdenaArray.Enabled = false;
            this.btnOrdenaArray.Location = new System.Drawing.Point(50, 226);
            this.btnOrdenaArray.Name = "btnOrdenaArray";
            this.btnOrdenaArray.Size = new System.Drawing.Size(149, 92);
            this.btnOrdenaArray.TabIndex = 4;
            this.btnOrdenaArray.Text = "Ordena Array";
            this.btnOrdenaArray.UseVisualStyleBackColor = true;
            this.btnOrdenaArray.Click += new System.EventHandler(this.btnOrdenaArray_Click);
            // 
            // btnArrayOriginal
            // 
            this.btnArrayOriginal.Location = new System.Drawing.Point(50, 69);
            this.btnArrayOriginal.Name = "btnArrayOriginal";
            this.btnArrayOriginal.Size = new System.Drawing.Size(149, 92);
            this.btnArrayOriginal.TabIndex = 5;
            this.btnArrayOriginal.Text = "Original Array";
            this.btnArrayOriginal.UseVisualStyleBackColor = true;
            this.btnArrayOriginal.Click += new System.EventHandler(this.btnArrayOriginal_Click);
            // 
            // lblArrayOriginal
            // 
            this.lblArrayOriginal.AutoSize = true;
            this.lblArrayOriginal.Location = new System.Drawing.Point(295, 69);
            this.lblArrayOriginal.Name = "lblArrayOriginal";
            this.lblArrayOriginal.Size = new System.Drawing.Size(0, 15);
            this.lblArrayOriginal.TabIndex = 6;
            // 
            // lblArrayOrdenado
            // 
            this.lblArrayOrdenado.AutoSize = true;
            this.lblArrayOrdenado.Location = new System.Drawing.Point(295, 226);
            this.lblArrayOrdenado.Name = "lblArrayOrdenado";
            this.lblArrayOrdenado.Size = new System.Drawing.Size(0, 15);
            this.lblArrayOrdenado.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVoltar.Location = new System.Drawing.Point(12, 356);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(127, 66);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Location = new System.Drawing.Point(661, 372);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(127, 66);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "SAIR";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // SelectionSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblArrayOrdenado);
            this.Controls.Add(this.lblArrayOriginal);
            this.Controls.Add(this.btnArrayOriginal);
            this.Controls.Add(this.btnOrdenaArray);
            this.Name = "SelectionSort";
            this.Text = "SelectionSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenaArray;
        private System.Windows.Forms.Button btnArrayOriginal;
        private System.Windows.Forms.Label lblArrayOriginal;
        private System.Windows.Forms.Label lblArrayOrdenado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSair;
    }
}