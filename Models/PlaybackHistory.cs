using System.ComponentModel.DataAnnotations;

namespace BoolFlix.Models
{
    public class PlaybackHistory
    {
        [Key]
        public int Id { get; set; }

        //many to one
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        //many to one
        public int VideoContentId { get; set; }
        public VideoContent VideoContent { get; set; }
    }
}
