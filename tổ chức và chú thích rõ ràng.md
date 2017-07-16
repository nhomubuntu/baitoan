<p><h2>1)Tổ chức mã nguồn</h2></p>
<p>Một solution trong C# có thể bao gồm nhiều dự án (project), các project có cùng thư mục cha và mỗi project phải có một thư mục riêng. Trong cùng một dự án, bạn có thể tạo thêm một vài thư mục con tương ứng với mỗi namespace nếu cần thiết.
<p>Một project gồm nhiều tập tin, thường mỗi tập tin là một lớp, tuy nhiên trong C# một lớp có thể bao gồm nhiều tập tin như lớp Form. Mỗi tập tin bạn chỉ nên chứa một lớp và giữ giữ cho số dòng không nên quá dài, trường hợp các lớp hoặc cấu trúc nhỏ bạn có thể ghi chung vào một tập tin, giữa những lớp này nên có một sự tương đồng nào đó. Ví dụ bạn tạo một namespace Shape bao gồm các lớp hình vuông, tròn, tam giác thì các lớp này có thể đặt trong cùng một tập tin.</p>
<p>Các lớp mà bạn ra phải có chức năng rõ ràng, không nên phân chia ra các phương thức tương tự ra nhiều lớp khác nhau. Phạm vi của các phương thức và thuộc tính cần xác định chính xác là public, internal hay private. Theo nguyên tắc OOP, lớp mã nguồn của bạn càng có tính độc lập càng tốt, hạn chế mọi sự truy xuất các biến toàn cục có thể bằng cách viết dưới dạng phương thức hoặc Properties, nếu không việc kiểm soát giá trị biến sẽ rất khó khăn, khó sửa lỗi và làm mất đi tính độc lập của chương trình.</p>
<p><h2>2)Chú thích (Comment)</h2></p>
<p>Mã nguồn được chú thích rõ ràng ,nói rõ mục đích từng đoạn code có nhiệm vụ gì ,giúp người phát triển sau có thể hiểu .</p>
<p> VÍ DỤ: class khohang</p>
<a href="http://imgur.com/eq2ZrNC"><img src="http://i.imgur.com/eq2ZrNC.png" title="source: imgur.com" /></a>
<a href="http://imgur.com/51u23Cn"><img src="http://i.imgur.com/51u23Cn.png" title="source: imgur.com" /></a>
<a href="http://imgur.com/jLd3YMw"><img src="http://i.imgur.com/jLd3YMw.png" title="source: imgur.com" /></a>
<a href="http://imgur.com/pBmHs2l"><img src="http://i.imgur.com/pBmHs2l.png" title="source: imgur.com" /></a>
