////////////////////////////////////////////////////////////////////////
#### Clone - Lấy kho chứa về máy 
Trên trang **nhomubuntu** vừa tạo, chọn HTTPS để copy HTTPS clone URL 

*Chúng ta cũng có thể dùng SSH nhưng phải thiết lập SSH key, cái này mình sẽ nói ở sau*

<img src="http://i.imgur.com/PyjB9l6.png">

Dùng lệnh `clone` để lấy repo về máy: 

     $ git clone https://github.com/nhomubuntu/baitoan.git

Sau khi thực hiện lệnh này, một directory tên là **nhomubuntu** xuất hiện trên máy của bạn. Vị trí lưu directory này tại nơi bạn thực hiện lệnh.

Bên trong thư mục **nhomubuntu** sẽ có:
* 1 file **README.md**
Có thể coi là file giới thiệu, chúng ta có thể sửa bằng bất kỳ trình soạn thảo nào. 
* 1 dir **.git** (bị ẩn) chứa cấu hình Git.
Chúng ta có thể thêm các file khác vào thư mục **nhomubuntu** này để đưa lên Github.


#### Add, Commit, Push - Đưa file lên Github  
#####Lưu ý là những thao tác tiếp theo phải thực hiện trong thư mục **nhomubuntu**
Giả sử, bạn tạo một file **hello_git.cpp** trong thư mục **nhomubuntu**.
Để thực hiện `add` ta dùng lệnh:

    $ git add hello_git.cpp

Nếu có nhiều file và bạn muốn `add` hết tất cả các file đó:

    $ git add *

Để `commit` ta dùng lệnh:

    $ git commit -m "Them file hello_git.cpp"
   
Để `push` lên Github ta dùng lệnh:

    $ git push

Bạn sẽ được hỏi username và password khi bạn đăng nhập Github.

Lưu ý là password khi mình nhập không hiện lên, bạn cứ gõ bình thường thôi.

*Nếu dùng SSH key thì sẽ không phải nhập phần này nữa*





######DONE
Bạn load lại trang **nhomubuntu** trên Github, file **hello_git.cpp** mà xuất hiện thì bạn đã thành công.
<img src="http://i.imgur.com/TAjssLZ.png">


######Nếu bạn đang có một thư mục trong máy (giả sử tên là playground), bạn muốn đẩy nó lên một repo mới

Trên github, bạn tạo một repo tên là playground và không chọn tạo file README.md

Dùng terminal: 
 
    $ cd playground

    $ git init

Câu lệnh sẽ tạo một file .git trong playground (ấn Ctrl+H sẽ thấy). Thư mục này chứa tất cả tập tin cần thiết để thiết lập repo

Tiếp theo, bạn tạo file README.md, rồi thực hiện add và commit như mọi khi

Sau đó, bạn phải remote để đồng nhất repo local với repo trên github. Câu lệnh như sau: 

    $ git remote add origin git-URL

Và cuối cùng thì 

    $ git push origin master 

#### Pull - Lấy file về máy
Giả sử, trong cái **nhomubuntu** có sự thay đổi như thêm file hay file nào đó được sửa nhưng ở máy của bạn chưa cập nhật điều này
Bạn cần `pull` về máy:

    $ git pull
