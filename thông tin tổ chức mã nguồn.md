# THÔNG TIN TỔ CHỨC MÃ NGUỒN 
Để thống nhất và tuân thủ quy tắc đặt tên sẽ giúp dễ dàng quản lý project của mình, tăng khả năng sử dụng lại code, thuận tiện trong việc trao đổi với nhóm, dễ dàng mở rộng nhóm. 
Cách đặt tên dễ hiểu, dễ nhớ còn giúp bạn dễ dàng tìm file hơn khi phải đọc lại code của chính mình.
Thì các thành viên trong nhóm chúng xẽ thống nhất với nhau xẽ làm việc theo chuẩn sau:
## **+ Tổ chức lập trình:** nhóm xẽ triển khai dự án theo mô hình 3 lớp.
**- Preject DTO:** DTO chứa các Class đại diện cho các đối tượng được lưu trữ trong Database.
<p>Ví du Class program.cs(biến cục bộ)</p>

<p>namespace baitaplon</p>
<p>{</p>
     <p>static class Program</p>
    <p>{</p>
         <p>public static string strConn = @"Data Source=SKY-20170708UWU;Initial Catalog=QLCHMT;Integrated Security=True";</p>
         <p> /// <summary></p>
        <p>/// The main entry point for the application</p>
        <p>/// </summary></p>
        <p>[STAThread]</p>
        <p>static void Main()</p>
        <p>{</p>
            <p>Application.EnableVisualStyles();</p>
            <p>Application.SetCompatibleTextRenderingDefault(false);</p>
            <p>Application.Run(new Form1());</p>
        <p>}</p>
   <p> }</p>
<p>}</p>


**- Preject DAL:** DAL chứa các Class và các Class này có chức năng giao tiếp với hệ quản trị CSDL như thực hiện các công việc liên quan đến lưu trữ và truy vấn dữ liệu ( tìm kiếm, thêm, xóa, sửa,…).
<p>Ví du Class hoadon</p>

<p>namespace baitaplon</p>
<p>{</p>
    <p>public partial class dshoadon : Form</p>
   <p> {</p>
        <p>public dshoadon()</p>
        <p>{</p>
            <p>InitializeComponent();</p>
        <p>}</p>
        <p>DataTable hoadonds()</p>
        <p>{</p>
            <p>SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM hoadonds", Program.strConn);</p>
            <p>DataTable ds = new DataTable();</p>
            <p>da.Fill(ds);</p>
            <p>return ds;</p>
        <p>}</p>
        <p>private void dshoadon_Load(object sender, EventArgs e)</p>
       <p> {</p>
          <p>  dgvHoaDon.DataSource = hoadonds();</p>
       <p> }</p>
       <p> void themhoadon(string MAHD, string MAKH, string NGAYLAP, string NGAYGIAO, string NOIGIAO, string MANV)</p>
       <p> {</p>
          <p>  SqlConnection connDB = new SqlConnection(Program.strConn);</p>
           <p> connDB.Open();</p>
           <p> string cmd = "INSERT INTO hoadonds VALUES(N'" + MAHD + "',N'" + MAKH + "','" + NGAYLAP + "','" + NGAYGIAO + "',N'" + NOIGIAO + "',N'"+MANV+"')";</p>
           <p> SqlCommand sqlCmd = new SqlCommand(cmd, connDB);</p>
           <p> sqlCmd.ExecuteNonQuery();</p>
            <p>connDB.Close();</p>
        <p>}</p>
       <p> private void btnthem_Click(object sender, EventArgs e)</p>
        <p>{</p>
          <p>  themhoadon(txtma.Text, cbkhachhang.Text, txtngaylap.Text,txtngaygiao.Text,txtnoigiao.Text,cbnhanvien.Text);</p>
           <p> dgvHoaDon.DataSource = hoadonds();</p>
       <p> }</p>
       <p> void xoahoadon(string MAHD)</p>
       <p> {</p>
            
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


   <p> }</p>
<p>}</p>
<p>**- Preject GUI:** GUI là nơi có nhiệm vụ chính giao tiếp với người dùng. Nó gồm các thành phần giao diện và thực hiện các công việc như nhập liệu, hiển thị dữ liêu, kiểm tra tính đúng đắn dữ liệu trước khi gọi lớp BLL.</p>

