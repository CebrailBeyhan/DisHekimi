namespace DisHekimi
{
    partial class HastaKayitForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKayitForm));
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtAdres = new System.Windows.Forms.RichTextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtHasta_adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHasta = new System.Windows.Forms.DataGridView();
            this.btnHastaKaydet = new System.Windows.Forms.Button();
            this.btnAna = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.ForeColor = System.Drawing.Color.Black;
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cbCinsiyet.Location = new System.Drawing.Point(140, 57);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(248, 23);
            this.cbCinsiyet.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "CİNSİYET  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(400, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "ADRES  :";
            // 
            // rtxtAdres
            // 
            this.rtxtAdres.ForeColor = System.Drawing.Color.Black;
            this.rtxtAdres.Location = new System.Drawing.Point(474, 25);
            this.rtxtAdres.Name = "rtxtAdres";
            this.rtxtAdres.Size = new System.Drawing.Size(248, 93);
            this.rtxtAdres.TabIndex = 57;
            this.rtxtAdres.Text = "";
            // 
            // txtTel
            // 
            this.txtTel.ForeColor = System.Drawing.Color.Black;
            this.txtTel.Location = new System.Drawing.Point(140, 92);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(248, 22);
            this.txtTel.TabIndex = 55;
            // 
            // txtHasta_adi
            // 
            this.txtHasta_adi.ForeColor = System.Drawing.Color.Black;
            this.txtHasta_adi.Location = new System.Drawing.Point(140, 20);
            this.txtHasta_adi.Name = "txtHasta_adi";
            this.txtHasta_adi.Size = new System.Drawing.Size(248, 22);
            this.txtHasta_adi.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "TELEFON  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "ADI SOYADI  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewHasta);
            this.groupBox1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(90, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 247);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Listesi";
            // 
            // dataGridViewHasta
            // 
            this.dataGridViewHasta.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridViewHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHasta.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHasta.Location = new System.Drawing.Point(41, 21);
            this.dataGridViewHasta.Name = "dataGridViewHasta";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dataGridViewHasta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHasta.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewHasta.Size = new System.Drawing.Size(572, 211);
            this.dataGridViewHasta.TabIndex = 56;
            // 
            // btnHastaKaydet
            // 
            this.btnHastaKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastaKaydet.BackgroundImage")));
            this.btnHastaKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaKaydet.FlatAppearance.BorderSize = 0;
            this.btnHastaKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaKaydet.Location = new System.Drawing.Point(739, 25);
            this.btnHastaKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHastaKaydet.Name = "btnHastaKaydet";
            this.btnHastaKaydet.Size = new System.Drawing.Size(63, 64);
            this.btnHastaKaydet.TabIndex = 76;
            this.btnHastaKaydet.UseVisualStyleBackColor = true;
            this.btnHastaKaydet.Click += new System.EventHandler(this.btnHastaKaydet_Click);
            // 
            // btnAna
            // 
            this.btnAna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAna.BackgroundImage")));
            this.btnAna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAna.FlatAppearance.BorderSize = 0;
            this.btnAna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAna.Location = new System.Drawing.Point(19, 412);
            this.btnAna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(71, 63);
            this.btnAna.TabIndex = 77;
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // HastaKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(830, 488);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.btnHastaKaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtAdres);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtHasta_adi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HastaKayitForm";
            this.Text = "HastaKayit";
            this.Load += new System.EventHandler(this.HastaKayit_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtAdres;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtHasta_adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewHasta;
        private System.Windows.Forms.Button btnHastaKaydet;
        private System.Windows.Forms.Button btnAna;
    }
}