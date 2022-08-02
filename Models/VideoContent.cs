using System.ComponentModel.DataAnnotations;

namespace BoolFlix.Models
{
    public abstract class VideoContent
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public bool IsNew { get; set; }    
        public string PictureURL { get; set; }

        // many to one
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }

        //many to many
        public List<Playlist>? Playlists { get; set; }

        // many to many
        public List<Profile>? Profiles { get; set; }


        public VideoContent() 
        {
        }
    }
}
