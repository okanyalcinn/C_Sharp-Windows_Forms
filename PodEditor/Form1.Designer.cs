namespace PodEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farkliKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yazdirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baskiOnizlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yineleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümünüYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tumunuSecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalınToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altıÇiziliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.üstSimgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altSimgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.fontSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paragrafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sağaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.maddeİşaretiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podCastCvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icindekilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dizinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.hakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this._cmbZoom = new System.Windows.Forms.ComboBox();
            this._cmbRenk = new System.Windows.Forms.ComboBox();
            this._cmbBoyut = new System.Windows.Forms.ComboBox();
            this._cmbYaziTip = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._btnUstA = new System.Windows.Forms.Button();
            this._btnAltC = new System.Windows.Forms.Button();
            this._btnAltB = new System.Windows.Forms.Button();
            this._progIslem = new System.Windows.Forms.ProgressBar();
            this._richMetin = new System.Windows.Forms.RichTextBox();
            this._opnDosyaAc = new System.Windows.Forms.OpenFileDialog();
            this._saveDosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.yazıTipiToolStripMenuItem,
            this.paragrafToolStripMenuItem,
            this.podCastCvToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.acToolStripMenuItem,
            this.toolStripSeparator,
            this.kaydetToolStripMenuItem,
            this.farkliKaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.yazdirToolStripMenuItem,
            this.baskiOnizlemeToolStripMenuItem,
            this.toolStripSeparator2,
            this.cikisToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";            
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniToolStripMenuItem.Image")));
            this.yeniToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniToolStripMenuItem.Text = "Y&eni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acToolStripMenuItem.Image")));
            this.acToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.acToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acToolStripMenuItem.Text = "&Aç";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kaydetToolStripMenuItem.Image")));
            this.kaydetToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "&Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farkliKaydetToolStripMenuItem
            // 
            this.farkliKaydetToolStripMenuItem.Name = "farkliKaydetToolStripMenuItem";
            this.farkliKaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.farkliKaydetToolStripMenuItem.Text = "&Farklı Kaydet";
            this.farkliKaydetToolStripMenuItem.Click += new System.EventHandler(this.farkliKaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // yazdirToolStripMenuItem
            // 
            this.yazdirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yazdirToolStripMenuItem.Image")));
            this.yazdirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yazdirToolStripMenuItem.Name = "yazdirToolStripMenuItem";
            this.yazdirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.yazdirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yazdirToolStripMenuItem.Text = "Y&azdır";
            // 
            // baskiOnizlemeToolStripMenuItem
            // 
            this.baskiOnizlemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("baskiOnizlemeToolStripMenuItem.Image")));
            this.baskiOnizlemeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.baskiOnizlemeToolStripMenuItem.Name = "baskiOnizlemeToolStripMenuItem";
            this.baskiOnizlemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.baskiOnizlemeToolStripMenuItem.Text = "&Baskı Önizleme";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cikisToolStripMenuItem.Text = "Çı&kış";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.yineleToolStripMenuItem,
            this.toolStripSeparator3,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapistirToolStripMenuItem,
            this.toolStripSeparator4,
            this.bulToolStripMenuItem,
            this.silToolStripMenuItem,
            this.tümünüYenileToolStripMenuItem,
            this.tumunuSecToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "D&üzen";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.geriAlToolStripMenuItem.Text = "&Geri Al";
            // 
            // yineleToolStripMenuItem
            // 
            this.yineleToolStripMenuItem.Name = "yineleToolStripMenuItem";
            this.yineleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.yineleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yineleToolStripMenuItem.Text = "Yi&nele";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kesToolStripMenuItem.Image")));
            this.kesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kesToolStripMenuItem.Text = "&Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kopyalaToolStripMenuItem.Image")));
            this.kopyalaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kopyalaToolStripMenuItem.Text = "K&opyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapistirToolStripMenuItem
            // 
            this.yapistirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yapistirToolStripMenuItem.Image")));
            this.yapistirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yapistirToolStripMenuItem.Name = "yapistirToolStripMenuItem";
            this.yapistirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapistirToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yapistirToolStripMenuItem.Text = "&Yapıştır";
            this.yapistirToolStripMenuItem.Click += new System.EventHandler(this.yapistirToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // bulToolStripMenuItem
            // 
            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            this.bulToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.bulToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.bulToolStripMenuItem.Text = "Bul";
            this.bulToolStripMenuItem.Click += new System.EventHandler(this.bulToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // tümünüYenileToolStripMenuItem
            // 
            this.tümünüYenileToolStripMenuItem.Name = "tümünüYenileToolStripMenuItem";
            this.tümünüYenileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tümünüYenileToolStripMenuItem.Text = "Tümünü Yenile";
            this.tümünüYenileToolStripMenuItem.Click += new System.EventHandler(this.tümünüYenileToolStripMenuItem_Click);
            // 
            // tumunuSecToolStripMenuItem
            // 
            this.tumunuSecToolStripMenuItem.Name = "tumunuSecToolStripMenuItem";
            this.tumunuSecToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tumunuSecToolStripMenuItem.Text = "&Tümünü Seç";
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalınToolStripMenuItem,
            this.eğikToolStripMenuItem,
            this.altıÇiziliToolStripMenuItem,
            this.toolStripSeparator6,
            this.üstSimgeToolStripMenuItem,
            this.altSimgeToolStripMenuItem,
            this.toolStripSeparator7,
            this.fontSeçToolStripMenuItem,
            this.renkSeçToolStripMenuItem});
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi";
            // 
            // kalınToolStripMenuItem
            // 
            this.kalınToolStripMenuItem.Name = "kalınToolStripMenuItem";
            this.kalınToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.kalınToolStripMenuItem.Text = "Kalın";
            this.kalınToolStripMenuItem.Click += new System.EventHandler(this.kalınToolStripMenuItem_Click);
            // 
            // eğikToolStripMenuItem
            // 
            this.eğikToolStripMenuItem.Name = "eğikToolStripMenuItem";
            this.eğikToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.eğikToolStripMenuItem.Text = "Eğik";
            this.eğikToolStripMenuItem.Click += new System.EventHandler(this.eğikToolStripMenuItem_Click);
            // 
            // altıÇiziliToolStripMenuItem
            // 
            this.altıÇiziliToolStripMenuItem.Name = "altıÇiziliToolStripMenuItem";
            this.altıÇiziliToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.altıÇiziliToolStripMenuItem.Text = "Altı Çizili";
            this.altıÇiziliToolStripMenuItem.Click += new System.EventHandler(this.altıÇiziliToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(124, 6);
            // 
            // üstSimgeToolStripMenuItem
            // 
            this.üstSimgeToolStripMenuItem.Name = "üstSimgeToolStripMenuItem";
            this.üstSimgeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.üstSimgeToolStripMenuItem.Text = "Üst Simge";
            this.üstSimgeToolStripMenuItem.Click += new System.EventHandler(this.üstSimgeToolStripMenuItem_Click);
            // 
            // altSimgeToolStripMenuItem
            // 
            this.altSimgeToolStripMenuItem.Name = "altSimgeToolStripMenuItem";
            this.altSimgeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.altSimgeToolStripMenuItem.Text = "Alt Simge";
            this.altSimgeToolStripMenuItem.Click += new System.EventHandler(this.altSimgeToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(124, 6);
            // 
            // fontSeçToolStripMenuItem
            // 
            this.fontSeçToolStripMenuItem.Name = "fontSeçToolStripMenuItem";
            this.fontSeçToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.fontSeçToolStripMenuItem.Text = "font Seç";
            // 
            // renkSeçToolStripMenuItem
            // 
            this.renkSeçToolStripMenuItem.Name = "renkSeçToolStripMenuItem";
            this.renkSeçToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.renkSeçToolStripMenuItem.Text = "Renk Seç";
            // 
            // paragrafToolStripMenuItem
            // 
            this.paragrafToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solaToolStripMenuItem,
            this.sağaToolStripMenuItem1,
            this.sağaToolStripMenuItem,
            this.toolStripSeparator8,
            this.maddeİşaretiToolStripMenuItem});
            this.paragrafToolStripMenuItem.Name = "paragrafToolStripMenuItem";
            this.paragrafToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.paragrafToolStripMenuItem.Text = "Paragraf";
            // 
            // solaToolStripMenuItem
            // 
            this.solaToolStripMenuItem.Name = "solaToolStripMenuItem";
            this.solaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.solaToolStripMenuItem.Text = "Sola";
            this.solaToolStripMenuItem.Click += new System.EventHandler(this.solaToolStripMenuItem_Click);
            // 
            // sağaToolStripMenuItem1
            // 
            this.sağaToolStripMenuItem1.Name = "sağaToolStripMenuItem1";
            this.sağaToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.sağaToolStripMenuItem1.Text = "Sağa";
            this.sağaToolStripMenuItem1.Click += new System.EventHandler(this.sağaToolStripMenuItem1_Click);
            // 
            // sağaToolStripMenuItem
            // 
            this.sağaToolStripMenuItem.Name = "sağaToolStripMenuItem";
            this.sağaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sağaToolStripMenuItem.Text = "Ortala";
            this.sağaToolStripMenuItem.Click += new System.EventHandler(this.sağaToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(142, 6);
            // 
            // maddeİşaretiToolStripMenuItem
            // 
            this.maddeİşaretiToolStripMenuItem.Name = "maddeİşaretiToolStripMenuItem";
            this.maddeİşaretiToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.maddeİşaretiToolStripMenuItem.Text = "Madde İşareti";
            this.maddeİşaretiToolStripMenuItem.Click += new System.EventHandler(this.maddeİşaretiToolStripMenuItem_Click);
            // 
            // podCastCvToolStripMenuItem
            // 
            this.podCastCvToolStripMenuItem.Name = "podCastCvToolStripMenuItem";
            this.podCastCvToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.podCastCvToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.podCastCvToolStripMenuItem.Text = "Pod&CastCv";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.icindekilerToolStripMenuItem,
            this.dizinToolStripMenuItem,
            this.araToolStripMenuItem,
            this.toolStripSeparator5,
            this.hakkindaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "&Yardım";
            // 
            // icindekilerToolStripMenuItem
            // 
            this.icindekilerToolStripMenuItem.Name = "icindekilerToolStripMenuItem";
            this.icindekilerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.icindekilerToolStripMenuItem.Text = "İçi&ndekiler";
            // 
            // dizinToolStripMenuItem
            // 
            this.dizinToolStripMenuItem.Name = "dizinToolStripMenuItem";
            this.dizinToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dizinToolStripMenuItem.Text = "Di&zin";
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.araToolStripMenuItem.Text = "A&ra";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(130, 6);
            // 
            // hakkindaToolStripMenuItem
            // 
            this.hakkindaToolStripMenuItem.Name = "hakkindaToolStripMenuItem";
            this.hakkindaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.hakkindaToolStripMenuItem.Text = "&Hakkında...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._cmbZoom);
            this.panel1.Controls.Add(this._cmbRenk);
            this.panel1.Controls.Add(this._cmbBoyut);
            this.panel1.Controls.Add(this._cmbYaziTip);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 32);
            this.panel1.TabIndex = 1;
            // 
            // _cmbZoom
            // 
            this._cmbZoom.FormattingEnabled = true;
            this._cmbZoom.Location = new System.Drawing.Point(532, 6);
            this._cmbZoom.Name = "_cmbZoom";
            this._cmbZoom.Size = new System.Drawing.Size(82, 21);
            this._cmbZoom.TabIndex = 8;
            this._cmbZoom.TextChanged += new System.EventHandler(this._cmbZoom_TextChanged);
            // 
            // _cmbRenk
            // 
            this._cmbRenk.FormattingEnabled = true;
            this._cmbRenk.Location = new System.Drawing.Point(366, 6);
            this._cmbRenk.Name = "_cmbRenk";
            this._cmbRenk.Size = new System.Drawing.Size(82, 21);
            this._cmbRenk.TabIndex = 7;
            this._cmbRenk.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._cmbRenk_DrawItem);
            this._cmbRenk.SelectedIndexChanged += new System.EventHandler(this._cmbRenk_SelectedIndexChanged);
            // 
            // _cmbBoyut
            // 
            this._cmbBoyut.FormattingEnabled = true;
            this._cmbBoyut.Location = new System.Drawing.Point(211, 6);
            this._cmbBoyut.Name = "_cmbBoyut";
            this._cmbBoyut.Size = new System.Drawing.Size(82, 21);
            this._cmbBoyut.TabIndex = 6;
            this._cmbBoyut.SelectedIndexChanged += new System.EventHandler(this._cmbBoyut_SelectedIndexChanged);
            // 
            // _cmbYaziTip
            // 
            this._cmbYaziTip.FormattingEnabled = true;
            this._cmbYaziTip.Location = new System.Drawing.Point(65, 6);
            this._cmbYaziTip.Name = "_cmbYaziTip";
            this._cmbYaziTip.Size = new System.Drawing.Size(82, 21);
            this._cmbYaziTip.TabIndex = 5;
            this._cmbYaziTip.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._cmbYaziTip_DrawItem);
            this._cmbYaziTip.SelectedIndexChanged += new System.EventHandler(this._cmbYaziTip_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zoom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Renk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Boyut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yazı Tipi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._btnUstA);
            this.panel2.Controls.Add(this._btnAltC);
            this.panel2.Controls.Add(this._btnAltB);
            this.panel2.Controls.Add(this._progIslem);
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 86);
            this.panel2.TabIndex = 2;
            // 
            // _btnUstA
            // 
            this._btnUstA.Image = ((System.Drawing.Image)(resources.GetObject("_btnUstA.Image")));
            this._btnUstA.Location = new System.Drawing.Point(37, 3);
            this._btnUstA.Name = "_btnUstA";
            this._btnUstA.Size = new System.Drawing.Size(22, 26);
            this._btnUstA.TabIndex = 3;
            this._btnUstA.UseVisualStyleBackColor = true;
            this._btnUstA.MouseMove += new System.Windows.Forms.MouseEventHandler(this._btnUstA_MouseMove);
            // 
            // _btnAltC
            // 
            this._btnAltC.Image = ((System.Drawing.Image)(resources.GetObject("_btnAltC.Image")));
            this._btnAltC.Location = new System.Drawing.Point(608, 51);
            this._btnAltC.Name = "_btnAltC";
            this._btnAltC.Size = new System.Drawing.Size(22, 26);
            this._btnAltC.TabIndex = 2;
            this._btnAltC.UseVisualStyleBackColor = true;
            this._btnAltC.MouseMove += new System.Windows.Forms.MouseEventHandler(this._btnAltC_MouseMove);
            // 
            // _btnAltB
            // 
            this._btnAltB.Image = ((System.Drawing.Image)(resources.GetObject("_btnAltB.Image")));
            this._btnAltB.Location = new System.Drawing.Point(37, 51);
            this._btnAltB.Name = "_btnAltB";
            this._btnAltB.Size = new System.Drawing.Size(22, 26);
            this._btnAltB.TabIndex = 1;
            this._btnAltB.UseVisualStyleBackColor = true;
            this._btnAltB.MouseMove += new System.Windows.Forms.MouseEventHandler(this._btnAltB_MouseMove);
            // 
            // _progIslem
            // 
            this._progIslem.Location = new System.Drawing.Point(37, 35);
            this._progIslem.Name = "_progIslem";
            this._progIslem.Size = new System.Drawing.Size(593, 10);
            this._progIslem.TabIndex = 0;
            // 
            // _richMetin
            // 
            this._richMetin.Location = new System.Drawing.Point(12, 176);
            this._richMetin.Name = "_richMetin";
            this._richMetin.Size = new System.Drawing.Size(646, 222);
            this._richMetin.TabIndex = 3;
            this._richMetin.Text = "";
            // 
            // _opnDosyaAc
            // 
            this._opnDosyaAc.FileName = "_opnDosyaAc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 410);
            this.Controls.Add(this._richMetin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pod Editör v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farkliKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yazdirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baskiOnizlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yineleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tumunuSecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem icindekilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dizinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem hakkindaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podCastCvToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox _cmbZoom;
        private System.Windows.Forms.ComboBox _cmbRenk;
        private System.Windows.Forms.ComboBox _cmbBoyut;
        private System.Windows.Forms.ComboBox _cmbYaziTip;
        private System.Windows.Forms.Button _btnAltB;
        private System.Windows.Forms.ProgressBar _progIslem;
        private System.Windows.Forms.Button _btnUstA;
        private System.Windows.Forms.Button _btnAltC;
        private System.Windows.Forms.RichTextBox _richMetin;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalınToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altıÇiziliToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem üstSimgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altSimgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem fontSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paragrafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem maddeİşaretiToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog _opnDosyaAc;
        private System.Windows.Forms.SaveFileDialog _saveDosyaKaydet;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümünüYenileToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem bulToolStripMenuItem;
    }
}

