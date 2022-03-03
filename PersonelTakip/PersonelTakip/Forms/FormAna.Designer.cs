
namespace PersonelTakip
{
    partial class FormAna
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
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpIseBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartmanID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUnvanID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDurumu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnTam = new System.Windows.Forms.RadioButton();
            this.rbnBenzer = new System.Windows.Forms.RadioButton();
            this.rbnBasla = new System.Windows.Forms.RadioButton();
            this.pnlAraclar = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlAraclar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.Location = new System.Drawing.Point(293, 0);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalisanlar.Size = new System.Drawing.Size(511, 371);
            this.dgvCalisanlar.TabIndex = 0;
            this.dgvCalisanlar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalisanlar_CellEnter);
            this.dgvCalisanlar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCalisanlar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADI";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(79, 23);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 2;
            this.txtAd.Tag = "Ad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(78, 51);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 4;
            this.txtSoyad.Tag = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOYADI";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(78, 80);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(100, 20);
            this.txtTcNo.TabIndex = 6;
            this.txtTcNo.Tag = "TcNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TC NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PERSONEL NO";
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(92, 110);
            this.txtPersonelNo.MaxLength = 5;
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelNo.TabIndex = 6;
            this.txtPersonelNo.Tag = "PersonelNo";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(78, 136);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpDogumTarihi.TabIndex = 7;
            this.dtpDogumTarihi.Tag = "DogumTarihi";
            this.dtpDogumTarihi.ValueChanged += new System.EventHandler(this.dtpDogumTarihi_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dogum T";
            // 
            // dtpIseBaslamaTarihi
            // 
            this.dtpIseBaslamaTarihi.Location = new System.Drawing.Point(78, 165);
            this.dtpIseBaslamaTarihi.Name = "dtpIseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpIseBaslamaTarihi.TabIndex = 9;
            this.dtpIseBaslamaTarihi.Tag = "IseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.ValueChanged += new System.EventHandler(this.dtpIseBaslamaTarihi_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Baslama T";
            // 
            // cmbDepartmanID
            // 
            this.cmbDepartmanID.FormattingEnabled = true;
            this.cmbDepartmanID.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Muhasebe",
            "Teknik",
            "Üretim",
            "Satış"});
            this.cmbDepartmanID.Location = new System.Drawing.Point(79, 203);
            this.cmbDepartmanID.Name = "cmbDepartmanID";
            this.cmbDepartmanID.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartmanID.TabIndex = 10;
            this.cmbDepartmanID.Tag = "DepartmanID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "DepartmanID";
            // 
            // cmbUnvanID
            // 
            this.cmbUnvanID.FormattingEnabled = true;
            this.cmbUnvanID.Items.AddRange(new object[] {
            "Isçi",
            "Ekip Lideri",
            "Yönetici Yardımcısı",
            "Yönetici"});
            this.cmbUnvanID.Location = new System.Drawing.Point(80, 228);
            this.cmbUnvanID.Name = "cmbUnvanID";
            this.cmbUnvanID.Size = new System.Drawing.Size(121, 21);
            this.cmbUnvanID.TabIndex = 12;
            this.cmbUnvanID.Tag = "UnvanID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "UnvanID";
            // 
            // cmbDurumu
            // 
            this.cmbDurumu.FormattingEnabled = true;
            this.cmbDurumu.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cmbDurumu.Location = new System.Drawing.Point(79, 253);
            this.cmbDurumu.Name = "cmbDurumu";
            this.cmbDurumu.Size = new System.Drawing.Size(121, 21);
            this.cmbDurumu.TabIndex = 14;
            this.cmbDurumu.Tag = "Durumu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Durum";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(19, 16);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(144, 19);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(4, 49);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(96, 49);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Location = new System.Drawing.Point(193, 49);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(75, 23);
            this.btnHepsiniSil.TabIndex = 15;
            this.btnHepsiniSil.Text = "Hepsini Sil";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(44, 94);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 23);
            this.btnGetir.TabIndex = 15;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(144, 94);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 15;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.rbnTam);
            this.panel1.Controls.Add(this.rbnBenzer);
            this.panel1.Controls.Add(this.rbnBasla);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnGetir);
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnHepsiniSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Location = new System.Drawing.Point(10, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 148);
            this.panel1.TabIndex = 16;
            // 
            // rbnTam
            // 
            this.rbnTam.AutoSize = true;
            this.rbnTam.Location = new System.Drawing.Point(177, 128);
            this.rbnTam.Name = "rbnTam";
            this.rbnTam.Size = new System.Drawing.Size(42, 17);
            this.rbnTam.TabIndex = 18;
            this.rbnTam.TabStop = true;
            this.rbnTam.Text = "tam";
            this.rbnTam.UseVisualStyleBackColor = true;
            // 
            // rbnBenzer
            // 
            this.rbnBenzer.AutoSize = true;
            this.rbnBenzer.Location = new System.Drawing.Point(86, 127);
            this.rbnBenzer.Name = "rbnBenzer";
            this.rbnBenzer.Size = new System.Drawing.Size(57, 17);
            this.rbnBenzer.TabIndex = 18;
            this.rbnBenzer.TabStop = true;
            this.rbnBenzer.Text = "benzer";
            this.rbnBenzer.UseVisualStyleBackColor = true;
            // 
            // rbnBasla
            // 
            this.rbnBasla.AutoSize = true;
            this.rbnBasla.Location = new System.Drawing.Point(0, 127);
            this.rbnBasla.Name = "rbnBasla";
            this.rbnBasla.Size = new System.Drawing.Size(50, 17);
            this.rbnBasla.TabIndex = 17;
            this.rbnBasla.TabStop = true;
            this.rbnBasla.Text = "basla";
            this.rbnBasla.UseVisualStyleBackColor = true;
            // 
            // pnlAraclar
            // 
            this.pnlAraclar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAraclar.Controls.Add(this.txtSoyad);
            this.pnlAraclar.Controls.Add(this.label1);
            this.pnlAraclar.Controls.Add(this.cmbDurumu);
            this.pnlAraclar.Controls.Add(this.txtAd);
            this.pnlAraclar.Controls.Add(this.label9);
            this.pnlAraclar.Controls.Add(this.label2);
            this.pnlAraclar.Controls.Add(this.cmbUnvanID);
            this.pnlAraclar.Controls.Add(this.label3);
            this.pnlAraclar.Controls.Add(this.label8);
            this.pnlAraclar.Controls.Add(this.label4);
            this.pnlAraclar.Controls.Add(this.cmbDepartmanID);
            this.pnlAraclar.Controls.Add(this.label5);
            this.pnlAraclar.Controls.Add(this.dtpIseBaslamaTarihi);
            this.pnlAraclar.Controls.Add(this.txtTcNo);
            this.pnlAraclar.Controls.Add(this.label7);
            this.pnlAraclar.Controls.Add(this.txtPersonelNo);
            this.pnlAraclar.Controls.Add(this.label6);
            this.pnlAraclar.Controls.Add(this.dtpDogumTarihi);
            this.pnlAraclar.Location = new System.Drawing.Point(-1, 0);
            this.pnlAraclar.Name = "pnlAraclar";
            this.pnlAraclar.Size = new System.Drawing.Size(288, 284);
            this.pnlAraclar.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.pnlAraclar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCalisanlar);
            this.Name = "FormAna";
            this.Text = "Wiise Akademi personel takip uygulama";
            this.Load += new System.EventHandler(this.FormAna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAraclar.ResumeLayout(false);
            this.pnlAraclar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpIseBaslamaTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartmanID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUnvanID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDurumu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAraclar;
        private System.Windows.Forms.RadioButton rbnTam;
        private System.Windows.Forms.RadioButton rbnBenzer;
        private System.Windows.Forms.RadioButton rbnBasla;
        private System.Windows.Forms.Label label10;
    }
}

