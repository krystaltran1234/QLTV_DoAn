using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QLTV_DoAn.Models
{
    public class LoaiNguoiDung
    {
        [Key]
        public int MaLoaiND { get; set; }

        [Display(Name = "Tên Loại Người Dùng"), Required]
        public string TenLoaiND { get; set; }

        public bool DaXoa { get; set; }
    }
}
