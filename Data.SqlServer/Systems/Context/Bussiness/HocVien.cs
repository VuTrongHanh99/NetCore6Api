using NetCore.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SqlServer.Data
{
    public class HocVien
    {
        [Key]
        [Column("id")]
        public int MaHV { get; set; }
        [Required]
        [StringLength(128)]
        [Column("user_name")]
        public string? HoTen { get; set; }
        [Column("birthday")]
        public DateTime? NgaySinh { get; set; }
        /*
            1. Nam
            2. Nữ
            3. Không xác định
         */
        [Column("sex")]
        public Constant.GenderEnum GioiTinh { get; set; }
        [Column("address")]
        public string? DiaChi { get; set; }
    }
}
