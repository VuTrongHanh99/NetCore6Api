using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCore.Shared;

namespace Data.SqlServer.Data
{
    public class VBCC
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        [Column("so_hieu_vb")]
        public string? SoHieuVB { get; set; }
        [ForeignKey("HocVien")]
        [Column("hoc_vien_id")]
        public int? HocVienId { get; set; }
        public HocVien? HocVien { get; set; }
    }
}
