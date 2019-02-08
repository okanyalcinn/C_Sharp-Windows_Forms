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
            _ntifyTepsiMenu.ContextMenuStrip = _cntxtNotMenu;
            TextReader _dosya = File.OpenText(Application.StartupPath + "ayarlar.dat");            
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
    }
}
