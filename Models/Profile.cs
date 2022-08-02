using System.ComponentModel.DataAnnotations;

namespace BoolFlix.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }        
        public bool IsChild { get; set; }

        //one to many
        public List<Playlist>? Playlists { get; set; }

        // many to many
        public List<VideoContent>? VideoContents { get; set; }

    }
}
