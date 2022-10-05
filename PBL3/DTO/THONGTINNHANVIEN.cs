using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class THONGTINNHANVIEN
    {
        public THONGTINNHANVIEN()
        {
            this.HOADONs = new HashSet<HOADON>();
            this.LUONGNHANVIENs = new HashSet<LUONGNHANVIEN>();
        }
        [Key]
        [Required]
        [StringLength(20)]
        public string MaNhanVien { get; set; }
        [StringLength(50)]
        [Required]
        public string TenNhanVien { get; set; }
        [Required]
        public bool GioiTinh { get; set; }
        [StringLength(20)]
        [Required]
        public string MaChucVu { get; set; }
        [StringLength(20)]
        public string SDT { get; set; }
        [StringLength(20)]
        public string DiaChi { get; set; }
        public bool TrangThai { get; set; }
        public DateTime Time_Login { get; set; }
        public string CCCD { get; set; }
        public DateTime NgaySinh { get; set; }

        [ForeignKey("MaChucVu")]
        public virtual CHUCVU CHUCVU { get; set; }
        public virtual ICollection<HOADON> HOADONs { get; set; }
        [ForeignKey("MaNhanVien")]
        public virtual TAIKHOAN TAIKHOAN { get; set; }
        public virtual ICollection<LUONGNHANVIEN> LUONGNHANVIENs { get; set; }

    }
}
