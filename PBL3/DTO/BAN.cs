using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class BAN
    {
        public BAN()
        {
            this.BANTHANHTOANs = new HashSet<BANTHANHTOAN>();
        }
        [Key]
        [Required]
        [StringLength(20)]
        public string MaBan { get; set; }
        [Required]
        [StringLength(50)]
        public string TenBan { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        public virtual ICollection<BANTHANHTOAN> BANTHANHTOANs { get; set; }
    }
}
