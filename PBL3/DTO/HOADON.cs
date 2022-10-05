using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class HOADON
    {
        public HOADON()
        {
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
            this.BANTHANHTOANs = new HashSet<BANTHANHTOAN>();
        }
        [Key]
        [Required]
        [StringLength(50)]
        public string MaHoaDon { get; set; }
        [Required]
        [StringLength(20)]
        public string MaNhanVien { get; set; }
        //[Required]
        //[StringLength(20)]
        //public string MaBanTT { get; set; }
        public DateTime Ngay { get; set; }
        [Required]
        public bool TrangThaiThanhToan { get; set; }
        [Required]
        public double TongTien { get; set; }
        /*[ForeignKey("MaHoaDon"), Column(Order = 0)]
        [ForeignKey("MaBanTT"), Column(Order = 1)]*/
        public virtual BANTHANHTOAN BANTHANHTOAN { get; set; }
        [ForeignKey("MaNhanVien")]
        public virtual THONGTINNHANVIEN THONGTINNHANVIEN { get; set; }
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual ICollection<BANTHANHTOAN> BANTHANHTOANs { get; set; }

    }
}
