namespace OkulApp
{
    partial class frmOgretmenKayit
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
            this.grpOgretmen = new System.Windows.Forms.GroupBox();
            this.btnKaydett = new System.Windows.Forms.Button();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblSoyadd = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtSoyadd = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.grpOgretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.btnKaydett);
            this.grpOgretmen.Controls.Add(this.lblTc);
            this.grpOgretmen.Controls.Add(this.lblSoyadd);
            this.grpOgretmen.Controls.Add(this.lblAdd);
            this.grpOgretmen.Controls.Add(this.txtTc);
            this.grpOgretmen.Controls.Add(this.txtSoyadd);
            this.grpOgretmen.Controls.Add(this.txtAdd);
            this.grpOgretmen.Location = new System.Drawing.Point(32, 35);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Size = new System.Drawing.Size(324, 262);
            this.grpOgretmen.TabIndex = 0;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "Öğretmen Kayıt Formu";
            // 
            // btnKaydett
            // 
            this.btnKaydett.Location = new System.Drawing.Point(87, 205);
            this.btnKaydett.Name = "btnKaydett";
            this.btnKaydett.Size = new System.Drawing.Size(140, 24);
            this.btnKaydett.TabIndex = 6;
            this.btnKaydett.Text = "Kaydet";
            this.btnKaydett.UseVisualStyleBackColor = true;
            this.btnKaydett.Click += new System.EventHandler(this.btnKaydett_Click);
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(26, 153);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(101, 13);
            this.lblTc.TabIndex = 5;
            this.lblTc.Text = "T.C Kimlik Numarası";
            // 
            // lblSoyadd
            // 
            this.lblSoyadd.AutoSize = true;
            this.lblSoyadd.Location = new System.Drawing.Point(26, 105);
            this.lblSoyadd.Name = "lblSoyadd";
            this.lblSoyadd.Size = new System.Drawing.Size(37, 13);
            this.lblSoyadd.TabIndex = 4;
            this.lblSoyadd.Text = "Soyad";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(26, 52);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(20, 13);
            this.lblAdd.TabIndex = 3;
            this.lblAdd.Text = "Ad";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(151, 146);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(136, 20);
            this.txtTc.TabIndex = 2;
            // 
            // txtSoyadd
            // 
            this.txtSoyadd.Location = new System.Drawing.Point(151, 98);
            this.txtSoyadd.Name = "txtSoyadd";
            this.txtSoyadd.Size = new System.Drawing.Size(136, 20);
            this.txtSoyadd.TabIndex = 1;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(151, 45);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(136, 20);
            this.txtAdd.TabIndex = 0;
            // 
            // frmOgretmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 349);
            this.Controls.Add(this.grpOgretmen);
            this.Name = "frmOgretmenKayit";
            this.Text = "ÖğretmenKayıtİşlemleri";
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgretmen;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtSoyadd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblSoyadd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnKaydett;
    }
}