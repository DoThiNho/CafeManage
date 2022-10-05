using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class BANTHANHTOAN
    {
        //public BANTHANHTOAN()
        //{
        //    this.HOADONs = new HashSet<HOADON>();
        //}
        [Column(Order = 1)]
        [Key]
        [Required]
        [StringLength(20)]
        public string MaBanTT { get; set; }
        [Column(Order = 2)]
        //[Key]
        [Required]
        [StringLength(50)] 
        public string MaHoaDon { get; set; }
        [StringLength(20)]
        [Required]
        public string MaBan { get; set; }

        [ForeignKey("MaBan")]
        
        public virtual BAN BAN { get; set; }
        //[ForeignKey("MaHoaDon")]
        //public virtual ICollection<HOADON> HOADONs { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HOADON HOADON { get; set; }
    }
}
