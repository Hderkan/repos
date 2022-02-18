
namespace withClasssql_2_Crud
{
    partial class randevu
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
            this.dgvHastalar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArananHasta = new System.Windows.Forms.TextBox();
            this.cmbBolum = new System.Windows.Forms.Label();
            this.cbmBolumler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ltbDoktorlar = new System.Windows.Forms.ListBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtsaat = new System.Windows.Forms.Label();
            this.dtpsaat = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHastalar
            // 
            this.dgvHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHastalar.Location = new System.Drawing.Point(12, 76);
            this.dgvHastalar.Name = "dgvHastalar";
            this.dgvHastalar.Size = new System.Drawing.Size(324, 362);
            this.dgvHastalar.TabIndex = 0;
            this.dgvHastalar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHastalar_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "hasta";
            // 
            // txtArananHasta
            // 
            this.txtArananHasta.Location = new System.Drawing.Point(139, 30);
            this.txtArananHasta.Name = "txtArananHasta";
            this.txtArananHasta.Size = new System.Drawing.Size(100, 20);
            this.txtArananHasta.TabIndex = 2;
            // 
            // cmbBolum
            // 
            this.cmbBolum.AutoSize = true;
            this.cmbBolum.Location = new System.Drawing.Point(378, 27);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(35, 13);
            this.cmbBolum.TabIndex = 3;
            this.cmbBolum.Text = "bolum";
            // 
            // cbmBolumler
            // 
            this.cbmBolumler.FormattingEnabled = true;
            this.cbmBolumler.Location = new System.Drawing.Point(431, 27);
            this.cbmBolumler.Name = "cbmBolumler";
            this.cbmBolumler.Size = new System.Drawing.Size(121, 21);
            this.cbmBolumler.TabIndex = 4;
            this.cbmBolumler.SelectedIndexChanged += new System.EventHandler(this.cbmBolumler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "doktor secimi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(588, 105);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "tarih";
            // 
            // ltbDoktorlar
            // 
            this.ltbDoktorlar.FormattingEnabled = true;
            this.ltbDoktorlar.Location = new System.Drawing.Point(647, 181);
            this.ltbDoktorlar.Name = "ltbDoktorlar";
            this.ltbDoktorlar.Size = new System.Drawing.Size(141, 225);
            this.ltbDoktorlar.TabIndex = 6;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(694, 415);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 7;
            this.btnkaydet.Text = "kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtsaat
            // 
            this.txtsaat.AutoSize = true;
            this.txtsaat.Location = new System.Drawing.Point(544, 135);
            this.txtsaat.Name = "txtsaat";
            this.txtsaat.Size = new System.Drawing.Size(27, 13);
            this.txtsaat.TabIndex = 3;
            this.txtsaat.Text = "saat";
            // 
            // dtpsaat
            // 
            this.dtpsaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpsaat.Location = new System.Drawing.Point(588, 131);
            this.dtpsaat.Name = "dtpsaat";
            this.dtpsaat.Size = new System.Drawing.Size(200, 20);
            this.dtpsaat.TabIndex = 5;
            // 
            // randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.ltbDoktorlar);
            this.Controls.Add(this.dtpsaat);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbmBolumler);
            this.Controls.Add(this.txtsaat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.txtArananHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHastalar);
            this.Name = "randevu";
            this.Text = "randevu";
            this.Load += new System.EventHandler(this.randevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHastalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArananHasta;
        private System.Windows.Forms.Label cmbBolum;
        private System.Windows.Forms.ComboBox cbmBolumler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ltbDoktorlar;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label txtsaat;
        private System.Windows.Forms.DateTimePicker dtpsaat;
    }
}