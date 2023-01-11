using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApiNetCore6.Data
{
    [Table("Size")]
    public class Size
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
