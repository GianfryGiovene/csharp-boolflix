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
        public List<Playlist> Playlists { get; set; }

        //one to many
        public List<PlaybackHistory> PlaybackHistories { get; set; }

    }
}
