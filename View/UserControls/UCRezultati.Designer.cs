﻿
namespace View.UserControls
{
    partial class UCRezultati
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgRezultati = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRezultati)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRezultati
            // 
            this.dgRezultati.AllowUserToAddRows = false;
            this.dgRezultati.AllowUserToDeleteRows = false;
            this.dgRezultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRezultati.Location = new System.Drawing.Point(15, 84);
            this.dgRezultati.Name = "dgRezultati";
            this.dgRezultati.ReadOnly = true;
            this.dgRezultati.RowHeadersWidth = 62;
            this.dgRezultati.RowTemplate.Height = 28;
            this.dgRezultati.Size = new System.Drawing.Size(653, 550);
            this.dgRezultati.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezultati";
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(674, 84);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(196, 57);
            this.btnDetalji.TabIndex = 2;
            this.btnDetalji.Text = "Detalji o utakmici";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(674, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UCRezultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRezultati);
            this.Name = "UCRezultati";
            this.Size = new System.Drawing.Size(1108, 717);
            this.Load += new System.EventHandler(this.UCRezultati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRezultati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRezultati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button button2;
    }
}
