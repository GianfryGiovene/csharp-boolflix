using BoolFlix.Context.DB;

namespace BoolFlix.Models
{
    public class PlaylistByDuration : Playlist
    {

        public PlaylistByDuration(int duration)
        {
            using(BoolflixContext ctx = new BoolflixContext())
            {
                this.Title = "film che durano più di " + duration + "minuti";
                this.VideoContents = ctx.VideoContents.Where(p => p.Duration > duration).ToList();

                
            }
        }
    }
}
