namespace PodEditor
{
    partial class AramaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtArananDeger = new System.Windows.Forms.TextBox();
            this._txtYeniDeger = new System.Windows.Forms.TextBox();
            this._btnBul = new System.Windows.Forms.Button();
            this._btnSonrakiniBul = new System.Windows.Forms.Button();
            this._btnDegistir = new System.Windows.Forms.Button();
            this._btnTumunuDegistir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._rdbtnSoldanBasla = new System.Windows.Forms.RadioButton();
            this._rdbtnBastanBasla = new System.Windows.Forms.RadioButton();
            this._chkBuyukKucukHarf = new System.Windows.Forms.CheckBox();
            this._chkTamSozluklar = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranan Değer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni Değer";
            // 
            // _txtArananDeger
            // 
            this._txtArananDeger.Location = new System.Drawing.Point(97, 28);
            this._txtArananDeger.Name = "_txtArananDeger";
            this._txtArananDeger.Size = new System.Drawing.Size(144, 20);
            this._txtArananDeger.TabIndex = 2;
            // 
            // _txtYeniDeger
            // 
            this._txtYeniDeger.Location = new System.Drawing.Point(97, 57);
            this._txtYeniDeger.Name = "_txtYeniDeger";
            this._txtYeniDeger.Size = new System.Drawing.Size(144, 20);
            this._txtYeniDeger.TabIndex = 3;
            // 
            // _btnBul
            // 
            this._btnBul.Location = new System.Drawing.Point(281, 30);
            this._btnBul.Name = "_btnBul";
            this._btnBul.Size = new System.Drawing.Size(113, 23);
            this._btnBul.TabIndex = 4;
            this._btnBul.Text = "&Bul";
            this._btnBul.UseVisualStyleBackColor = true;
            this._btnBul.Click += new System.EventHandler(this._btnBul_Click);
            // 
            // _btnSonrakiniBul
            // 
            this._btnSonrakiniBul.Location = new System.Drawing.Point(281, 59);
            this._btnSonrakiniBul.Name = "_btnSonrakiniBul";
            this._btnSonrakiniBul.Size = new System.Drawing.Size(113, 23);
            this._btnSonrakiniBul.TabIndex = 5;
            this._btnSonrakiniBul.Text = "Sonrakini Bul";
            this._btnSonrakiniBul.UseVisualStyleBackColor = true;
            this._btnSonrakiniBul.Click += new System.EventHandler(this._btnSonrakiniBul_Click);
            // 
            // _btnDegistir
            // 
            this._btnDegistir.Location = new System.Drawing.Point(281, 119);
            this._btnDegistir.Name = "_btnDegistir";
            this._btnDegistir.Size = new System.Drawing.Size(113, 23);
            this._btnDegistir.TabIndex = 6;
            this._btnDegistir.Text = "Değiştir";
            this._btnDegistir.UseVisualStyleBackColor = true;
            this._btnDegistir.Click += new System.EventHandler(this._btnDegistir_Click);
            // 
            // _btnTumunuDegistir
            // 
            this._btnTumunuDegistir.Location = new System.Drawing.Point(281, 148);
            this._btnTumunuDegistir.Name = "_btnTumunuDegistir";
            this._btnTumunuDegistir.Size = new System.Drawing.Size(113, 23);
            this._btnTumunuDegistir.TabIndex = 7;
            this._btnTumunuDegistir.Text = "Tümünü Değiştir";
            this._btnTumunuDegistir.UseVisualStyleBackColor = true;
            this._btnTumunuDegistir.Click += new System.EventHandler(this._btnTumunuDegistir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._rdbtnSoldanBasla);
            this.groupBox1.Controls.Add(this._rdbtnBastanBasla);
            this.groupBox1.Location = new System.Drawing.Point(21, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 77);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arma Yönü";
            // 
            // _rdbtnSoldanBasla
            // 
            this._rdbtnSoldanBasla.AutoSize = true;
            this._rdbtnSoldanBasla.Location = new System.Drawing.Point(13, 48);
            this._rdbtnSoldanBasla.Name = "_rdbtnSoldanBasla";
            this._rdbtnSoldanBasla.Size = new System.Drawing.Size(87, 17);
            this._rdbtnSoldanBasla.TabIndex = 1;
            this._rdbtnSoldanBasla.TabStop = true;
            this._rdbtnSoldanBasla.Text = "Soldan Başla";
            this._rdbtnSoldanBasla.UseVisualStyleBackColor = true;
            // 
            // _rdbtnBastanBasla
            // 
            this._rdbtnBastanBasla.AutoSize = true;
            this._rdbtnBastanBasla.Location = new System.Drawing.Point(14, 25);
            this._rdbtnBastanBasla.Name = "_rdbtnBastanBasla";
            this._rdbtnBastanBasla.Size = new System.Drawing.Size(87, 17);
            this._rdbtnBastanBasla.TabIndex = 0;
            this._rdbtnBastanBasla.TabStop = true;
            this._rdbtnBastanBasla.Text = "Baştan Başla";
            this._rdbtnBastanBasla.UseVisualStyleBackColor = true;
            // 
            // _chkBuyukKucukHarf
            // 
            this._chkBuyukKucukHarf.AutoSize = true;
            this._chkBuyukKucukHarf.Location = new System.Drawing.Point(151, 123);
            this._chkBuyukKucukHarf.Name = "_chkBuyukKucukHarf";
            this._chkBuyukKucukHarf.Size = new System.Drawing.Size(113, 17);
            this._chkBuyukKucukHarf.TabIndex = 9;
            this._chkBuyukKucukHarf.Text = "Buyuk Küçük Harf";
            this._chkBuyukKucukHarf.UseVisualStyleBackColor = true;
            // 
            // _chkTamSozluklar
            // 
            this._chkTamSozluklar.AutoSize = true;
            this._chkTamSozluklar.Location = new System.Drawing.Point(151, 147);
            this._chkTamSozluklar.Name = "_chkTamSozluklar";
            this._chkTamSozluklar.Size = new System.Drawing.Size(113, 17);
            this._chkTamSozluklar.TabIndex = 10;
            this._chkTamSozluklar.Text = "Tam Sözlükleri Bul";
            this._chkTamSozluklar.UseVisualStyleBackColor = true;
            // 
            // AramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 199);
            this.Controls.Add(this._chkTamSozluklar);
            this.Controls.Add(this._chkBuyukKucukHarf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnTumunuDegistir);
            this.Controls.Add(this._btnDegistir);
            this.Controls.Add(this._btnSonrakiniBul);
            this.Controls.Add(this._btnBul);
            this.Controls.Add(this._txtYeniDeger);
            this.Controls.Add(this._txtArananDeger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AramaForm";
            this.Text = "AramaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnBul;
        private System.Windows.Forms.Button _btnSonrakiniBul;
        private System.Windows.Forms.Button _btnDegistir;
        private System.Windows.Forms.Button _btnTumunuDegistir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _rdbtnSoldanBasla;
        private System.Windows.Forms.RadioButton _rdbtnBastanBasla;
        private System.Windows.Forms.CheckBox _chkBuyukKucukHarf;
        private System.Windows.Forms.CheckBox _chkTamSozluklar;
        public System.Windows.Forms.TextBox _txtArananDeger;
        public System.Windows.Forms.TextBox _txtYeniDeger;
    }
}