namespace DisHekimi
{
    partial class HastaBilgileriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaBilgileriForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbHastaAdi = new System.Windows.Forms.ComboBox();
            this.btnAna = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRontgen = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.lblRahatsiz = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblHastaAdi = new System.Windows.Forms.Label();
            this.btnCalisanKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Adı :";
            // 
            // cbHastaAdi
            // 
            this.cbHastaAdi.FormattingEnabled = true;
            this.cbHastaAdi.Location = new System.Drawing.Point(215, 56);
            this.cbHastaAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHastaAdi.Name = "cbHastaAdi";
            this.cbHastaAdi.Size = new System.Drawing.Size(213, 27);
            this.cbHastaAdi.TabIndex = 2;
            this.cbHastaAdi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAna
            // 
            this.btnAna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAna.BackgroundImage")));
            this.btnAna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAna.FlatAppearance.BorderSize = 0;
            this.btnAna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAna.Location = new System.Drawing.Point(1, 524);
            this.btnAna.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(60, 60);
            this.btnAna.TabIndex = 92;
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblRontgen);
            this.groupBox1.Controls.Add(this.lblAciklama);
            this.groupBox1.Controls.Add(this.lblUcret);
            this.groupBox1.Controls.Add(this.lblRahatsiz);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.lblCinsiyet);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblHastaAdi);
            this.groupBox1.Location = new System.Drawing.Point(92, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 348);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(24, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 37;
            this.label9.Text = "Röntgen :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(15, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Açıklama :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(41, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ücret :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Hastalığı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(40, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Adres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cinsiyet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Hasta Adı :";
            // 
            // lblRontgen
            // 
            this.lblRontgen.AutoSize = true;
            this.lblRontgen.Location = new System.Drawing.Point(94, 276);
            this.lblRontgen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRontgen.Name = "lblRontgen";
            this.lblRontgen.Size = new System.Drawing.Size(113, 19);
            this.lblRontgen.TabIndex = 29;
            this.lblRontgen.Text = "RÖNTGEN FİLMİ";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(94, 245);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(80, 19);
            this.lblAciklama.TabIndex = 28;
            this.lblAciklama.Text = "AÇIKLAMA";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(94, 212);
            this.lblUcret.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(152, 19);
            this.lblUcret.TabIndex = 27;
            this.lblUcret.Text = "HASTALIK ÜCRETLERİ";
            // 
            // lblRahatsiz
            // 
            this.lblRahatsiz.AutoSize = true;
            this.lblRahatsiz.Location = new System.Drawing.Point(94, 177);
            this.lblRahatsiz.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRahatsiz.Name = "lblRahatsiz";
            this.lblRahatsiz.Size = new System.Drawing.Size(101, 19);
            this.lblRahatsiz.TabIndex = 26;
            this.lblRahatsiz.Text = "RAHATSIZLIĞI";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdres.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(95, 145);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(26, 18);
            this.lblAdres.TabIndex = 25;
            this.lblAdres.Text = "---";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(95, 113);
            this.lblCinsiyet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(26, 18);
            this.lblCinsiyet.TabIndex = 24;
            this.lblCinsiyet.Text = "---";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(95, 82);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(26, 18);
            this.lblTelefon.TabIndex = 23;
            this.lblTelefon.Text = "---";
            // 
            // lblHastaAdi
            // 
            this.lblHastaAdi.AutoSize = true;
            this.lblHastaAdi.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaAdi.Location = new System.Drawing.Point(95, 52);
            this.lblHastaAdi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHastaAdi.Name = "lblHastaAdi";
            this.lblHastaAdi.Size = new System.Drawing.Size(26, 18);
            this.lblHastaAdi.TabIndex = 22;
            this.lblHastaAdi.Text = "---";
            // 
            // btnCalisanKaydet
            // 
            this.btnCalisanKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalisanKaydet.BackgroundImage")));
            this.btnCalisanKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalisanKaydet.FlatAppearance.BorderSize = 0;
            this.btnCalisanKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanKaydet.Location = new System.Drawing.Point(452, 37);
            this.btnCalisanKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalisanKaydet.Name = "btnCalisanKaydet";
            this.btnCalisanKaydet.Size = new System.Drawing.Size(63, 64);
            this.btnCalisanKaydet.TabIndex = 76;
            this.btnCalisanKaydet.UseVisualStyleBackColor = true;
            this.btnCalisanKaydet.Click += new System.EventHandler(this.btnCalisanKaydet_Click);
            // 
            // HastaBilgileriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(674, 583);
            this.Controls.Add(this.btnCalisanKaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.cbHastaAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HastaBilgileriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaBilgileri";
            this.Load += new System.EventHandler(this.HastaBilgileriForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHastaAdi;
        private System.Windows.Forms.Button btnAna;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRontgen;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblRahatsiz;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblHastaAdi;
        private System.Windows.Forms.Button btnCalisanKaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}