using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QLTV_DoAn.Models
{
    public class NguoiDung
    {
        [Key]
        public int MaNguoiDung { get; set; }

        [Display(Name = "Tên Người Dùng"), Required]
        public string TenNguoiDung { get; set; }

        [Display(Name = "Loại Người Dùng"), Required]
        public int LoaiNguoiDung { get; set; }

        [Display(Name = "Tên Đăng Nhập"), Required]
        public string TenDangNhap { get; set; }

        [Display(Name = "Mật khẩu"), Required]
        public string MatKhau { get; set; }

        public bool DaXoa { get; set; }
    }
}
