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
    public partial class chitiethoadon : Form
    {
        public chitiethoadon()
        {
            InitializeComponent();
        }
        DataTable chitiethoadonds()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM chitiethoadonds", Program.strConn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }

        private void chitiethoadon_Load(object sender, EventArgs e)
        {
            dgct.DataSource = chitiethoadonds();
        }
        void themcthoadon(string MAHD, string MAMH, float GIABAN, int SOLUONG, int GIAMGIA )
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO chitiethoadonds VALUES('" + MAHD + "','" + MAMH + "','" + GIABAN + "','" +SOLUONG + "','" + GIAMGIA + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themcthoadon(txtmahd.Text,cbmathang.Text, float.Parse(txtgia.Text), int.Parse(txtsoluong.Text), int.Parse(txtgiamgia.Text));
            dgct.DataSource = chitiethoadonds();
        }
        void xoacthoadon(string MAHD)
        {

            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM chitiethoadonds WHERE MAHD='" + MAHD + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM chitiethoadonds WHERE MAHD='" + txtmahd.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgct.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void suacthoadon(string MAHD, string MAMH, float GIABAN, int SOLUONG, int GIAMGIA)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE chitiethoadonds SET MAHD= '" + txtmahd.Text + "',MAMH='" + cbmathang.Text + "',GIABAN='" + txtgia.Text + "',SOLUONG='" + txtsoluong.Text + "',GIAMGIA='"+txtgiamgia.Text+"'WHERE MAHD='" + txtmahd.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            if (txtmahd.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE chitiethoadonds SET  MAHD= '" + txtmahd.Text + "',MAMH='" + cbmathang.Text + "',GIABAN='" + txtgia.Text + "',SOLUONG='" + txtsoluong.Text + "',GIAMGIA='"+txtgiamgia.Text+"'WHERE MAHD='" + txtmahd.Text + "'";
                cmd.ExecuteNonQuery();

                connDB.Close();

                dgct.DataSource = chitiethoadonds();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void timkiemcthoadon(string MAHD, string MAMH, float GIABAN, int SOLUONG, int GIAMGIA)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "select * from chitiethoadonds where MAHD= '" + txtmahd.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from chitiethoadonds where MAHD= '" + txtmahd.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgct.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


       
    }
}
