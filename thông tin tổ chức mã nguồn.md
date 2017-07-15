# THÔNG TIN TỔ CHỨC MÃ NGUỒN 
Để thống nhất và tuân thủ quy tắc đặt tên sẽ giúp dễ dàng quản lý project của mình, tăng khả năng sử dụng lại code, thuận tiện trong việc trao đổi với nhóm, dễ dàng mở rộng nhóm. 
Cách đặt tên dễ hiểu, dễ nhớ còn giúp bạn dễ dàng tìm file hơn khi phải đọc lại code của chính mình.
Thì các thành viên trong nhóm chúng xẽ thống nhất với nhau xẽ làm việc theo chuẩn sau:
## **+ Tổ chức lập trình:** nhóm xẽ triển khai dự án theo mô hình 3 lớp.
**- Preject DTO:** DTO chứa các Class đại diện cho các đối tượng được lưu trữ trong Database.
Ví du Class program.cs(biến cục bộ)
                    using System;
                    using System.Collections.Generic;
                    using System.Threading.Tasks;
                    using System.Linq;
                    using System.Windows.Forms;
                    //using System.Data;
                    //using System.Data.SqlClient;

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


