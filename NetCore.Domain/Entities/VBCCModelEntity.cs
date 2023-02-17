using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Domain.Entities
{
    public class VBCCModelEntity
    {
        public int Id { get; set; }
        public string? SoHieuVB { get; set; }
        //public int? HocVienId { get; set; }
        public HocVienModelEntity? HocVien { get; set; }
    }
}
