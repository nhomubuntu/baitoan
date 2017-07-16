2.2.3	Thiết kế dữ liệu mô hình dữ liệu
Bảng phânloại:
Tên Trường	Kiễu dữ liệu	Null	Khóa	Ghi chú
MALOAI	varchar(10)		chính	Mãloại
TENLOAI	nvarchar(100)			Tênloại

Bảng kho hàng:
Tên Trường	Kiễu dữ liệu	Null	Khóa	Ghi chú
MAMH	varchar(10)		chính	Mãmặthàng
SOLUONG	int			Sốlượng

Bảng nhà cung cấp:
Tên Trường	Kiễu dữ liệu	Null	Khóa	Ghi chú
MANCC	varchar(10)		chính	Mãnhàcungcấp
TENNCC	nvarchar(100)			Tênnhàcungcấp
DIACHI	nvarchar(100)			Địachỉnhàcungcấp
DIENTHOAI	varchar(15)			Điệnthoạinhàcungcấp
Bảng mặt hàng:

Tên Trường	Kiễu dữ liệu	Null	Khóa	Ghi chú
MAMH	varchar(10)		chính	Mãmặthàng
TENMH	nvarchar(100)			Tênmặthàng
DVTINH	nvarchar(15)			Đơnvịtính
MALOAI	varchar(10)	null		Mãloại
GIABAN	float	null		Giábán


Bảng khách hàng:

Tên Trường	Kiễu dữ liệu	Null	Khóa	Ghi chú
MAKH	varchar(10)		chính	Mãkháchhàng
TENKH	nvarchar(100)	null		Tênkháchhàng
DIACHI_KH	nvarchar(100)			Địachỉkháchhàng
DIENTHOAI_KH	varchar(15)	null		Điệnthoạikháchhàng


Bảng hóa đơn:

Tên Trường	Kiễu dữ liệu	Null	Khóa	Ghi chú
MAHD	varchar(10)		chính	Mãhóađơn
MAKH	varchar(10)			Mãkháchhàng
NGAYLAP	datetime			Ngàylập
NGAYGIAO	datetime			Ngàygiao
NOIGIAO	nvarchar(50)			Nơigiao
maNV	varchar(10)			Mãnhânviên


Bảng chi tiết hóa đơn:

Tên Trường	Kiễu dữ liệu	Null	Khóa	Ghi chú
MAHD	varchar(10)		chính	Sốhóađơn
MAMH	varchar(10)			Mãmặthàng
GIABAN	float			Giábán
SOLUONG	int			Sốlượng
GIAMGIA	int			Giảmgiá




Bảng cung cấp:

Tên Trường	Kiễu dữ liệu	Null	Khóa	Ghi chú
MACC	varchar(10)		chính	Mãcungcấp
MANCC	varchar(10)			Mãnhàcungcấp
MAMH	varchar(10)			Mãmặthàng
SOLUONG	int			Sốlượng
GIACC	float			Giácungcấp


Bảng nhân viên:

Tên trường	Kiễu dữ liệu	Null	Khóa	Ghi chú
MANV	varchar(10)	 	chính	Mã nhân viên
TENNV	nvarchar(100)	 	 	Tên nhân viên
DiachiNV	nvarchar(100)	 	 	Địa chỉ nhân viên
DienthoaiNV	varchar(15)	 	 	Điện thoại nhân viên
Luong	float	 	 	Lương
 
