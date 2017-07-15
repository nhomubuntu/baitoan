using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phanloai frm = new phanloai();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mathang frm = new mathang();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            khohang frm = new khohang();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nhanvien frm = new nhanvien();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nhacungcap frm = new nhacungcap();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cungcap frm = new cungcap();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            khachhang frm = new khachhang();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dshoadon frm = new dshoadon();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chitiethoadon frm = new chitiethoadon();
            frm.Show();
        }
    }
}
