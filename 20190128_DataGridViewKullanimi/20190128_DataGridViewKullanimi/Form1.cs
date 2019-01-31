using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190128_DataGridViewKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn sutun;
            DataRow satir;

            sutun = new DataColumn("Sira No");
            sutun.DataType = Type.GetType("System.Int32"); //sütunun tipi
            sutun.AutoIncrement = true; //sıra no otomatik artsın
            sutun.AutoIncrementSeed = 0; // 0'dan başlat
            sutun.AutoIncrementStep = 1; //kaçar kaçar artacağı
            dt.Columns.Add(sutun); //datagrid sütun eklendi

            sutun = new DataColumn("Ad Soyad");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun); //datagrid sütun eklendi

            sutun = new DataColumn("Ekleme Tarihi");
            sutun.DataType = Type.GetType("System.DateTime");
            dt.Columns.Add(sutun); //datagrid sütun eklendi

            sutun = new DataColumn("Adet");
            sutun.DataType = Type.GetType("System.Int32");
            dt.Columns.Add(sutun); //datagrid sütun eklendi

            sutun = new DataColumn("Birim Fiyat");
            sutun.DataType = Type.GetType("System.Int32");
            dt.Columns.Add(sutun); //datagrid sütun eklendi

            sutun = new DataColumn("Toplam");
            sutun.DataType = Type.GetType("System.Int32");
            dt.Columns.Add(sutun); //datagrid sütun eklendi
            sutun.Expression = "Adet * [Birim Fiyat]"; //adet ve birim fiyat sütunundaki değerleri toplayıp, toplam sütununa ekler

            _DBGridListele.DataSource = dt;

            satir = dt.NewRow();
            satir[1] = "Okan";
            satir["Ekleme Tarihi"] = "27.01.2019";
            satir[3] = 20;
            satir[4] = 2;
            dt.Rows.Add(satir);

            satir = dt.NewRow();
            satir[1] = "Ali";
            satir[2] = "28.01.2019";
            satir[3] = 30;
            satir[4] = 2;            
            dt.Rows.Add(satir);
        }

        private void _btnKaydet_Click(object sender, EventArgs e)
        {
            _xmlKaydet.DefaultExt = "xml";
            string xds;
            if (_xmlKaydet.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = (DataTable)_DBGridListele.DataSource;
                // Ram de DataGrid yapısının aynısından sanal bir tablo oluşturma
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                //uzantısını xds olarak değiştir
                xds = _xmlKaydet.FileName.Substring(_xmlKaydet.FileName.LastIndexOf("."));
                //oluştur
                xds = xds + ".xml";
                //xml şemaya dönüştür
                ds.WriteXmlSchema(xds);
            }


        }
    }
}
