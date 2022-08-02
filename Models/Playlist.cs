using System.ComponentModel.DataAnnotations;

namespace BoolFlix.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        //many to one 
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        //many to many
        public List<VideoContent>? VideoContents { get; set; }

    }
}
