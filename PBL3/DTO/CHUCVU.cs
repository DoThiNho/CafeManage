using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class CHUCVU
    {
        public CHUCVU()
        {
            this.THONGTINNHANVIENs = new HashSet<THONGTINNHANVIEN>();
        }
        [Key]
        [Required]
        [StringLength(20)]
        public string MaChucVu { get; set; }
        [Required]
        [StringLength(50)]
        public string TenChucVu { get; set; }
        [Required]
        public double HeSoLuong { get; set; }
        public virtual ICollection<THONGTINNHANVIEN> THONGTINNHANVIENs { get; set; }
    }
}
