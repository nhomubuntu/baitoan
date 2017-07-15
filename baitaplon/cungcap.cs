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
    public partial class cungcap : Form
    {
        public cungcap()
        {
            InitializeComponent();
        }
        DataTable cungcapds()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM cungcapds", Program.strConn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }

        private void cungcap_Load(object sender, EventArgs e)
        {
            dgcungcap.DataSource = cungcapds();
        }
        void themcungcap(string MACC, string MANCC, string MAMH, int SOLUONG, float GIACC)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO cungcapds VALUES('" + MACC + "','" + MANCC + "','" + MAMH + "','" + SOLUONG + "','" + GIACC + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themcungcap(txtmacc.Text, cbncc.Text, cbmh.Text, int.Parse(txtsoluong.Text), float.Parse(txtgiacc.Text));
            dgcungcap.DataSource = cungcapds();
        }
        void xoacungcap(string MACC)
        {

            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM cungcapds WHERE MACC='" + MACC + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmacc.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM cungcapds WHERE MACC='" + txtmacc.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgcungcap.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void suacungcap(string MACC, string MANCC, string MAMH, int SOLUONG, float GIACC)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE cungcapds SET MACC= '" + txtmacc.Text + "',MANCC='" + cbncc.Text + "',MAMH='" + cbmh.Text + "',SOLUONG='" + txtsoluong.Text + "',GIACC='" + txtgiacc.Text + "'WHERE MACC='" + txtmacc.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmacc.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE cungcapds SET MACC= '" + txtmacc.Text + "',MANCC='" + cbncc.Text + "',MAMH='" + cbmh.Text + "',SOLUONG='" + txtsoluong.Text + "',GIACC='" + txtgiacc.Text + "'WHERE MACC='" + txtmacc.Text + "'";
                cmd.ExecuteNonQuery();

                connDB.Close();

                dgcungcap.DataSource = cungcapds();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void timkiemcungcap(string MACC, string MANCC, string MAMH, int SOLUONG, float GIACC)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "select * from cungcapds where MACC= '" + txtmacc.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txtmacc.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from cungcapds where MACC= '" + txtmacc.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgcungcap.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



    }
}
