using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApiNetCore6.Data
{
    [Table("BodyType")]
    public class BodyType
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
