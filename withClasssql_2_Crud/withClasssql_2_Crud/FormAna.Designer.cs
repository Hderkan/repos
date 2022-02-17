
namespace withClasssql_2_Crud
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
            this.dgvHastalar = new System.Windows.Forms.DataGridView();
            this.btnYeniKayıt = new System.Windows.Forms.Button();
            this.btnListe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHastalar
            // 
            this.dgvHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHastalar.Location = new System.Drawing.Point(25, 29);
            this.dgvHastalar.Name = "dgvHastalar";
            this.dgvHastalar.Size = new System.Drawing.Size(731, 190);
            this.dgvHastalar.TabIndex = 0;
            // 
            // btnYeniKayıt
            // 
            this.btnYeniKayıt.Location = new System.Drawing.Point(127, 261);
            this.btnYeniKayıt.Name = "btnYeniKayıt";
            this.btnYeniKayıt.Size = new System.Drawing.Size(75, 23);
            this.btnYeniKayıt.TabIndex = 1;
            this.btnYeniKayıt.Text = "Yeni Kayıt";
            this.btnYeniKayıt.UseVisualStyleBackColor = true;
            this.btnYeniKayıt.Click += new System.EventHandler(this.btnYeniKayıt_Click);
            // 
            // btnListe
            // 
            this.btnListe.Location = new System.Drawing.Point(325, 260);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(75, 23);
            this.btnListe.TabIndex = 2;
            this.btnListe.Text = "Liste";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.btnYeniKayıt);
            this.Controls.Add(this.dgvHastalar);
            this.Name = "FormAna";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FormAna_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAna_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHastalar;
        private System.Windows.Forms.Button btnYeniKayıt;
        private System.Windows.Forms.Button btnListe;
    }
}

