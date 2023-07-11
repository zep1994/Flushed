using System.ComponentModel.DataAnnotations;

namespace Flushed_API.Models
{
    public class IbsCount
    {
        [Key]
       public int Id { get; set; }
       public int? Count { get; set; } = 0;
    }
}
