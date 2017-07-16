<h3>THÔNG TIN TỔ CHỨC MÃ NGUỒN MỞ</h3>

<h4>Open Source Initiative - OSI</h4>
Sáng kiến Nguồn mở (OSI) là một công ty lợi ích công cộng California được thành lập vào năm 1998.

Sáng kiến Nguồn mở (OSI) tích cực tham gia xây dựng cộng đồng nguồn mở, giáo dục, và vận động công chúng để nâng cao nhận thức và tầm quan trọng của phần mềm không phải là độc quyền. Các thành viên của OSI thường xuyên đi du lịch khắp thế giới tham dự các hội nghị và sự kiện của Open Source, gặp gỡ các nhà phát triển và người sử dụng mã nguồn mở và thảo luận với các nhà quản lý từ các khu vực công cộng và tư nhân về công nghệ, giấy phép và các mô hình phát triển của công nghệ

Tổ chức Sáng kiến Nguồn mở (Open Source Initiative - OSI) thể hiện một triết lý nguồn mở và xác định ranh giới về việc sử dụng, thay đổi và tái phân phối phần mềm nguồn mở

Apache Software Foundation (ASF) - Tổ chức phần mềm Apache

Là một tập đoàn phi lợi nhuận hỗ trợ các dự án phần mềm Apache, bao gồm các máy chủ Apache HTTP. ASF được hình thành từ Tập đoàn Apache và được thành lập ở Delaware , Mỹ vào tháng 6 năm 1999

Tổ chức Phần mềm Apache là một cộng đồng các nhà phát triển mã nguồn mở được phân quyền. Phần mềm họ sản xuất được phân phối theo các iều khoản của Giấy phép Apache và là phần mềm nguồn mở và miễn phí (FOSS). Các dự án Apache được đặc trưng bởi một quá trình phát triển dựa trên sự đồng thuận, đồng thuận và một giấy phép phần mềm mở và thực dụng. Mỗi dự án được quản lý bởi đội ngũ chuyên gia tự chọn do chính họ là những người đóng góp tích cực vào dự án. ASF là một sự ủng hộ , có nghĩa là các thành viên của quỹ chỉ được cấp cho các được cấp cho các chỉ được cấp cho các
tình nguyện viên đã tích cực đóng góp cho các dự án Apache.
Tổ chức lập trình: nhóm xẽ triển khai dự án theo mô hình 3 lớp.

- Preject DTO: DTO chứa các Class đại diện cho các đối tượng được lưu trữ trong Database.

Ví du Class program.cs(biến cục bộ)

namespace baitaplon

{

static class Program

{

public static string strConn = @"Data Source=SKY-20170708UWU;Initial Catalog=QLCHMT;Integrated Security=True";

///

/// The main entry point for the application

///

[STAThread]

static void Main()

{

Application.EnableVisualStyles();

Application.SetCompatibleTextRenderingDefault(false);

Application.Run(new Form1());

}

}

}

- Preject DAL: DAL chứa các Class và các Class này có chức năng giao tiếp với hệ quản trị CSDL như thực hiện các công việc liên quan đến lưu trữ và truy vấn dữ liệu ( tìm kiếm, thêm, xóa, sửa,…).

Ví du Class hoadon

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

void xoahoadon(string MAHD)

