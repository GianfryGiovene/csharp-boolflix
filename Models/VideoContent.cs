using System.ComponentModel.DataAnnotations;

namespace BoolFlix.Models
{
    public class VideoContent
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public bool IsNew { get; set; }        

        // one to many
        public List<PlaybackHistory> PlaybackHistory { get; set; }

        // many to one
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
