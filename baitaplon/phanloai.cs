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
    public partial class phanloai : Form
    {
        public phanloai()
        {
            InitializeComponent();
        }
        DataTable phanloaids()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM phanloaids", Program.strConn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }

        private void phanloai_Load(object sender, EventArgs e)
        {
            dgphanloai.DataSource = phanloaids();
        }
        void themphanloai(string MALOAI, string TENLOAI)
        {
            
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO phanloaids VALUES('" + txtmaloai.Text + "',N'" + txttenloai.Text + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themphanloai(txtmaloai.Text, txttenloai.Text);
            dgphanloai.DataSource = phanloaids();
        }
        void xoaphanloai(string MALOAI)
        {

            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();


            // xoa bang mathangds 

            //string cmd = "DELETE FROM mathangds WHERE MALOAI='" + txtmaloai.Text + "'";
            //SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            //sqlCmd.ExecuteNonQuery();

            // cxoa
            string cmd = "DELETE FROM phanloaids WHERE MALOAI='" +txtmaloai.Text+ "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (txtmaloai.Text != "")
            {
                //SqlConnection connDB = new SqlConnection(Program.strConn);
                //connDB.Open();
                //SqlCommand cmd = connDB.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "DELETE FROM phanloaids WHERE MALOAI='" + txtmaloai.Text + "'";
                //cmd.ExecuteNonQuery();
                //DataTable dt = new DataTable();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //da.Fill(dt);
                //dgphanloai.DataSource = dt;
                xoaphanloai(txtmaloai.Text);
                dgphanloai.DataSource = phanloaids();
                //connDB.Close();

            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void suaphanloai(string MALOAI, string TENLOAI)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE phanloaids SET MALOAI= '" + txtmaloai.Text + "',TENLOAI='" + txttenloai.Text + "' WHERE MALOAI='" + txtmaloai.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            if (txtmaloai.Text != "")
            {
                SqlConnection connDB = new SqlConnection(Program.strConn);
                connDB.Open();
                SqlCommand cmd = connDB.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE phanloaids SET MALOAI= '" + txtmaloai.Text + "',TENLOAI='" + txttenloai.Text + "' WHERE MALOAI='"+txtmaloai.Text+"'";
                cmd.ExecuteNonQuery();
                

                connDB.Close();
                dgphanloai.DataSource = phanloaids();
            }
            else
            {
                MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
         void timkiemphanloai(string MALOAI )
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "select * from phanloaids where MALOAI= '" + txtmaloai.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

         private void btntimkiem_Click(object sender, EventArgs e)
         {

             if (txtmaloai.Text != "")
             {
                 SqlConnection connDB = new SqlConnection(Program.strConn);
                 connDB.Open();
                 SqlCommand cmd = connDB.CreateCommand();
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "select * from phanloaids where MALOAI= '" + txtmaloai.Text + "'";
                 cmd.ExecuteNonQuery();
                 DataTable dt = new DataTable();
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 da.Fill(dt);
                 dgphanloai.DataSource = dt;

                 connDB.Close();

             }
             else
             {
                 MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }

         }

        }



    }

