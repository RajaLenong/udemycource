using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int angka1;
            int angka2;
            int hasil;

            angka1 = 10;
            angka2 = 5;
            hasil = (angka1 + angka2);

            MessageBox.Show("Hasil dari " + angka1.ToString() + " ditambah " + angka2.ToString() + " adalah " + hasil.ToString());
        }
    }
}
