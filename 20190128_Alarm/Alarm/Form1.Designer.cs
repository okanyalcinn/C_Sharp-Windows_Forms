namespace Alarm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._txtTarih = new System.Windows.Forms.TextBox();
            this._txtSaat = new System.Windows.Forms.TextBox();
            this._txtMetin = new System.Windows.Forms.TextBox();
            this._tmrAlarmSure = new System.Windows.Forms.Timer(this.components);
            this._btnAlarmKapat = new System.Windows.Forms.Button();
            this._btnAlarmAc = new System.Windows.Forms.Button();
            this._tmrDurum = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alarm Metin :";
            // 
            // _txtTarih
            // 
            this._txtTarih.Location = new System.Drawing.Point(95, 28);
            this._txtTarih.Name = "_txtTarih";
            this._txtTarih.Size = new System.Drawing.Size(100, 20);
            this._txtTarih.TabIndex = 3;
            // 
            // _txtSaat
            // 
            this._txtSaat.Location = new System.Drawing.Point(95, 54);
            this._txtSaat.Name = "_txtSaat";
            this._txtSaat.Size = new System.Drawing.Size(100, 20);
            this._txtSaat.TabIndex = 4;
            // 
            // _txtMetin
            // 
            this._txtMetin.Location = new System.Drawing.Point(95, 80);
            this._txtMetin.Name = "_txtMetin";
            this._txtMetin.Size = new System.Drawing.Size(100, 20);
            this._txtMetin.TabIndex = 5;
            // 
            // _tmrAlarmSure
            // 
            this._tmrAlarmSure.Tick += new System.EventHandler(this._tmrAlarmSure_Tick);
            // 
            // _btnAlarmKapat
            // 
            this._btnAlarmKapat.Image = global::Alarm.Properties.Resources.icon2;
            this._btnAlarmKapat.Location = new System.Drawing.Point(314, 28);
            this._btnAlarmKapat.Name = "_btnAlarmKapat";
            this._btnAlarmKapat.Size = new System.Drawing.Size(87, 72);
            this._btnAlarmKapat.TabIndex = 7;
            this._btnAlarmKapat.Text = "Alarm Kapat";
            this._btnAlarmKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnAlarmKapat.UseVisualStyleBackColor = true;
            this._btnAlarmKapat.Click += new System.EventHandler(this._btnAlarmKapat_Click);
            // 
            // _btnAlarmAc
            // 
            this._btnAlarmAc.Image = global::Alarm.Properties.Resources.icon1;
            this._btnAlarmAc.Location = new System.Drawing.Point(218, 28);
            this._btnAlarmAc.Name = "_btnAlarmAc";
            this._btnAlarmAc.Size = new System.Drawing.Size(90, 72);
            this._btnAlarmAc.TabIndex = 6;
            this._btnAlarmAc.Text = "Alarm  Aç";
            this._btnAlarmAc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnAlarmAc.UseVisualStyleBackColor = true;
            this._btnAlarmAc.Click += new System.EventHandler(this._btnAlarmAc_Click);
            // 
            // _tmrDurum
            // 
            this._tmrDurum.Tick += new System.EventHandler(this._tmrDurum_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 127);
            this.Controls.Add(this._btnAlarmKapat);
            this.Controls.Add(this._btnAlarmAc);
            this.Controls.Add(this._txtMetin);
            this.Controls.Add(this._txtSaat);
            this.Controls.Add(this._txtTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtTarih;
        private System.Windows.Forms.TextBox _txtSaat;
        private System.Windows.Forms.TextBox _txtMetin;
        private System.Windows.Forms.Button _btnAlarmAc;
        private System.Windows.Forms.Button _btnAlarmKapat;
        private System.Windows.Forms.Timer _tmrAlarmSure;
        private System.Windows.Forms.Timer _tmrDurum;
    }
}

