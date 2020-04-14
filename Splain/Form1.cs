using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEeq {
  public partial class Form1 : Form {
    List<System.Windows.Forms.DataVisualization.Charting.Series> ret;
    List<double> x;
    List<double> y;
    List<double> z;
    double st_x;
    double end_x;
    double h;
    double yd;
    double a;

    int list_cap;
    int list_iter;
   

    public Form1() {
      InitializeComponent();
      
      ret = new List<System.Windows.Forms.DataVisualization.Charting.Series>();

      x = new List<double>();
      x.Add(0);
      y = new List<double>();
      y.Add(0);
      z = new List<double>();
      z.Add(0);

      st_x = 0;
      end_x = 0;
      h = 0.1;
      yd = 0;
      a = 0;


      chart1.ChartAreas[0].AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
      chart1.ChartAreas[0].AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;

    }

    private void generateToolStripMenuItem_Click(object sender, EventArgs e) {
      if (list_iter == list_cap) {
        ret.Add(chart1.Series.Add("Series " + list_cap.ToString()));
        ret[list_iter].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        ret[list_iter].IsVisibleInLegend = false;
        ++list_cap;
      }

      Runge_Kutt(x[0], end_x, h);
      for(int i = 0; i < x.Count(); ++i) {
          chart1.Series[list_iter].Points.AddXY(y[i], z[i]);
      }

      double tmp_x = x[0];
      double tmp_y = y[0];
      double tmp_z = z[0];
      x.Clear();
      y.Clear();
      z.Clear();
      x.Add(tmp_x);
      y.Add(tmp_y);
      z.Add(tmp_z);
      ++list_iter;
    }


    void Runge_Kutt(double t0, double t1, double h) {
      int i = 0;
      while (t0 < t1 - h) {
        double k1 = h * z[i];
        double l1 = h * func(a, x[i], y[i], z[i]);
        double k2 = h * (z[i] + l1 / 2);
        double l2 = h * func(a, x[i] + h /2, y[i] + k1 / 2, z[i] + l1 / 2);
        double k3 = h * (z[i] + l2 / 2);
        double l3 = h * func(a, x[i] + h /2, y[i] + k2 / 2, z[i] + l2 / 2);
        double k4 = h * (z[i] + l3);
        double l4 = h * func(a, x[i] + h, y[i] + k3, z[i] + l3);
        x.Add(x[i] + h);
        y.Add(y[i] + (k1 + 2 * k2 + 2 * k3 + k4) / 6);
        z.Add(z[i] + (l1 + 2 * l2 + 2 * l3 + l4) / 6);
        ++i; 
        t0 += h;
      }
    }

    double func(double d, double x_0, double y_0, double z_0) {
      return (- a * z_0 - Math.Sin(y_0));
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
      if(textBox1.Text != "-" && textBox1.Text != "")
        x[0] = double.Parse(textBox1.Text);
    }

    private void textBox3_TextChanged(object sender, EventArgs e) {
      if (textBox3.Text != "-" && textBox3.Text != "")
        end_x = double.Parse(textBox3.Text);
    }

    private void textBox7_TextChanged(object sender, EventArgs e) {
      if (textBox7.Text != "-" && textBox7.Text != "")
        y[0] = double.Parse(textBox7.Text);
    }

    private void textBox2_TextChanged(object sender, EventArgs e) {
      if (textBox2.Text != "-" && textBox2.Text != "")
        z[0] = double.Parse(textBox2.Text);
    }

    private void textBox4_TextChanged(object sender, EventArgs e) {
      if (textBox4.Text != "-" && textBox4.Text != "")
        h = double.Parse(textBox4.Text);
    }

    private void textBox6_TextChanged(object sender, EventArgs e) {
      if (textBox6.Text != "-" && textBox6.Text != "")
        a = double.Parse(textBox6.Text);
    }

    private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
      for (int i = 0; i < list_cap; ++i)
        ret[i].Points.Clear();
      list_iter = 0;
      double tmp_x = x[0];
      double tmp_y = y[0];
      double tmp_z = z[0];
      x.Clear();
      y.Clear();
      z.Clear();
      x.Add(tmp_x);
      y.Add(tmp_y);
      z.Add(tmp_z);
      ++list_iter;
    }
  }
}
