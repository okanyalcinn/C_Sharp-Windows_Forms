namespace Giris_Uygulamasi
{
    partial class Form2
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
            this._btnGeriDon = new System.Windows.Forms.Button();
            this._btnCik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtCocukSayisi = new System.Windows.Forms.TextBox();
            this._btnHesapla = new System.Windows.Forms.Button();
            this._chkEvli = new System.Windows.Forms.CheckBox();
            this._chkEsCalisiyor = new System.Windows.Forms.CheckBox();
            this._txtMaas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _btnGeriDon
            // 
            this._btnGeriDon.Location = new System.Drawing.Point(24, 161);
            this._btnGeriDon.Name = "_btnGeriDon";
            this._btnGeriDon.Size = new System.Drawing.Size(133, 25);
            this._btnGeriDon.TabIndex = 0;
            this._btnGeriDon.Text = "Giriş ekranı dönüş";
            this._btnGeriDon.UseVisualStyleBackColor = true;
            this._btnGeriDon.Click += new System.EventHandler(this._btnGeriDon_Click);
            // 
            // _btnCik
            // 
            this._btnCik.Location = new System.Drawing.Point(174, 162);
            this._btnCik.Name = "_btnCik";
            this._btnCik.Size = new System.Drawing.Size(75, 23);
            this._btnCik.TabIndex = 1;
            this._btnCik.Text = "Çıkış";
            this._btnCik.UseVisualStyleBackColor = true;
            this._btnCik.Click += new System.EventHandler(this._btnCik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maaş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Çocuk Sayısı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // _txtCocukSayisi
            // 
            this._txtCocukSayisi.Location = new System.Drawing.Point(147, 94);
            this._txtCocukSayisi.Name = "_txtCocukSayisi";
            this._txtCocukSayisi.Size = new System.Drawing.Size(100, 20);
            this._txtCocukSayisi.TabIndex = 4;
            // 
            // _btnHesapla
            // 
            this._btnHesapla.Location = new System.Drawing.Point(117, 120);
            this._btnHesapla.Name = "_btnHesapla";
            this._btnHesapla.Size = new System.Drawing.Size(130, 23);
            this._btnHesapla.TabIndex = 6;
            this._btnHesapla.Text = "AGİ - Hesapla";
            this._btnHesapla.UseVisualStyleBackColor = true;
            this._btnHesapla.Click += new System.EventHandler(this._btnHesapla_Click);
            // 
            // _chkEvli
            // 
            this._chkEvli.AutoSize = true;
            this._chkEvli.Location = new System.Drawing.Point(147, 52);
            this._chkEvli.Name = "_chkEvli";
            this._chkEvli.Size = new System.Drawing.Size(43, 17);
            this._chkEvli.TabIndex = 7;
            this._chkEvli.Text = "Evli";
            this._chkEvli.UseVisualStyleBackColor = true;
            this._chkEvli.CheckedChanged += new System.EventHandler(this._Evli_CheckedChanged);
            // 
            // _chkEsCalisiyor
            // 
            this._chkEsCalisiyor.AutoSize = true;
            this._chkEsCalisiyor.Location = new System.Drawing.Point(147, 73);
            this._chkEsCalisiyor.Name = "_chkEsCalisiyor";
            this._chkEsCalisiyor.Size = new System.Drawing.Size(79, 17);
            this._chkEsCalisiyor.TabIndex = 8;
            this._chkEsCalisiyor.Text = "Eş Çalışıyor";
            this._chkEsCalisiyor.UseVisualStyleBackColor = true;
            this._chkEsCalisiyor.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // _txtMaas
            // 
            this._txtMaas.Location = new System.Drawing.Point(147, 26);
            this._txtMaas.Name = "_txtMaas";
            this._txtMaas.Size = new System.Drawing.Size(100, 20);
            this._txtMaas.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 213);
            this.Controls.Add(this._txtMaas);
            this.Controls.Add(this._chkEsCalisiyor);
            this.Controls.Add(this._chkEvli);
            this.Controls.Add(this._btnHesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtCocukSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnCik);
            this.Controls.Add(this._btnGeriDon);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnGeriDon;
        private System.Windows.Forms.Button _btnCik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtCocukSayisi;
        private System.Windows.Forms.Button _btnHesapla;
        private System.Windows.Forms.CheckBox _chkEvli;
        private System.Windows.Forms.CheckBox _chkEsCalisiyor;
        private System.Windows.Forms.TextBox _txtMaas;
    }
}