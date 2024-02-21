using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanWpa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama;
            decimal usia;
            string tinggi;
            int total_tinggi;

            nama = textBox1.Text;
            usia = numericUpDown1.Value;
            tinggi = textBox2.Text;
            total_tinggi = int.Parse(tinggi) + 5;

            MessageBox.Show("Hallo " + nama + " usia kamu " + usia + " total tinggi kamu " + total_tinggi);
        }
    }
}
