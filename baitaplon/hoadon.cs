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
    public partial class dshoadon : Form
    {
        public dshoadon()
        {
            InitializeComponent();
        }
        DataTable hoadonds()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM hoadonds", Program.strConn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        private void dshoadon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hoadonds();
        }
        void themhoadon(string MAHD, string MAKH, string NGAYLAP, string NGAYGIAO, string NOIGIAO, string MANV)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO hoadonds VALUES(N'" + MAHD + "',N'" + MAKH + "','" + NGAYLAP + "','" + NGAYGIAO + "',N'" + NOIGIAO + "',N'"+MANV+"')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            themhoadon(txtma.Text, cbkhachhang.Text, txtngaylap.Text,txtngaygiao.Text,txtnoigiao.Text,cbnhanvien.Text);
            dgvHoaDon.DataSource = hoadonds();
        }

        //private void themhoadon(string p, string p_2, string p_3, string p_4, string p_5, string p_6)
        //{
        //    throw new NotImplementedException();
        //}
        void xoahoadon(string MAHD)
        {
            
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM hoadonds WHERE MAHD='"+MAHD+"'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void suahoadon(string MAHD, string MAKH, string NGAYLAP, string NGAYGIAO, string NOIGIAO, string MANV)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd =  "UPDATE hoadonds SET MAHD= '" + txtma.Text + "',MAKH='" + cbkhachhang.Text + "',NGAYLAP='" + txtngaylap.Text + "',NGAYGIAO='" + txtngaygiao.Text + "',NOIGIAO='" + txtnoigiao.Text + "',MANV='" +cbnhanvien.Text +"'WHERE MAHD='"+txtma.Text+"'"; 
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void timkiemhoadon(string MAHD, string MAKH, string NGAYLAP, string NGAYGIAO, string NOIGIAO, string MANV)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "select * from hoadonds where MAHD= '" + txtma.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from hoadonds where MAHD= '" + txtma.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvHoaDon.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnxoahoadon_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM hoadonds WHERE MAHD='" + txtma.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvHoaDon.DataSource = dt;

                connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnsuahoadon_Click(object sender, EventArgs e)
        {
            
            if (txtma.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE hoadonds SET MAHD= '" + txtma.Text + "',MAKH='" + cbkhachhang.Text + "',NGAYLAP='" + txtngaylap.Text + "',NGAYGIAO='" + txtngaygiao.Text + "',NOIGIAO='" + txtnoigiao.Text + "',MANV='" +cbnhanvien.Text +"' WHERE MAHD='"+txtma.Text+"'";
                cmd.ExecuteNonQuery();
                
                connDB.Close();
              
                dgvHoaDon.DataSource = hoadonds();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


    }
}
