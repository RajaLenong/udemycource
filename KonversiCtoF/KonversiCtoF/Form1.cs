using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonversiCtoF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temperatur = textBox1.Text;
            double konversi = Convert.ToDouble(temperatur);
            double rumus_c_to_f = (konversi * 1.8) + 32;
            label3.Text = rumus_c_to_f.ToString() + " F";
        }
    }
}
