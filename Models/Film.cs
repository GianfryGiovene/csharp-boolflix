using System.ComponentModel.DataAnnotations;

namespace BoolFlix.Models
{
    public class Film : VideoContent
    {
        [Key]
        public int Id { get; set; }
    }
}
