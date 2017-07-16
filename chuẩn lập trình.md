<p><h3>1.Quy tắc đặt tên control</h3></p>
 
<p>Object____________________Prefix____________________Example</p>
<p>Form______________________frm_______________________frmFileOpen</p>
<p>Check box____________________chk_______________________ReadOnly</p>
<p>Combo box____________________cbo_______________________cboEnglish</p>
<p>Data-bound combo box_________dbc_______________________dbcEnglish</p>
<p>Command button_______________cmd_______________________cmdCancel</p>
<p>Data_________________________dat_______________________datBiblio</p>
<p>Directory list box___________dir_______________________dirSource</p>
<p>Drive list box_______________drv_______________________drvTarget</p>
<p>File list box________________fil_______________________filSource</p>
<p>Frame________________________fra_______________________fraLanguage</p>
<p>Grid_________________________grd_______________________grdPrices</p>
<p>Data-bound grid______________dbg_______________________dbgPrices</p>
<p>Horizontal scroll bar________hsb_______________________hsbVolume</p>
<p>Image________________________img_______________________imgIcon</p>
<p>Label________________________lbl_______________________lblHelpMessage</p>
<p>Line_________________________lin_______________________linVertical</p>
<p>List box_____________________lst_______________________lstPolicyCodes</p>
<p>Data-bound list box__________dbl_______________________dblPolicyCode</p>
<p>Menu_________________________mnu_______________________mnuFileOpen</p>
<p>OLE container________________ole_______________________oleObject</p>
<p>Option button________________opt_______________________optFrench</p>
<p>Picture box__________________pic_______________________picDiskSpace</p>
<p>Shape________________________shp_______________________shpCircle</p>
<p>Text box_____________________txt_______________________txtGetText</p>
<p>Timer________________________tmr_______________________tmrAlarm</p>
<p><h3>2. Quy tắc dành cho các class</h3></p>
 
<p><h5>Quy tắc Pascal:</h5></p> <p>Viết hoa chữ cái đầu tiên của mỗi từ (VD: Student, StudentDetail, ...)</p>
<p>-Sử dụng cho: Phương thức (method), Giao tiếp (Interface), Tập hợp (Enum), Sự kiện (Events), Ngoại lệ (Exception), Không gian tên (NameSpace), Thuộc tính (Property)</p>

<p><h5>Quy tắc Camel:</h5></p> <p>Viết thường từ đầu tiên và viết hoa chữ cái đầu tiên của từ kế tiếp (VD: student, studentDetail,...)</p>
<p>-Sử dụng cho: Tầm vực biến (Protected/Private), các Tham số (Parameter)</p>

  1.Cách tổ chức và lưu tên file, thư mục

Quy tắc đối với thư mục :

Tên thư mục phải trực quan, mô tả được tác dụng của những file nó chứa bên trong và được tối ưu nhất, tức là không dồn tất cả các file vào một thư mục nếu mục đích của file đó không thực sự đúng với mục đích của thư mục.

Tên thư mục không đặt in hoa, tất cả ký tự đều là chữ thường, không sử dụng dấu cách (space) trong khi đặt thư mục, nếu cần thiết sử dụng dấu gạch dưới ( _ ) để đặt tên

Quy tắc đối với File và Đặt tên File :

Đối với tổ chức File: File được lưu phải đúng địa điểm, nằm đúng thư mục mô tả tác dụng của nó, không lưu tại thư mục không liên quan đến mục đích của nó, không lưu file tại thư mục không mô tả rõ ràng mục đích của nó

Đối với đặt tên File: Tên File được lưu phải mô tả được nội dung tối tất yếu của nó (class, function….)

Tên File không sử dụng dấu cách (space), nếu cần thiết sử dụng dấu gạch dưới ( _ )

   2.Cách tổ chức, đặt tên cho Fungction, Class
Có thể đối với một số bạn, trong quá trình này đây là kiến thức khó hiểu, vì bạn chưa có căn bản về function và class, dẫu vậy bạn vẫn nên đọc và lưu ý bài viết này để dành cho sau này khi bạn cần đến trong quá trình học.

Cách tổ chức Function, Class

Đối với Class, Function phải khai báo tên có mục đích rõ ràng, mô tả được công việc mà Class (lớp) và các Funtion (phương thức) của nó thực hiện.

Tên Class,Function không bắt đầu bằng số, bắt buộc bắt đầu bằng chữ cái và Viết HOA chữ cái đầu tiên.

Không sử dụng dấu cách (space) cho tên Class, Function. Nếu cần thiết sử dụng dấu gạch dưới ( _ ).

Bắt Buộc mô tả bằng dấu Comment (Sẽ mô tả ở phần sau) về nội dung Class, Function, các biến truyền vào, các biến sẽ trả về.

Cách tổ chức Function khi khai báo theo phong cách không hướng đối tượng

Function phải được khai báo sau tất cả mọi xử lý, thông thường theo cách viết này, function sẽ được đổ dồn về cuối file.

Function vẫn phải tuân theo phong cách đặt tên và khai báo cơ bản.

   3.Quy tắc đặt tên biến
Tên biến phải mô tả rõ ràng nội dung nó sẽ đảm nhận.

Tất cả phải viết bằng chữ thường

Không sử dụng dấu cách (space) khi đặt tên, nếu cần thiết sử dụng dấu ( _ )

Tên biến khai báo có hoặc không cần kiểu dữ liệu (chỉ đối với PHP, các ngôn ngữ khác có quy tắc khác)

Khi khai báo biến phải sử dụng comment để nêu rõ tác dụng và nội dung biến sẽ chứa

   4.Comment trong quá trình viết Code
Đối với tất cả các loại ngôn ngữ, comment trong quá trình viết code rất quan trọng, nó sẽ mô tả được các thông tin và điều mà người lập trình cần lưu ý đối với người đọc và chỉnh sửa code của họ sau này.

-Comment với tất cả Class, Function, Biến, quá trình xử lý điều kiện nào đó.

Sử dụng comment theo 2 cách : dùng dấu ( //comment content ) hoặc cặp dấu (/* comment content*/)

Đối với cặp dấu ( //comment content ): Nội dung comment sẽ nằm sau cặp dấu này bắt đầu từ dấu / thứ 2, tác dụng của comment chỉ duy nhất trên dòng đó.

Đối với cặp dấu (/* comment content*/) : Nội dung comment nằm trong cặp dấu này bắt đầu từ dấu * đầu tiên cho đến dấu * thứ 2, tác dụng của comment này có thể tác dụng trên nhiều dòng, tùy thuộc vào dấu * thứ hai nằm ở dòng nào để kéo dài khoảng cách comment.

Tất cả nội dung trong comment bao gồm : Biến, Function, Class, Text. Tất cả đều không có tác dụng trong phần comment và không có tác dụng, không hiển thị trong quá trình xử lý.
