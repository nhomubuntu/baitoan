# THÔNG TIN TỔ CHỨC MÃ NGUỒN 
Để thống nhất và tuân thủ quy tắc đặt tên sẽ giúp dễ dàng quản lý project của mình, tăng khả năng sử dụng lại code, thuận tiện trong việc trao đổi với nhóm, dễ dàng mở rộng nhóm. 
Cách đặt tên dễ hiểu, dễ nhớ còn giúp bạn dễ dàng tìm file hơn khi phải đọc lại code của chính mình.
Thì các thành viên trong nhóm chúng xẽ thống nhất với nhau xẽ làm việc theo chuẩn sau:
## **+ Tổ chức lập trình:** nhóm xẽ triển khai dự án theo mô hình 3 lớp.
**- Preject DTO:** DTO chứa các Class đại diện cho các đối tượng được lưu trữ trong Database.
<p>Ví du Class program.cs(biến cục bộ)</p>

namespace baitaplon
{
     static class Program
    {
         public static string strConn = @"Data Source=SKY-20170708UWU;Initial Catalog=QLCHMT;Integrated Security=True";
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}


**- Preject DAL:** DAL chứa các Class và các Class này có chức năng giao tiếp với hệ quản trị CSDL như thực hiện các công việc liên quan đến lưu trữ và truy vấn dữ liệu ( tìm kiếm, thêm, xóa, sửa,…).
<p>Ví du Class hoadon</p>

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
**- Preject GUI:** GUI là nơi có nhiệm vụ chính giao tiếp với người dùng. Nó gồm các thành phần giao diện và thực hiện các công việc như nhập liệu, hiển thị dữ liêu, kiểm tra tính đúng đắn dữ liệu trước khi gọi lớp BLL.

