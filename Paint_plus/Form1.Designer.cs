namespace Paint_plus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._pnlSil = new System.Windows.Forms.Panel();
            this._pnlRenkDikey = new System.Windows.Forms.Panel();
            this._pnlRenkSec = new System.Windows.Forms.Panel();
            this._pnlSecilenRenk = new System.Windows.Forms.Panel();
            this._trackbrKalinlik = new System.Windows.Forms.TrackBar();
            this._picDairePalet = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._menuSecenekler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._picCizimAlani = new System.Windows.Forms.PictureBox();
            this._dialogCalismaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.yükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._trackbrKalinlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._picDairePalet)).BeginInit();
            this.panel2.SuspendLayout();
            this._menuSecenekler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picCizimAlani)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._pnlSil);
            this.panel1.Controls.Add(this._pnlRenkDikey);
            this.panel1.Controls.Add(this._pnlRenkSec);
            this.panel1.Controls.Add(this._pnlSecilenRenk);
            this.panel1.Controls.Add(this._trackbrKalinlik);
            this.panel1.Controls.Add(this._picDairePalet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 450);
            this.panel1.TabIndex = 0;
            // 
            // _pnlSil
            // 
            this._pnlSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlSil.BackgroundImage")));
            this._pnlSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pnlSil.Location = new System.Drawing.Point(143, 262);
            this._pnlSil.Name = "_pnlSil";
            this._pnlSil.Size = new System.Drawing.Size(49, 47);
            this._pnlSil.TabIndex = 4;
            this._pnlSil.Click += new System.EventHandler(this._pnlSil_Click);
            // 
            // _pnlRenkDikey
            // 
            this._pnlRenkDikey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlRenkDikey.BackgroundImage")));
            this._pnlRenkDikey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._pnlRenkDikey.Location = new System.Drawing.Point(190, 4);
            this._pnlRenkDikey.Name = "_pnlRenkDikey";
            this._pnlRenkDikey.Size = new System.Drawing.Size(24, 201);
            this._pnlRenkDikey.TabIndex = 4;
            // 
            // _pnlRenkSec
            // 
            this._pnlRenkSec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlRenkSec.BackgroundImage")));
            this._pnlRenkSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pnlRenkSec.Location = new System.Drawing.Point(88, 262);
            this._pnlRenkSec.Name = "_pnlRenkSec";
            this._pnlRenkSec.Size = new System.Drawing.Size(49, 47);
            this._pnlRenkSec.TabIndex = 3;
            // 
            // _pnlSecilenRenk
            // 
            this._pnlSecilenRenk.BackColor = System.Drawing.SystemColors.Desktop;
            this._pnlSecilenRenk.Location = new System.Drawing.Point(31, 262);
            this._pnlSecilenRenk.Name = "_pnlSecilenRenk";
            this._pnlSecilenRenk.Size = new System.Drawing.Size(51, 47);
            this._pnlSecilenRenk.TabIndex = 2;
            this._pnlSecilenRenk.Click += new System.EventHandler(this._pnlSecilenRenk_Click);
            // 
            // _trackbrKalinlik
            // 
            this._trackbrKalinlik.Location = new System.Drawing.Point(54, 211);
            this._trackbrKalinlik.Name = "_trackbrKalinlik";
            this._trackbrKalinlik.Size = new System.Drawing.Size(104, 45);
            this._trackbrKalinlik.TabIndex = 1;
            // 
            // _picDairePalet
            // 
            this._picDairePalet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._picDairePalet.Image = ((System.Drawing.Image)(resources.GetObject("_picDairePalet.Image")));
            this._picDairePalet.Location = new System.Drawing.Point(4, 4);
            this._picDairePalet.Name = "_picDairePalet";
            this._picDairePalet.Size = new System.Drawing.Size(180, 201);
            this._picDairePalet.TabIndex = 0;
            this._picDairePalet.TabStop = false;
            this._picDairePalet.MouseDown += new System.Windows.Forms.MouseEventHandler(this._picDairePalet_MouseDown);
            this._picDairePalet.MouseUp += new System.Windows.Forms.MouseEventHandler(this._picDairePalet_MouseUp);
            // 
            // panel2
            // 
            this.panel2.ContextMenuStrip = this._menuSecenekler;
            this.panel2.Controls.Add(this._picCizimAlani);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(231, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 450);
            this.panel2.TabIndex = 1;
            // 
            // _menuSecenekler
            // 
            this._menuSecenekler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temizleToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.çıkışToolStripMenuItem,
            this.yükleToolStripMenuItem});
            this._menuSecenekler.Name = "_menuSecenekler";
            this._menuSecenekler.Size = new System.Drawing.Size(115, 98);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // _picCizimAlani
            // 
            this._picCizimAlani.Location = new System.Drawing.Point(4, 4);
            this._picCizimAlani.Name = "_picCizimAlani";
            this._picCizimAlani.Size = new System.Drawing.Size(562, 443);
            this._picCizimAlani.TabIndex = 0;
            this._picCizimAlani.TabStop = false;
            this._picCizimAlani.MouseDown += new System.Windows.Forms.MouseEventHandler(this._picCizimAlani_MouseDown);
            this._picCizimAlani.MouseMove += new System.Windows.Forms.MouseEventHandler(this._picCizimAlani_MouseMove);
            this._picCizimAlani.MouseUp += new System.Windows.Forms.MouseEventHandler(this._picCizimAlani_MouseUp);
            // 
            // yükleToolStripMenuItem
            // 
            this.yükleToolStripMenuItem.Name = "yükleToolStripMenuItem";
            this.yükleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yükleToolStripMenuItem.Text = "Yükle";
            this.yükleToolStripMenuItem.Click += new System.EventHandler(this.yükleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._trackbrKalinlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._picDairePalet)).EndInit();
            this.panel2.ResumeLayout(false);
            this._menuSecenekler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picCizimAlani)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox _picCizimAlani;
        private System.Windows.Forms.Panel _pnlRenkSec;
        private System.Windows.Forms.Panel _pnlSecilenRenk;
        private System.Windows.Forms.TrackBar _trackbrKalinlik;
        private System.Windows.Forms.PictureBox _picDairePalet;
        private System.Windows.Forms.Panel _pnlRenkDikey;
        private System.Windows.Forms.Panel _pnlSil;
        private System.Windows.Forms.ContextMenuStrip _menuSecenekler;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog _dialogCalismaKaydet;
        private System.Windows.Forms.ToolStripMenuItem yükleToolStripMenuItem;
    }
}

