using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            Calculation loc13 = new Calculation(a, b);
            kq = loc13.Execute("+");
            txtKq.Text = kq.ToString();
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {

        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {

        }

        private void buttonChia_Click(object sender, EventArgs e)
        {

        }
    }
}
