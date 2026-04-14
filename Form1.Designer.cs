namespace BCS_gyumolcs
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMagyar = new System.Windows.Forms.Button();
            this.btnOlcso = new System.Windows.Forms.Button();
            this.btnMennyiseg = new System.Windows.Forms.Button();
            this.btnLejart = new System.Windows.Forms.Button();
            this.btnBevetel = new System.Windows.Forms.Button();
            this.gomb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(910, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMagyar
            // 
            this.btnMagyar.Location = new System.Drawing.Point(31, 13);
            this.btnMagyar.Name = "btnMagyar";
            this.btnMagyar.Size = new System.Drawing.Size(93, 53);
            this.btnMagyar.TabIndex = 1;
            this.btnMagyar.Text = "Magyar";
            this.btnMagyar.UseVisualStyleBackColor = true;
            this.btnMagyar.Click += new System.EventHandler(this.btnMagyar_Click_1);
            // 
            // btnOlcso
            // 
            this.btnOlcso.Location = new System.Drawing.Point(149, 13);
            this.btnOlcso.Name = "btnOlcso";
            this.btnOlcso.Size = new System.Drawing.Size(109, 53);
            this.btnOlcso.TabIndex = 1;
            this.btnOlcso.Text = "Olcsó";
            this.btnOlcso.UseVisualStyleBackColor = true;
            this.btnOlcso.Click += new System.EventHandler(this.btnOlcso_Click_1);
            // 
            // btnMennyiseg
            // 
            this.btnMennyiseg.Location = new System.Drawing.Point(291, 13);
            this.btnMennyiseg.Name = "btnMennyiseg";
            this.btnMennyiseg.Size = new System.Drawing.Size(96, 53);
            this.btnMennyiseg.TabIndex = 1;
            this.btnMennyiseg.Text = "Mennyiség";
            this.btnMennyiseg.UseVisualStyleBackColor = true;
            this.btnMennyiseg.Click += new System.EventHandler(this.btnMennyiseg_Click_1);
            // 
            // btnLejart
            // 
            this.btnLejart.Location = new System.Drawing.Point(31, 83);
            this.btnLejart.Name = "btnLejart";
            this.btnLejart.Size = new System.Drawing.Size(93, 51);
            this.btnLejart.TabIndex = 1;
            this.btnLejart.Text = "Lejárt";
            this.btnLejart.UseVisualStyleBackColor = true;
            this.btnLejart.Click += new System.EventHandler(this.btnLejart_Click_1);
            // 
            // btnBevetel
            // 
            this.btnBevetel.Location = new System.Drawing.Point(149, 83);
            this.btnBevetel.Name = "btnBevetel";
            this.btnBevetel.Size = new System.Drawing.Size(109, 51);
            this.btnBevetel.TabIndex = 1;
            this.btnBevetel.Text = "Bevétel";
            this.btnBevetel.UseVisualStyleBackColor = true;
            this.btnBevetel.Click += new System.EventHandler(this.btnBevetel_Click_1);
            // 
            // gomb
            // 
            this.gomb.Location = new System.Drawing.Point(614, 99);
            this.gomb.Name = "gomb";
            this.gomb.Size = new System.Drawing.Size(290, 129);
            this.gomb.TabIndex = 2;
            this.gomb.Text = "button1";
            this.gomb.UseVisualStyleBackColor = true;
            this.gomb.Click += new System.EventHandler(this.gomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 504);
            this.Controls.Add(this.gomb);
            this.Controls.Add(this.btnBevetel);
            this.Controls.Add(this.btnLejart);
            this.Controls.Add(this.btnMennyiseg);
            this.Controls.Add(this.btnOlcso);
            this.Controls.Add(this.btnMagyar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMagyar;
        private System.Windows.Forms.Button btnOlcso;
        private System.Windows.Forms.Button btnMennyiseg;
        private System.Windows.Forms.Button btnLejart;
        private System.Windows.Forms.Button btnBevetel;
        private System.Windows.Forms.Button gomb;
    }
}

