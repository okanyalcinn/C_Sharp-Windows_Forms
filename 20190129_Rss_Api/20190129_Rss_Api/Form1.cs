using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; // xml için kütüphane
using _20190129_Rss_Api.Model; // klasör bağlantısı

namespace _20190129_Rss_Api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<HaberModel> haber_Listem = new List<HaberModel>();

        //bu aderesten çekiyoruz https://www.cnnturk.com/feed/rss/news

        private void _btnHaberlerCek_Click(object sender, EventArgs e)
        {
            _lstBaslik.Items.Clear();// her butona basışında önceki haberleri listeden silmek için
            foreach (var item in haber_Listem)
            {
                _lstBaslik.Items.Add(item.title);
            }
        }

        XmlReader okuyucu;
        List<string> listem = new List<string>();

        void DegerOku(XmlReader okuyucu)
        {
            if (okuyucu.Read())
            {
                listem.Add(okuyucu.Value.Trim());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region okuma
            using (okuyucu = XmlReader.Create("https://www.cnnturk.com/feed/rss/news"))
            {
                while (okuyucu.Read())
                {
                    if (okuyucu.IsStartElement())
                    {
                        HaberModel habermodel = new HaberModel();
                        switch (okuyucu.Name)
                        {
                            case "link":
                                DegerOku(okuyucu);
                                break;
                            case "title":
                                DegerOku(okuyucu);
                                break;
                            case "description":
                                DegerOku(okuyucu);
                                break;
                            case "pubDate":
                                DegerOku(okuyucu);
                                break;
                            case "image":
                                DegerOku(okuyucu);
                                break;
                            default:
                                break;
                        }

                    }
                }
            }
            #endregion
            //rss sayfasındaki ilk 6 elemanı silicez. sadece haber başlıklarını almak için
            string[] nesne = new string[listem.Count - 6];
            //bu foreach xml meta bilgilerini siler. sadece haber başlıklarımız görünsün diye
            int i = 0;
            foreach (var item in listem.Skip(6))
            {
                nesne[i] = item;
                i++;
            }
            for (int k = 0; k < nesne.Length; k+=5)
            {
                HaberModel haber = new HaberModel();
                haber.link = nesne[k];
                haber.title = nesne[k + 1];
                haber.description = nesne[k + 2];
                haber.pubDate = Convert.ToDateTime(nesne[k + 3]);
                haber.image = nesne[k + 4];
                haber_Listem.Add(haber);
            }
        }

        private void _lstBaslik_SelectedIndexChanged(object sender, EventArgs e)
        {           
            foreach (var item in haber_Listem)
            {
                if (_lstBaslik.SelectedIndex == 0) //(_lstBaslik.SelectedItem.Tostring()==item.title)//detay gözükmesi için hoca denedi tam olmadı
                {                   
                    _txtDetay.Text = (item.description);
                }               
            } _txtDetay.Text = "";
        }
    }
}
