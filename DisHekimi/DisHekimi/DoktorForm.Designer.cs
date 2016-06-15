namespace DisHekimi
{
    partial class DoktorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorForm));
            this.label18 = new System.Windows.Forms.Label();
            this.txtDoktor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDoktorlar = new System.Windows.Forms.DataGridView();
            this.cbCalismaSaatler = new System.Windows.Forms.ComboBox();
            this.cbIzinGunu = new System.Windows.Forms.ComboBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.rtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.btnCalisanKaydet = new System.Windows.Forms.Button();
            this.btnAna = new System.Windows.Forms.Button();
            this.cbHastalik = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoktorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(387, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 16);
            this.label18.TabIndex = 48;
            this.label18.Text = "AÇIKLAMA  :";
            // 
            // txtDoktor
            // 
            this.txtDoktor.Location = new System.Drawing.Point(198, 27);
            this.txtDoktor.Name = "txtDoktor";
            this.txtDoktor.Size = new System.Drawing.Size(174, 23);
            this.txtDoktor.TabIndex = 43;
            this.txtDoktor.TextChanged += new System.EventHandler(this.txtDoktor_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(411, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 16);
            this.label17.TabIndex = 42;
            this.label17.Text = "ÜCRET  :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(96, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "İZİN GÜNÜ  :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "ÇALIŞMA SAATLERİ  :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(120, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "BÖLÜM  :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "DOKTOR  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDoktorlar);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(28, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 247);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Listesi";
            // 
            // dtgvDoktorlar
            // 
            this.dtgvDoktorlar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dtgvDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoktorlar.Location = new System.Drawing.Point(17, 22);
            this.dtgvDoktorlar.Name = "dtgvDoktorlar";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            this.dtgvDoktorlar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDoktorlar.Size = new System.Drawing.Size(659, 211);
            this.dtgvDoktorlar.TabIndex = 56;
            // 
            // cbCalismaSaatler
            // 
            this.cbCalismaSaatler.FormattingEnabled = true;
            this.cbCalismaSaatler.Items.AddRange(new object[] {
            "10:00 - 18:00",
            "12:00 - 20:00",
            "14:00 - 22:00"});
            this.cbCalismaSaatler.Location = new System.Drawing.Point(198, 108);
            this.cbCalismaSaatler.Name = "cbCalismaSaatler";
            this.cbCalismaSaatler.Size = new System.Drawing.Size(174, 23);
            this.cbCalismaSaatler.TabIndex = 57;
            // 
            // cbIzinGunu
            // 
            this.cbIzinGunu.FormattingEnabled = true;
            this.cbIzinGunu.Items.AddRange(new object[] {
            "PAZARTESİ",
            "SALI",
            "ÇARŞAMBA",
            "PERŞEMBE",
            "CUMA",
            "CUMARTESİ",
            "PAZAR"});
            this.cbIzinGunu.Location = new System.Drawing.Point(198, 144);
            this.cbIzinGunu.Name = "cbIzinGunu";
            this.cbIzinGunu.Size = new System.Drawing.Size(174, 23);
            this.cbIzinGunu.TabIndex = 64;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(481, 29);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(174, 23);
            this.txtUcret.TabIndex = 65;
            // 
            // rtxtAciklama
            // 
            this.rtxtAciklama.Location = new System.Drawing.Point(481, 67);
            this.rtxtAciklama.Name = "rtxtAciklama";
            this.rtxtAciklama.Size = new System.Drawing.Size(174, 96);
            this.rtxtAciklama.TabIndex = 66;
            this.rtxtAciklama.Text = "";
            // 
            // btnCalisanKaydet
            // 
            this.btnCalisanKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalisanKaydet.BackgroundImage")));
            this.btnCalisanKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalisanKaydet.FlatAppearance.BorderSize = 0;
            this.btnCalisanKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanKaydet.Location = new System.Drawing.Point(662, 99);
            this.btnCalisanKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalisanKaydet.Name = "btnCalisanKaydet";
            this.btnCalisanKaydet.Size = new System.Drawing.Size(63, 64);
            this.btnCalisanKaydet.TabIndex = 75;
            this.btnCalisanKaydet.UseVisualStyleBackColor = true;
            this.btnCalisanKaydet.Click += new System.EventHandler(this.btnCalisanKaydet_Click);
            // 
            // btnAna
            // 
            this.btnAna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAna.BackgroundImage")));
            this.btnAna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAna.FlatAppearance.BorderSize = 0;
            this.btnAna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAna.Location = new System.Drawing.Point(1, 460);
            this.btnAna.Margin = new System.Windows.Forms.Padding(4);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(60, 60);
            this.btnAna.TabIndex = 76;
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // cbHastalik
            // 
            this.cbHastalik.FormattingEnabled = true;
            this.cbHastalik.Location = new System.Drawing.Point(198, 67);
            this.cbHastalik.Name = "cbHastalik";
            this.cbHastalik.Size = new System.Drawing.Size(174, 23);
            this.cbHastalik.TabIndex = 77;
            // 
            // DoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(783, 520);
            this.Controls.Add(this.cbHastalik);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.btnCalisanKaydet);
            this.Controls.Add(this.rtxtAciklama);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.cbIzinGunu);
            this.Controls.Add(this.cbCalismaSaatler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtDoktor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoktorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktorlar";
            this.Load += new System.EventHandler(this.Doktorlar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoktorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDoktor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDoktorlar;
        private System.Windows.Forms.ComboBox cbCalismaSaatler;
        private System.Windows.Forms.ComboBox cbIzinGunu;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.RichTextBox rtxtAciklama;
        private System.Windows.Forms.Button btnCalisanKaydet;
        private System.Windows.Forms.Button btnAna;
        private System.Windows.Forms.ComboBox cbHastalik;
    }
}