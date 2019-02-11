using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //

namespace Notificon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ntifyTepsiMenu.Text = "Notificon v0.1";
            _ntifyTepsiMenu.ContextMenu = _cntxtMenuTepsi;
            TextReader _dosya = File.OpenText("ayarlar.bat");            
            try
            {
                string _satir;
                while ((_satir = _dosya.ReadLine())!=null)
                {
                    _listeProgram.Items.Add(_satir);
                    _satir = _dosya.ReadLine();
                    _listeAdi.Items.Add(_satir);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Programlar okunamadı");
            }
            finally
            {
                _dosya.Close();
            }
        }

        private void _btnGizle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            //durumu sorgulama
            _ntifyTepsiMenu.Visible = !this.Visible;
        }

        private void _ntifyTepsiMenu_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        /// <summary>
        /// Form kapatılırken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextWriter _dosya = File.CreateText(Application.StartupPath + "ayarlar.dat");
            for (int i = 0; i < _listeAdi.Items.Count-1 ; i++)
            {
                _dosya.WriteLine(_listeAdi.Items[i]);
                _dosya.WriteLine(_listeProgram.Items[i]);
            }
            _dosya.Close();
        }

        private void _cntxtMenuTepsi_Popup(object sender, EventArgs e)
        {
            _cntxtMenuTepsi.MenuItems.Clear();


            for (int i = 0; i < _listeAdi.Items.Count; i++)
            {
                _cntxtMenuTepsi.MenuItems.Add(_listeAdi.Items[i].ToString(), new EventHandler(MenuTikla));


                _cntxtMenuTepsi.MenuItems.Add("-");
                _cntxtMenuTepsi.MenuItems.Add(menuItem1);
                _cntxtMenuTepsi.MenuItems.Add(menuItem2);



            }
        }

        private void MenuTikla(object sender, EventArgs e)
        {
            //dosya yolu var mı yok mu? gelen değer menu item öğeseni mi değil mi
            string _dosya = _listeProgram.Items[(sender as MenuItem).Index-1].ToString(); //o sınıfın üyesi mi sender as
            try
            {
                System.Diagnostics.Process.Start(_dosya);
            }
            catch (Exception)
            {
                MessageBox.Show("Program Başlatılamadı");
                throw;
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            //formu göster
            this.Show();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void _btnEkle_Click(object sender, EventArgs e)
        {
            _listeAdi.Items.Add(_txtDosyaAdi.Text);
            _listeProgram.Items.Add(_txtDosyaYolu.Text);


        }

        private void _btnSil_Click(object sender, EventArgs e)
        {
            int _sec = _listeAdi.SelectedIndex;
            if (_sec < 0)
            {
                MessageBox.Show("Bir program seçmelisiniz");
            }
            else
            {
                _listeAdi.Items.RemoveAt(_sec);
                _listeProgram.Items.RemoveAt(_sec);
            }
        }

        private void _btnGozat_Click(object sender, EventArgs e)
        {
            _dialogDosyaAc.Filter = "Program dosyaları|*.exe;*.com;*.dat|" + "Bütün Dosyalar|.*.*";
            if (_dialogDosyaAc.ShowDialog()==DialogResult.OK)
            {
                //dosya adını textboxa yaz
                _txtDosyaAdi.Text = _dialogDosyaAc.FileName;
                _txtDosyaYolu.Text = Path.GetFileNameWithoutExtension(_dialogDosyaAc.FileName); //uzantısı hariç ismini al                
            }
        }

        
    }
}
