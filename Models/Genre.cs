using System.ComponentModel.DataAnnotations;

namespace BoolFlix.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        // one to many
        public List<VideoContent>? VideoContents { get; set; }
    }
}
