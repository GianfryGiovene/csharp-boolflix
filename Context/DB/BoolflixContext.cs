using BoolFlix.Models;
using Microsoft.EntityFrameworkCore;


namespace BoolFlix.Context.DB
{
    public class BoolflixContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<PlaybackHistory> PlaybackHistories { get; set; }        

        public DbSet<Playlist> Playlists { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<VideoContent> VideoContents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=boolflix_db;Integrated Security=True");
        }

        public BoolflixContext()
        {

        }

    }
}
