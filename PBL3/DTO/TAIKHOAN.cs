using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class TAIKHOAN
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string MaNhanVien { get; set; }
        [Required]
        [StringLength(20)]
        public string MatKhau { get; set; }
        [Required]
        public int Quyen { get; set; }

        public virtual THONGTINNHANVIEN THONGTINNHANVIEN { get; set; }
    }
}
