namespace DisHekimi
{
    partial class CalisanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvCalisan = new System.Windows.Forms.DataGridView();
            this.btnAna = new System.Windows.Forms.Button();
            this.btnCalisanKaydet = new System.Windows.Forms.Button();
            this.rtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.cbIzinGunu = new System.Windows.Forms.ComboBox();
            this.cbCalismaSaatler = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.txtCalisanAdi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCalisan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvCalisan);
            this.groupBox1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(95, 211);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(678, 307);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışan Listesi";
            // 
            // dtgvCalisan
            // 
            this.dtgvCalisan.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dtgvCalisan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCalisan.Location = new System.Drawing.Point(32, 26);
            this.dtgvCalisan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvCalisan.Name = "dtgvCalisan";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtgvCalisan.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCalisan.Size = new System.Drawing.Size(617, 261);
            this.dtgvCalisan.TabIndex = 56;
            // 
            // btnAna
            // 
            this.btnAna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAna.BackgroundImage")));
            this.btnAna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAna.FlatAppearance.BorderSize = 0;
            this.btnAna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAna.Location = new System.Drawing.Point(0, 557);
            this.btnAna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(60, 60);
            this.btnAna.TabIndex = 91;
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // btnCalisanKaydet
            // 
            this.btnCalisanKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalisanKaydet.BackgroundImage")));
            this.btnCalisanKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalisanKaydet.FlatAppearance.BorderSize = 0;
            this.btnCalisanKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanKaydet.Location = new System.Drawing.Point(725, 113);
            this.btnCalisanKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalisanKaydet.Name = "btnCalisanKaydet";
            this.btnCalisanKaydet.Size = new System.Drawing.Size(60, 60);
            this.btnCalisanKaydet.TabIndex = 90;
            this.btnCalisanKaydet.UseVisualStyleBackColor = true;
            this.btnCalisanKaydet.Click += new System.EventHandler(this.btnCalisanKaydet_Click);
            // 
            // rtxtAciklama
            // 
            this.rtxtAciklama.Location = new System.Drawing.Point(514, 63);
            this.rtxtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtAciklama.Name = "rtxtAciklama";
            this.rtxtAciklama.Size = new System.Drawing.Size(203, 110);
            this.rtxtAciklama.TabIndex = 89;
            this.rtxtAciklama.Text = "";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(514, 25);
            this.txtUcret.Margin = new System.Windows.Forms.Padding(4);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(203, 23);
            this.txtUcret.TabIndex = 88;
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
            this.cbIzinGunu.Location = new System.Drawing.Point(184, 142);
            this.cbIzinGunu.Margin = new System.Windows.Forms.Padding(4);
            this.cbIzinGunu.Name = "cbIzinGunu";
            this.cbIzinGunu.Size = new System.Drawing.Size(203, 23);
            this.cbIzinGunu.TabIndex = 87;
            // 
            // cbCalismaSaatler
            // 
            this.cbCalismaSaatler.FormattingEnabled = true;
            this.cbCalismaSaatler.Items.AddRange(new object[] {
            "10:00 - 18:00",
            "12:00 - 20:00",
            "14:00 - 22:00"});
            this.cbCalismaSaatler.Location = new System.Drawing.Point(184, 103);
            this.cbCalismaSaatler.Margin = new System.Windows.Forms.Padding(4);
            this.cbCalismaSaatler.Name = "cbCalismaSaatler";
            this.cbCalismaSaatler.Size = new System.Drawing.Size(203, 23);
            this.cbCalismaSaatler.TabIndex = 85;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(415, 65);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 19);
            this.label18.TabIndex = 84;
            this.label18.Text = "AÇIKLAMA  :";
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(184, 65);
            this.txtGorev.Margin = new System.Windows.Forms.Padding(4);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(203, 23);
            this.txtGorev.TabIndex = 83;
            // 
            // txtCalisanAdi
            // 
            this.txtCalisanAdi.Location = new System.Drawing.Point(184, 25);
            this.txtCalisanAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalisanAdi.Name = "txtCalisanAdi";
            this.txtCalisanAdi.Size = new System.Drawing.Size(203, 23);
            this.txtCalisanAdi.TabIndex = 82;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(439, 25);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 19);
            this.label17.TabIndex = 81;
            this.label17.Text = "ÜCRET  :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(73, 142);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 19);
            this.label15.TabIndex = 80;
            this.label15.Text = "İZİN GÜNÜ  :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(12, 103);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 19);
            this.label16.TabIndex = 79;
            this.label16.Text = "ÇALIŞMA SAATLERİ  :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(92, 65);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 19);
            this.label14.TabIndex = 78;
            this.label14.Text = "GÖREVİ  :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(66, 25);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 19);
            this.label13.TabIndex = 77;
            this.label13.Text = "ADI SOYADI  :";
            // 
            // CalisanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(852, 618);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.btnCalisanKaydet);
            this.Controls.Add(this.rtxtAciklama);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.cbIzinGunu);
            this.Controls.Add(this.cbCalismaSaatler);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.txtCalisanAdi);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalisanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calisan";
            this.Load += new System.EventHandler(this.CalisanForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCalisan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvCalisan;
        private System.Windows.Forms.Button btnAna;
        private System.Windows.Forms.Button btnCalisanKaydet;
        private System.Windows.Forms.RichTextBox rtxtAciklama;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.ComboBox cbIzinGunu;
        private System.Windows.Forms.ComboBox cbCalismaSaatler;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.TextBox txtCalisanAdi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;

    }
}