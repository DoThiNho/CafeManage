using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class DOUONG
    {
        public DOUONG()
        {
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }
        [Key]
        [Required]
        [StringLength(20)]
        public string MaThucUong { get; set; }
        [Required]
        [StringLength(20)]
        public string MaLoaiThucUong { get; set; }
        [Required]
        [StringLength(30)]
        public string TenThucUong { get; set; }
        [Required]
        public double DonGia { get; set; }
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
        [ForeignKey("MaLoaiThucUong")]
        public virtual LOAIDOUONG LOAIDOUONG { get; set; }
    }
}
