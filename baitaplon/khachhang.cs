using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class khachhang : Form
    {
        public khachhang()
        {
            InitializeComponent();
        }
        DataTable khachhangds()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM khachhangds", Program.strConn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
       
        void themkhachhang( string MAKH, string TENKH, string DIACHIKH, string DIENTHOAIKH )
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO khachhangds VALUES('" + MAKH + "',N'" + TENKH + "',N'" + DIACHIKH + "',N'" + DIENTHOAIKH + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            dgkhachhang.DataSource = khachhangds();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themkhachhang(txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtdienthoai.Text);
            dgkhachhang.DataSource = khachhangds();
        }
        void xoakhachhang(string MAKH)
        {

            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM khachhangds WHERE MAHD='" + MAKH + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM khachhangds WHERE MAKH='" + txtmakh.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgkhachhang.DataSource = dt;

                connDB.Close();
            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void suakhachhang(string MAKH, string TENKH, string DIACHIKH, string DIENTHOAIKH )
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE khachhangds SET MAKH= '" + txtmakh.Text + "',TENKH='" + txttenkh.Text + "',DIACHIKH='" + txtdiachi.Text + "',DIENTHOAIKH='" + txtdienthoai.Text + "' WHERE MAKH='"+MAKH+"'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE khachhangds SET MAKH= '" + txtmakh.Text + "',TENKH='" + txttenkh.Text + "',DIACHIKH='" + txtdiachi.Text + "',DIENTHOAIKH='" + txtdienthoai.Text + "'WHERE MAKH='" + txtmakh.Text + "'";
                cmd.ExecuteNonQuery();

                connDB.Close();

                dgkhachhang.DataSource = khachhangds();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void timkiemkhachhang(string MAKH, string TENKH, string DIACHIKH, string DIENTHOAIKH)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "select * from khachhangds where MAKH= '" + txtmakh.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

            if (txtmakh.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from khachhangds where MAKH= '" + txtmakh.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgkhachhang.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

    }
}
