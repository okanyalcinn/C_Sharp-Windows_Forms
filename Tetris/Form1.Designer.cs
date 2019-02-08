namespace Tetris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._picTop = new System.Windows.Forms.PictureBox();
            this._btnOdun = new System.Windows.Forms.Button();
            this._tmr1 = new System.Windows.Forms.Timer(this.components);
            this._tmr2 = new System.Windows.Forms.Timer(this.components);
            this._imgLstTop = new System.Windows.Forms.ImageList(this.components);
            this._imgLstKutu = new System.Windows.Forms.ImageList(this.components);
            this._lblPuan = new System.Windows.Forms.Label();
            this._lblKutuSayisi = new System.Windows.Forms.Label();
            this._lblLevel = new System.Windows.Forms.Label();
            this._lblTepki = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._picTop)).BeginInit();
            this.SuspendLayout();
            // 
            // _picTop
            // 
            this._picTop.Image = ((System.Drawing.Image)(resources.GetObject("_picTop.Image")));
            this._picTop.Location = new System.Drawing.Point(165, 295);
            this._picTop.Name = "_picTop";
            this._picTop.Size = new System.Drawing.Size(20, 19);
            this._picTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picTop.TabIndex = 0;
            this._picTop.TabStop = false;
            // 
            // _btnOdun
            // 
            this._btnOdun.Location = new System.Drawing.Point(100, 310);
            this._btnOdun.Name = "_btnOdun";
            this._btnOdun.Size = new System.Drawing.Size(111, 35);
            this._btnOdun.TabIndex = 1;
            this._btnOdun.Text = "button1";
            this._btnOdun.UseVisualStyleBackColor = true;
            this._btnOdun.MouseMove += new System.Windows.Forms.MouseEventHandler(this._btnOdun_MouseMove);
            // 
            // _tmr1
            // 
            this._tmr1.Tick += new System.EventHandler(this._tmr1_Tick);
            // 
            // _tmr2
            // 
            this._tmr2.Tick += new System.EventHandler(this._tmr2_Tick);
            // 
            // _imgLstTop
            // 
            this._imgLstTop.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgLstTop.ImageStream")));
            this._imgLstTop.TransparentColor = System.Drawing.Color.Transparent;
            this._imgLstTop.Images.SetKeyName(0, "1.ico");
            this._imgLstTop.Images.SetKeyName(1, "2.ico");
            this._imgLstTop.Images.SetKeyName(2, "3.ico");
            this._imgLstTop.Images.SetKeyName(3, "4.ico");
            this._imgLstTop.Images.SetKeyName(4, "5.ico");
            this._imgLstTop.Images.SetKeyName(5, "6.ico");
            this._imgLstTop.Images.SetKeyName(6, "7.ico");
            // 
            // _imgLstKutu
            // 
            this._imgLstKutu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgLstKutu.ImageStream")));
            this._imgLstKutu.TransparentColor = System.Drawing.Color.Transparent;
            this._imgLstKutu.Images.SetKeyName(0, "emoticon-1.ico");
            this._imgLstKutu.Images.SetKeyName(1, "emoticon-2.ico");
            this._imgLstKutu.Images.SetKeyName(2, "emoticon-3.ico");
            this._imgLstKutu.Images.SetKeyName(3, "emoticon-4.ico");
            this._imgLstKutu.Images.SetKeyName(4, "emoticon-5.ico");
            this._imgLstKutu.Images.SetKeyName(5, "emoticon-6.ico");
            this._imgLstKutu.Images.SetKeyName(6, "emoticon-7.ico");
            this._imgLstKutu.Images.SetKeyName(7, "emoticon-8.ico");
            this._imgLstKutu.Images.SetKeyName(8, "emoticon-9.ico");
            this._imgLstKutu.Images.SetKeyName(9, "emoticon-10.ico");
            this._imgLstKutu.Images.SetKeyName(10, "emoticon-11.ico");
            this._imgLstKutu.Images.SetKeyName(11, "emoticon-12.ico");
            // 
            // _lblPuan
            // 
            this._lblPuan.AutoSize = true;
            this._lblPuan.Location = new System.Drawing.Point(150, 375);
            this._lblPuan.Name = "_lblPuan";
            this._lblPuan.Size = new System.Drawing.Size(35, 13);
            this._lblPuan.TabIndex = 2;
            this._lblPuan.Text = "label1";
            // 
            // _lblKutuSayisi
            // 
            this._lblKutuSayisi.AutoSize = true;
            this._lblKutuSayisi.Location = new System.Drawing.Point(281, 375);
            this._lblKutuSayisi.Name = "_lblKutuSayisi";
            this._lblKutuSayisi.Size = new System.Drawing.Size(35, 13);
            this._lblKutuSayisi.TabIndex = 3;
            this._lblKutuSayisi.Text = "label2";
            // 
            // _lblLevel
            // 
            this._lblLevel.AutoSize = true;
            this._lblLevel.Location = new System.Drawing.Point(411, 375);
            this._lblLevel.Name = "_lblLevel";
            this._lblLevel.Size = new System.Drawing.Size(35, 13);
            this._lblLevel.TabIndex = 4;
            this._lblLevel.Text = "label3";
            // 
            // _lblTepki
            // 
            this._lblTepki.AutoSize = true;
            this._lblTepki.Location = new System.Drawing.Point(569, 375);
            this._lblTepki.Name = "_lblTepki";
            this._lblTepki.Size = new System.Drawing.Size(35, 13);
            this._lblTepki.TabIndex = 5;
            this._lblTepki.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this._lblTepki);
            this.Controls.Add(this._lblLevel);
            this.Controls.Add(this._lblKutuSayisi);
            this.Controls.Add(this._lblPuan);
            this.Controls.Add(this._btnOdun);
            this.Controls.Add(this._picTop);
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this._picTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _picTop;
        private System.Windows.Forms.Button _btnOdun;
        private System.Windows.Forms.Timer _tmr1;
        private System.Windows.Forms.Timer _tmr2;
        private System.Windows.Forms.ImageList _imgLstTop;
        private System.Windows.Forms.ImageList _imgLstKutu;
        private System.Windows.Forms.Label _lblPuan;
        private System.Windows.Forms.Label _lblKutuSayisi;
        private System.Windows.Forms.Label _lblLevel;
        private System.Windows.Forms.Label _lblTepki;
    }
}

