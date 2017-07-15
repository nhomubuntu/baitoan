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
    public partial class nhacungcap : Form
    {
        public nhacungcap()
        {
            InitializeComponent();
        }
        DataTable nhacungcapds()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM nhacungcapds", Program.strConn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }

        private void nhacungcap_Load(object sender, EventArgs e)
        {
            dgnhacungcap.DataSource = nhacungcapds();
        }
        void themnhacungcap(string MANCC, string TENNCC, string DIACHINCC, string DIENTHOAINCC)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO nhacungcapds VALUES('" + MANCC + "',N'" + TENNCC + "','" + DIACHINCC + "','" + DIENTHOAINCC + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themnhacungcap(txtmancc.Text, txttenncc.Text, txtdiachi.Text, txtdienthoai.Text);
            dgnhacungcap.DataSource = nhacungcapds();
        }
        void xoanhacungcap(string MANCC)
        {

            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM nhacungcapds WHERE MANCC='" + MANCC + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (txtmancc.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM nhacungcapds WHERE MANCC='" + txtmancc.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgnhacungcap.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void suanhacungcap(string MANCC, string TENNCC, string DIACHINCC, string DIENTHOAINCC)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE nhacungcapds SET MANCC= '" + txtmancc.Text + "',TENNCC='" + txttenncc.Text + "',DIACHINCC='" + txtdiachi.Text + "',DIENTHOAINCC='" + txtdienthoai.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmancc.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE nhacungcapds SET MANCC= '" + txtmancc.Text + "',TENNCC='" + txttenncc.Text + "',DIACHINCC='" + txtdiachi.Text + "',DIENTHOAINCC='" + txtdienthoai.Text + "'WHERE MANCC='" + txtmancc.Text + "'";
                cmd.ExecuteNonQuery();

                connDB.Close();

                dgnhacungcap.DataSource = nhacungcapds();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void timkiemnhacungcap(string MANCC, string TENNCC, string DIACHINCC, string DIENTHOAINCC)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "select * from nhacungcapds where MANCC= '" + txtmancc.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

            if (txtmancc.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from nhacungcapds where MANCC= '" + txtmancc.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgnhacungcap.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
