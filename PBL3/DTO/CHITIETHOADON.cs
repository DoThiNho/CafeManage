using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class CHITIETHOADON
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string MaHoaDon { get; set; }
        [Required]
        [StringLength(50)]
        public string MaThucUong { get; set; }
        [Required]
        public int SoLuong { get; set; }
        public double ThanhTien { get; set; }

        [ForeignKey("MaHoaDon")]
        public virtual HOADON HOADON { get; set; }
        [ForeignKey("MaThucUong")]
        public virtual DOUONG DOUONG { get; set; }
    }
}
