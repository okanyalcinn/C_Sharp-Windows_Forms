using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D; // HatchBrush için bu kütüphaneyi ağırıyoruz

namespace _20190129_Cizim_Brush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _cmbSecim.Items.Add("SolidBrush");
            _cmbSecim.Items.Add("HatchBrush");
            _cmbSecim.Items.Add("LinearGradientBrush");
            _cmbSecim.Items.Add("PathGradientBrush");
            _cmbSecim.Items.Add("TextureBrush");
            _cmbSecim.SelectedIndex = 0;
        }
        Brush brush;
        Graphics graphics;
        Random r = new Random();
        private void _btnDikdortgen_Click(object sender, EventArgs e)
        {            
            graphics = this.CreateGraphics();
            graphics.FillRectangle(brush,r.Next(200), r.Next(200), r.Next(200), r.Next(200));
        }

        private void _cmbSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color1;
            Color color2;
            color1 = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255), r.Next(255));
            color2 = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255), r.Next(255));

            switch (_cmbSecim.SelectedIndex)
            {
                case 0:
                    brush = new SolidBrush(color1);
                    break;
                case 1:
                    graphics.Clear(this.BackColor); // bunu seçince. önce tuvali temizleyecek
                    brush = new HatchBrush((HatchStyle)r.Next(50), color1);
                    break;
                case 2:
                    brush = new LinearGradientBrush(new Point(r.Next(200), r.Next(200)), new Point(r.Next(200), r.Next(200)),color1,color2);
                    break;
                case 3:
                    Form1 form1 = new Form1();
                    //form1.PointToScreen(p);

                    Point[] p = new Point[2];
                    p[0] = new Point(r.Next(200), r.Next(200));
                    p[1] = new Point(r.Next(200), r.Next(200));
                    brush = new PathGradientBrush(p);
                    ((PathGradientBrush)brush).CenterColor = color1;
                    ((PathGradientBrush)brush).CenterPoint = new PointF(r.Next(200), r.Next(200));
                    break;

                default:
                    break;
            }
        }

        private void _btnTemizle_Click(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            graphics.Clear(this.BackColor); //arka plan(Tuval) temizleme
        }

        private void _btnElips_Click(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            graphics.Clear(this.BackColor);
            graphics.FillEllipse(brush, r.Next(200), r.Next(200), r.Next(200), r.Next(200));
        }

        private void _btnYaziEkle_Click(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            graphics.Clear(this.BackColor);
            graphics.DrawString("Efsana - SmartPro 32", new Font("Thoma", 30, FontStyle.Bold),brush, r.Next(200), r.Next(200));
        }
    }
}
