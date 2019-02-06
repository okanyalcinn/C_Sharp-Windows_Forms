namespace Combo_List_Resim_Ekleme
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
            this._cmb_icon = new System.Windows.Forms.ComboBox();
            this._imgList = new System.Windows.Forms.ImageList(this.components);
            this._listbx_icon = new System.Windows.Forms.ListBox();
            this._prgbrIslem = new System.Windows.Forms.ProgressBar();
            this._btnYukle = new System.Windows.Forms.Button();
            this._btnVazgec = new System.Windows.Forms.Button();
            this._tmrSure = new System.Windows.Forms.Timer(this.components);
            this._lblYuzde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cmb_icon
            // 
            this._cmb_icon.FormattingEnabled = true;
            this._cmb_icon.Location = new System.Drawing.Point(35, 231);
            this._cmb_icon.Name = "_cmb_icon";
            this._cmb_icon.Size = new System.Drawing.Size(121, 21);
            this._cmb_icon.TabIndex = 0;
            this._cmb_icon.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._cmb_icon_DrawItem);
            this._cmb_icon.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this._cmb_icon_MeasureItem);
            // 
            // _imgList
            // 
            this._imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgList.ImageStream")));
            this._imgList.TransparentColor = System.Drawing.Color.Transparent;
            this._imgList.Images.SetKeyName(0, "back-alt.ico");
            this._imgList.Images.SetKeyName(1, "down-alt.ico");
            this._imgList.Images.SetKeyName(2, "forward-alt.ico");
            this._imgList.Images.SetKeyName(3, "up-alt.ico");
            // 
            // _listbx_icon
            // 
            this._listbx_icon.FormattingEnabled = true;
            this._listbx_icon.Location = new System.Drawing.Point(38, 23);
            this._listbx_icon.Name = "_listbx_icon";
            this._listbx_icon.Size = new System.Drawing.Size(118, 173);
            this._listbx_icon.TabIndex = 1;
            this._listbx_icon.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._listbx_icon_DrawItem);
            // 
            // _prgbrIslem
            // 
            this._prgbrIslem.Location = new System.Drawing.Point(174, 39);
            this._prgbrIslem.Name = "_prgbrIslem";
            this._prgbrIslem.Size = new System.Drawing.Size(379, 23);
            this._prgbrIslem.TabIndex = 2;
            // 
            // _btnYukle
            // 
            this._btnYukle.Location = new System.Drawing.Point(174, 98);
            this._btnYukle.Name = "_btnYukle";
            this._btnYukle.Size = new System.Drawing.Size(124, 23);
            this._btnYukle.TabIndex = 3;
            this._btnYukle.Text = "Yüklemeye Başla";
            this._btnYukle.UseVisualStyleBackColor = true;
            this._btnYukle.Click += new System.EventHandler(this._btnYukle_Click);
            // 
            // _btnVazgec
            // 
            this._btnVazgec.Location = new System.Drawing.Point(478, 98);
            this._btnVazgec.Name = "_btnVazgec";
            this._btnVazgec.Size = new System.Drawing.Size(75, 23);
            this._btnVazgec.TabIndex = 4;
            this._btnVazgec.Text = "Vageç";
            this._btnVazgec.UseVisualStyleBackColor = true;
            this._btnVazgec.Click += new System.EventHandler(this._btnVazgec_Click);
            // 
            // _tmrSure
            // 
            this._tmrSure.Tick += new System.EventHandler(this._tmrSure_Tick);
            // 
            // _lblYuzde
            // 
            this._lblYuzde.AutoSize = true;
            this._lblYuzde.Location = new System.Drawing.Point(190, 71);
            this._lblYuzde.Name = "_lblYuzde";
            this._lblYuzde.Size = new System.Drawing.Size(35, 13);
            this._lblYuzde.TabIndex = 5;
            this._lblYuzde.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 331);
            this.Controls.Add(this._lblYuzde);
            this.Controls.Add(this._btnVazgec);
            this.Controls.Add(this._btnYukle);
            this.Controls.Add(this._prgbrIslem);
            this.Controls.Add(this._listbx_icon);
            this.Controls.Add(this._cmb_icon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cmb_icon;
        private System.Windows.Forms.ImageList _imgList;
        private System.Windows.Forms.ListBox _listbx_icon;
        private System.Windows.Forms.ProgressBar _prgbrIslem;
        private System.Windows.Forms.Button _btnYukle;
        private System.Windows.Forms.Button _btnVazgec;
        private System.Windows.Forms.Timer _tmrSure;
        private System.Windows.Forms.Label _lblYuzde;
    }
}

