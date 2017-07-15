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
    public partial class mathang : Form
    {
        public mathang()
        {
            InitializeComponent();
        }
        DataTable mathangds()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM mathangds", Program.strConn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }

        private void mathang_Load(object sender, EventArgs e)
        {
            dgmathang.DataSource = mathangds();
        }
        void themmathang(string MAMH, string TENMH, string DVTINH, string MALOAI, float GIABAN )
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO mathangds VALUES('" + MAMH + "',N'" + TENMH + "','" + DVTINH + "','" + MALOAI + "','" + GIABAN + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themmathang(txtmamh.Text, txttenmh.Text, txtdv.Text, cbmaloai.Text, float.Parse(txtgiaban.Text));
            dgmathang.DataSource = mathangds();
        }
        void xoamathang(string MAMH)
        {

            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM mathangds WHERE MAMH='" + MAMH + "'";
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
                cmd.CommandText = "DELETE FROM mathangds WHERE MAHD='" + txtmamh.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgmathang.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void suamathang(string MAMH, string TENMH, string DVTINH, string MALOAI, float GIABAN )
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE mathangds SET MAMH= '" + txtmamh.Text + "',TENMH='" + txttenmh.Text + "',DVTINH='" + txtdv.Text + "',MALOAI='" +cbmaloai.Text + "',GIABAN='" + txtgiaban.Text + "'";
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
                cmd.CommandText = "UPDATE mathangds SET MAMH= '" + txtmamh.Text + "',TENMH='" + txttenmh.Text + "',DVTINH='" + txtdv.Text + "',MALOAI='" + cbmaloai.Text + "',GIABAN='" + txtgiaban.Text + "'WHERE MAMH ='"+txtmamh.Text+"'";
                cmd.ExecuteNonQuery();

                connDB.Close();

                dgmathang.DataSource = mathangds();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void timkiemmathang(string MAMH, string TENMH, string DVTINH, string MALOAI, float GIABAN )
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "select * from mathangds where MAMH= '" + txtmamh.Text + "'";
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
                cmd.CommandText = "select * from mathangds where MAMH= '" + txtmamh.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgmathang.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
    }
}
