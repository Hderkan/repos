
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
            this.btnHastalar = new System.Windows.Forms.Button();
            this.tblBolumler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHastalar
            // 
            this.btnHastalar.Location = new System.Drawing.Point(183, 43);
            this.btnHastalar.Name = "btnHastalar";
            this.btnHastalar.Size = new System.Drawing.Size(75, 23);
            this.btnHastalar.TabIndex = 2;
            this.btnHastalar.Text = "hastalar";
            this.btnHastalar.UseVisualStyleBackColor = true;
            this.btnHastalar.Click += new System.EventHandler(this.btnHastalar_Click);
            // 
            // tblBolumler
            // 
            this.tblBolumler.Location = new System.Drawing.Point(183, 104);
            this.tblBolumler.Name = "tblBolumler";
            this.tblBolumler.Size = new System.Drawing.Size(75, 23);
            this.tblBolumler.TabIndex = 3;
            this.tblBolumler.Text = "bolumler";
            this.tblBolumler.UseVisualStyleBackColor = true;
            this.tblBolumler.Click += new System.EventHandler(this.tblBolumler_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblBolumler);
            this.Controls.Add(this.btnHastalar);
            this.Name = "FormAna";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FormAna_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAna_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHastalar;
        private System.Windows.Forms.Button tblBolumler;
    }
}

