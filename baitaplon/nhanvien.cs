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
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
        }
        DataTable nhanviends()
        {
            SqlDataAdapter da = new SqlDataAdapter ("SELECT * FROM nhanviends", Program.strConn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }

        private void nhanvien_Load(object sender, EventArgs e)
        {
            dgnhanvien.DataSource = nhanviends();
        }
        void themnhanvien(string MANV, string TENNV, string DIACHINV, string DIENTHOAINV, float LUONG)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO nhanviends VALUES('" + MANV + "',N'" + TENNV + "',N'" + DIACHINV + "',N'" + DIENTHOAINV + "',N'" + LUONG + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themnhanvien(cbma.Text,txttennv.Text,txtdiachinv.Text,txtdienthoainv.Text,float.Parse(txtluong.Text));
            dgnhanvien.DataSource = nhanviends();
        }
        void xoanhanvien(string MANV)
        {

            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM nhanviends WHERE MANV='" + MANV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (cbma.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM nhanviends WHERE MANV='" + cbma.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgnhanvien.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void suanhanvien(string MANV, string TENNV, string DIACHINV, string DIENTHOAINV, float LUONG)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE nhanviends SET MANV= '" + cbma.Text + "',TENNV='" + txttennv.Text + "',DIACHINV='" + txtdiachinv.Text + "',DIENTHOAINV='" + txtdienthoainv.Text + "',LUONG='" + float.Parse(txtluong.Text) + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (cbma.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE nhanviends SET MANV= '" + cbma.Text + "',TENNV='" + txttennv.Text + "',DIACHINV='" + txtdiachinv.Text + "',DIENTHOAINV='" + txtdienthoainv.Text + "',LUONG='" + txtluong.Text + "' WHERE MANV='" + cbma.Text + "'";
                cmd.ExecuteNonQuery();

                connDB.Close();

                dgnhanvien.DataSource = nhanviends();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void timkiemnhanvien (string MANV, string TENNV, string DIACHINV, string DIENTHOAINV,float LUONG)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "select * from nhanviends where MANV= '" + cbma.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbma.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from nhanviends where MANV= '" + cbma.Text + "'";
                cmd.ExecuteNonQuery();

                connDB.Close();

                dgnhanvien.DataSource = nhanviends();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
