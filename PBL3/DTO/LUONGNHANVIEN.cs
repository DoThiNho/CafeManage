using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class LUONGNHANVIEN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        public string MaNhanVien { get; set; }
        [Required]
        public int Gio { get; set; }
        public DateTime Ngay { get; set; }
        public double TongLuong { get; set; }
        [ForeignKey("MaNhanVien")]
        public virtual THONGTINNHANVIEN THONGTINNHANVIEN { get; set; }
    }
}
