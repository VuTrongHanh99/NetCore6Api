using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApiNetCore6.Data
{
    [Table("Make")]
    public class Make
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
