using NetCore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Domain.Entities
{
    public class HocVienModelEntity
    {
        public int Id { get; set; }
        public string? HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        /*
            1. Nam
            2. Nữ
            3. Không xác định
         */
        public Constant.GenderEnum GioiTinh { get; set; }
        public string? DiaChi { get; set; }
    }
}
