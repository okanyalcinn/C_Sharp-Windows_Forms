using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace OgrenciKayit
{
    public partial class OgrenciListele : Form
    {
        public OgrenciListele()
        {
            InitializeComponent();
        }
        SqlConnection _baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString); //baglanti ConnectionString i hafızada tutuyor
        SqlCommand _komut;
        SqlDataAdapter _sqlDtadptr;
        private void OgrenciListele_Load(object sender, EventArgs e)
        {
            _baglanti.Open();
            //sql adapter disconnect
            _sqlDtadptr = new SqlDataAdapter("Select * from Ogrenciler", _baglanti);
            DataTable _dTable = new DataTable();
            _sqlDtadptr.Fill(_dTable);

            //verileri data grice viewe yükeleme 
            _dtview.DataSource = _dTable;
            _baglanti.Close();
        }
    }
}
