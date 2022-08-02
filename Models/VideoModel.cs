namespace BoolFlix.Models
{
    public class VideoModel
    {
        public VideoContent Content { get; set; }
        public List<Genre>? GenresList { get; set; }
    }
}
