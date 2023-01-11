using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.SqlServer.Data
{
    [Table("Size")]
    public class Size
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [StringLength(64)]
        [Column("code")]
        public string Code { get; set; }
    }
}
