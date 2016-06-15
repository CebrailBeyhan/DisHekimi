namespace DisHekimi
{
    partial class RandevuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbHastaAdi = new System.Windows.Forms.ComboBox();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.cbDoktor = new System.Windows.Forms.ComboBox();
            this.cbHastalik = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAna = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.rtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvRandevu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHastaAdi
            // 
            this.cbHastaAdi.FormattingEnabled = true;
            this.cbHastaAdi.Location = new System.Drawing.Point(222, 38);
            this.cbHastaAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHastaAdi.Name = "cbHastaAdi";
            this.cbHastaAdi.Size = new System.Drawing.Size(231, 23);
            this.cbHastaAdi.TabIndex = 24;
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(583, 40);
            this.txtSaat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(231, 22);
            this.txtSaat.TabIndex = 21;
            // 
            // dateTarih
            // 
            this.dateTarih.Location = new System.Drawing.Point(222, 131);
            this.dateTarih.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(231, 22);
            this.dateTarih.TabIndex = 20;
            // 
            // cbDoktor
            // 
            this.cbDoktor.FormattingEnabled = true;
            this.cbDoktor.Location = new System.Drawing.Point(222, 100);
            this.cbDoktor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDoktor.Name = "cbDoktor";
            this.cbDoktor.Size = new System.Drawing.Size(231, 23);
            this.cbDoktor.TabIndex = 19;
            // 
            // cbHastalik
            // 
            this.cbHastalik.FormattingEnabled = true;
            this.cbHastalik.Location = new System.Drawing.Point(222, 69);
            this.cbHastalik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHastalik.Name = "cbHastalik";
            this.cbHastalik.Size = new System.Drawing.Size(231, 23);
            this.cbHastalik.TabIndex = 18;
            this.cbHastalik.SelectedIndexChanged += new System.EventHandler(this.cbHastalik_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(516, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 19);
            this.label12.TabIndex = 17;
            this.label12.Text = "Saat  :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(133, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tarih  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(122, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Doktor  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(112, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Hastalık  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(104, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hasta Adı  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvRandevu);
            this.groupBox1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(87, 214);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(820, 291);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Bilgileri";
            // 
            // btnAna
            // 
            this.btnAna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAna.BackgroundImage")));
            this.btnAna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAna.FlatAppearance.BorderSize = 0;
            this.btnAna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAna.Location = new System.Drawing.Point(3, 510);
            this.btnAna.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(70, 70);
            this.btnAna.TabIndex = 92;
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(837, 98);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(70, 70);
            this.btnKaydet.TabIndex = 93;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rtxtAciklama
            // 
            this.rtxtAciklama.Location = new System.Drawing.Point(583, 69);
            this.rtxtAciklama.Name = "rtxtAciklama";
            this.rtxtAciklama.Size = new System.Drawing.Size(231, 84);
            this.rtxtAciklama.TabIndex = 94;
            this.rtxtAciklama.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(484, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 95;
            this.label1.Text = "Açıklama  :";
            // 
            // dtgvRandevu
            // 
            this.dtgvRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRandevu.Location = new System.Drawing.Point(24, 30);
            this.dtgvRandevu.Name = "dtgvRandevu";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgvRandevu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvRandevu.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgvRandevu.Size = new System.Drawing.Size(773, 246);
            this.dtgvRandevu.TabIndex = 0;
            // 
            // RandevuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1002, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtAciklama);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbHastaAdi);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.cbDoktor);
            this.Controls.Add(this.cbHastalik);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RandevuForm";
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.Randevu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRandevu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHastaAdi;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.DateTimePicker dateTarih;
        private System.Windows.Forms.ComboBox cbDoktor;
        private System.Windows.Forms.ComboBox cbHastalik;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAna;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RichTextBox rtxtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvRandevu;
    }
}