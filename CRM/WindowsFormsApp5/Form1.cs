using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        TicketsDataContext dc = new TicketsDataContext();
        List<UserControl1> TIL = new List<UserControl1>();
        public Form1()
        {
            InitializeComponent();
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Values = new ChartValues<double> {35},
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Values = new ChartValues<double> {22},
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Values = new ChartValues<double> {44},
                    LabelPoint = labelPoint
                },
            };
            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2015",
                    Values = new ChartValues<double> { 10, 50, 39,24}
                }
            };

            //adding series will update and animate the chart automatically
            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "2016",
                Values = new ChartValues<double> { 11, 56, 42 },
                StrokeThickness = 1
            });

            //also adding values updates and animates the chart automatically
            cartesianChart1.Series[1].Values.Add(48d);

            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[] { "Mar18", "Apr18", "May18" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Sold Apps",
                LabelFormatter = value => value.ToString("N")
            });
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var deg in dc.Tickets)
            {
                Yerlestir(deg.Kategori, deg.Baslik, deg.Oncelik, Convert.ToString(deg.Baslangic.Value), Convert.ToString(deg.Bitirme.Value), Convert.ToInt32(deg.Bekleme), Convert.ToInt32(deg.Durum));
            }
        }
        public void Yerlestir(string kat, string baslik, string prıority, string baslangic, string bitis, int age, int durum)
        {
            UserControl1 it = new UserControl1();
            it.labelkategori.Text = kat;
            it.labeltext.Text = baslik;
            if (prıority == "Low")
            {
                it.panel3.BackColor = Color.Silver;
                it.labelprority.ForeColor = Color.DarkGray;
            }
            else if (prıority == "Medium")
            {
                it.panel3.BackColor = Color.Orange;
                it.labelprority.ForeColor = Color.Gold;
            }
            else if (prıority == "High")
            {
                it.panel3.BackColor = Color.Violet;
                it.labelprority.ForeColor = Color.Purple;
            }
            else if (prıority == "Critical")
            {
                it.panel3.BackColor = Color.Red;
                it.labelprority.ForeColor = Color.White;
            }
            else
            {
                it.panel3.BackColor = Color.PaleGreen;
                it.labelprority.ForeColor = Color.Lime;
            }
            it.labelprority.Text = prıority;
            it.labelcreated.Text = baslangic;
            it.labeltarget.Text = bitis;
            it.labelage.Text = Convert.ToString(age);
            if (durum <= 25)
            {
                it.labelprogress.Text = "Waiting";
            }
            else if(durum>25 && durum <= 60)
            {
                it.labelprogress.Text = "Manager Approval";
            }
            else
            {
                it.labelprogress.Text = "Almost Done";
            }
            it.progressbar.Value = durum;
            it.Dock = DockStyle.Top;
            TIL.Add(it);
            panel6.Controls.Add(it);
        }
        private void label18_Click(object sender, EventArgs e)
        {

        }

    }
   
}

