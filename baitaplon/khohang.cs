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
    public partial class khohang : Form
    {
        public khohang()
        {
            InitializeComponent();
        }
        DataTable khohangds()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM khohangds", Program.strConn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }

        private void khohang_Load(object sender, EventArgs e)
        {
            dgkhohang.DataSource = khohangds();
        }
        void themkhohang(string MAMH,int SOLUONG)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO khohangds VALUES('" + MAMH + "','" + SOLUONG + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themkhohang(txtmamh.Text, int.Parse(txtsoluong.Text));
            dgkhohang.DataSource = khohangds();
        }
        void xoakhohang(string MAMH)
        {

            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM khohangds WHERE MAMH='" + MAMH + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmamh.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM khohangds WHERE MAMH='" + txtmamh.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgkhohang.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void suakhohang(string MAMH, int SOLUONG)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE khohangds SET MAMH= '" + txtmamh.Text + "',SOLUONG='" + txtsoluong.Text + "'WHERE MAMH='"+txtmamh.Text+"'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmamh.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE khohangds SET MAMH= '" + txtmamh.Text + "',SOLUONG='" + txtsoluong.Text + "'WHERE MAMH='" + txtmamh.Text + "'";
                cmd.ExecuteNonQuery();

                connDB.Close();

                dgkhohang.DataSource = khohangds();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void timkiemkhohang(string MAMH, int SOLUONG)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "select * from khohangds where MAMH= '" + txtmamh.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txtmamh.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from khohangds where MAMH= '" + txtmamh.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgkhohang.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
