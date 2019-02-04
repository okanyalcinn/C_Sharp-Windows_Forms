using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //file

namespace Path_YolBilgileri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            if (_openFileDialog1.ShowDialog()==DialogResult.OK) 
            {
                string yol = _openFileDialog1.FileName;
                _listPath.Items.Add("Bulunduğu klasör: "+Path.GetDirectoryName(yol)); // getDirectoryName → c klasörü 

                _listPath.Items.Add("Dosya Adı: " + Path.GetFileName(yol));

                _listPath.Items.Add("Uzantısı: " + Path.GetExtension(yol));

                _listPath.Items.Add("Uzantısız Dosya Adı: " + Path.GetFileNameWithoutExtension(yol));

                _listPath.Items.Add("Tam yolu: " + Path.GetFullPath(yol));

                _listPath.Items.Add("Kök dizini: " + Path.GetPathRoot(yol));

                _listPath.Items.Add("Yol içinde kök klasör yazılı mı: " + Path.IsPathRooted(yol));

                _listPath.Items.Add("Dosya Uzantısı var mı? " + Path.HasExtension(yol));

            }
        }
    }
}
