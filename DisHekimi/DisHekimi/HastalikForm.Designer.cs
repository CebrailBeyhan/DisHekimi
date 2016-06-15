namespace DisHekimi
{
    partial class HastalikForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastalikForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvHastalik = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiyati = new System.Windows.Forms.TextBox();
            this.txtHastalik_adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAna = new System.Windows.Forms.Button();
            this.btnHastalikKaydet = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHastalik)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvHastalik);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(98, 194);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(446, 280);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hastalık Listesi";
            // 
            // dtgvHastalik
            // 
            this.dtgvHastalik.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.dtgvHastalik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHastalik.Location = new System.Drawing.Point(23, 24);
            this.dtgvHastalik.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvHastalik.Name = "dtgvHastalik";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.ForestGreen;
            this.dtgvHastalik.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHastalik.Size = new System.Drawing.Size(401, 235);
            this.dtgvHastalik.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "FİYATI  :";
            // 
            // txtFiyati
            // 
            this.txtFiyati.ForeColor = System.Drawing.Color.DarkRed;
            this.txtFiyati.Location = new System.Drawing.Point(164, 92);
            this.txtFiyati.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.Size = new System.Drawing.Size(329, 23);
            this.txtFiyati.TabIndex = 66;
            // 
            // txtHastalik_adi
            // 
            this.txtHastalik_adi.ForeColor = System.Drawing.Color.DarkRed;
            this.txtHastalik_adi.Location = new System.Drawing.Point(164, 53);
            this.txtHastalik_adi.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastalik_adi.Name = "txtHastalik_adi";
            this.txtHastalik_adi.Size = new System.Drawing.Size(329, 23);
            this.txtHastalik_adi.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "AÇIKLAMA  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "HASTALIK ADI  :";
            // 
            // btnAna
            // 
            this.btnAna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAna.BackgroundImage")));
            this.btnAna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAna.FlatAppearance.BorderSize = 0;
            this.btnAna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAna.Location = new System.Drawing.Point(3, 485);
            this.btnAna.Margin = new System.Windows.Forms.Padding(4);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(71, 63);
            this.btnAna.TabIndex = 73;
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHastalikKaydet
            // 
            this.btnHastalikKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastalikKaydet.BackgroundImage")));
            this.btnHastalikKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastalikKaydet.FlatAppearance.BorderSize = 0;
            this.btnHastalikKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastalikKaydet.Location = new System.Drawing.Point(501, 89);
            this.btnHastalikKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnHastalikKaydet.Name = "btnHastalikKaydet";
            this.btnHastalikKaydet.Size = new System.Drawing.Size(63, 64);
            this.btnHastalikKaydet.TabIndex = 74;
            this.btnHastalikKaydet.UseVisualStyleBackColor = true;
            this.btnHastalikKaydet.Click += new System.EventHandler(this.btnHastalikKaydet_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.ForeColor = System.Drawing.Color.DarkRed;
            this.txtAciklama.Location = new System.Drawing.Point(164, 129);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(329, 23);
            this.txtAciklama.TabIndex = 75;
            // 
            // HastalikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(688, 550);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnHastalikKaydet);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiyati);
            this.Controls.Add(this.txtHastalik_adi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HastalikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastalık";
            this.Load += new System.EventHandler(this.HastalikForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHastalik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvHastalik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiyati;
        private System.Windows.Forms.TextBox txtHastalik_adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAna;
        private System.Windows.Forms.Button btnHastalikKaydet;
        private System.Windows.Forms.TextBox txtAciklama;
    }
}