{

       <p> SqlConnection connDB = new SqlConnection(Program.strConn);</p>
      <p>  connDB.Open();</p>
      <p>  string cmd = "DELETE FROM hoadonds WHERE MAHD='"+MAHD+"'";</p>
      <p>  SqlCommand sqlCmd = new SqlCommand(cmd, connDB);</p>
        <p>sqlCmd.ExecuteNonQuery();</p>
       <p> connDB.Close();</p>
   <p> }</p>
   <p> void suahoadon(string MAHD, string MAKH, string NGAYLAP, string NGAYGIAO, string NOIGIAO, string MANV)</p>
   <p> {</p>
      <p>  SqlConnection connDB = new SqlConnection(Program.strConn);</p>
      <p>  connDB.Open();</p>
     <p>   string cmd =  "UPDATE hoadonds SET MAHD= '" + txtma.Text + "',MAKH='" + cbkhachhang.Text + "',NGAYLAP='" + txtngaylap.Text + "',NGAYGIAO='" + txtngaygiao.Text + "',NOIGIAO='" + txtnoigiao.Text + "',MANV='" +cbnhanvien.Text +"'WHERE MAHD='"+txtma.Text+"'"; </p>
      <p>  SqlCommand sqlCmd = new SqlCommand(cmd, connDB);</p>
       <p> sqlCmd.ExecuteNonQuery();</p>
        <p>connDB.Close();</p>
    <p>}</p>
   <p> void timkiemhoadon(string MAHD, string MAKH, string NGAYLAP, string NGAYGIAO, string NOIGIAO, string MANV)</p>
    <p>{</p>
      <p>  SqlConnection connDB = new SqlConnection(Program.strConn);</p>
       <p> connDB.Open();</p>
       <p> string cmd = "select * from hoadonds where MAHD= '" + txtma.Text + "'";</p>
        <p>SqlCommand sqlCmd = new SqlCommand(cmd, connDB);</p>
       <p> sqlCmd.ExecuteNonQuery();</p>
       <p> connDB.Close();</p>
   <p> }</p>

   <p> private void btntimkiem_Click(object sender, EventArgs e)</p>
   <p> {</p>
      <p>  if (txtma.Text != "")</p>
       <p> {</p>
         <p>   SqlConnection connDB = new SqlConnection(Program.strConn);</p>
           <p> connDB.Open();</p>
          <p>  SqlCommand cmd = connDB.CreateCommand();</p>
           <p> cmd.CommandType = CommandType.Text;</p>
           <p> cmd.CommandText = "select * from hoadonds where MAHD= '" + txtma.Text + "'";</p>
           <p> cmd.ExecuteNonQuery();</p>
           <p> DataTable dt = new DataTable();</p>
           <p> SqlDataAdapter da = new SqlDataAdapter(cmd);</p>
           <p> da.Fill(dt);</p>
           <p> dgvHoaDon.DataSource = dt;</p>

          <p>  connDB.Close();</p>

       <p> }</p>
       <p> else</p>
       <p> {</p>
         <p>   MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);</p>
      <p>  }</p>



   <p> }</p>

   <p> private void btnxoahoadon_Click(object sender, EventArgs e)</p>
   <p> {</p>
      <p>  if (txtma.Text != "")</p>
      <p>  {</p>
        <p>    SqlConnection connDB = new SqlConnection(Program.strConn);</p>
         <p>   connDB.Open();</p>
           <p> SqlCommand cmd = connDB.CreateCommand();</p>
           <p> cmd.CommandType = CommandType.Text;</p>
           <p> cmd.CommandText = "DELETE FROM hoadonds WHERE MAHD='" + txtma.Text + "'";</p>
           <p> cmd.ExecuteNonQuery();</p>
           <p> DataTable dt = new DataTable();</p>
           <p> SqlDataAdapter da = new SqlDataAdapter(cmd);</p>
            <p>da.Fill(dt);</p>
            <p>dgvHoaDon.DataSource = dt;</p>

           <p> connDB.Close();</p>

       <p> }</p>
       <p> else</p>
       <p> {</p>
         <p>   MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);</p>
       <p> }</p>

   <p> }</p>

   <p> private void btnsuahoadon_Click(object sender, EventArgs e)</p>
   <p> {</p>
        
     <p>   if (txtma.Text != "")</p>
     <p>   {</p>
     <p>       SqlConnection connDB = new SqlConnection(Program.strConn);</p>
        <p>    connDB.Open();</p>
         <p>   SqlCommand cmd = connDB.CreateCommand();</p>
         <p>   cmd.CommandType = CommandType.Text;</p>
         <p>   cmd.CommandText = "UPDATE hoadonds SET MAHD= '" + txtma.Text + "',MAKH='" + cbkhachhang.Text + "',NGAYLAP='" + txtngaylap.Text + "',NGAYGIAO='" + txtngaygiao.Text + "',NOIGIAO='" + txtnoigiao.Text + "',MANV='" +cbnhanvien.Text +"' WHERE MAHD='"+txtma.Text+"'";</p>
           <p> cmd.ExecuteNonQuery();</p>
            
            <p>connDB.Close();</p>
          
          <p>  dgvHoaDon.DataSource = hoadonds();</p>

      <p>  }</p>
       <p> else</p>
       <p> {</p>
        <p>    MessageBox.Show("error !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);</p>
      <p>  }</p>

    <p>}</p>
}

}

**- Preject GUI:** GUI là nơi có nhiệm vụ chính giao tiếp với người dùng. Nó gồm các thành phần giao diện và thực hiện các công việc như nhập liệu, hiển thị dữ liêu, kiểm tra tính đúng đắn dữ liệu trước khi gọi lớp BLL.
