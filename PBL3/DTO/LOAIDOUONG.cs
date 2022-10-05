using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class LOAIDOUONG
    {
        public LOAIDOUONG()
        {
            this.DOUONGs = new HashSet<DOUONG>();
        }
        [Key]
        [Required]
        [StringLength(20)]
        public string MaLoaiThucUong { get; set; }
        [Required]
        [StringLength(50)]
        public string TenLoaiThucUong { get; set; }
        public virtual ICollection<DOUONG> DOUONGs { get; set; }
    }
}
