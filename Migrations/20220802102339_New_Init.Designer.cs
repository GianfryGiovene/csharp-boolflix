// <auto-generated />
using BoolFlix.Context.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoolFlix.Migrations
{
    [DbContext(typeof(BoolflixContext))]
    [Migration("20220802102339_New_Init")]
    partial class New_Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BoolFlix.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BoolFlix.Models.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("BoolFlix.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsChild")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("BoolFlix.Models.VideoContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("VideoContents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("VideoContent");
                });

            modelBuilder.Entity("PlaylistVideoContent", b =>
                {
                    b.Property<int>("PlaylistsId")
                        .HasColumnType("int");

                    b.Property<int>("VideoContentsId")
                        .HasColumnType("int");

                    b.HasKey("PlaylistsId", "VideoContentsId");

                    b.HasIndex("VideoContentsId");

                    b.ToTable("PlaylistVideoContent");
                });

            modelBuilder.Entity("ProfileVideoContent", b =>
                {
                    b.Property<int>("ProfilesId")
                        .HasColumnType("int");

                    b.Property<int>("VideoContentsId")
                        .HasColumnType("int");

                    b.HasKey("ProfilesId", "VideoContentsId");

                    b.HasIndex("VideoContentsId");

                    b.ToTable("ProfileVideoContent");
                });

            modelBuilder.Entity("BoolFlix.Models.Film", b =>
                {
                    b.HasBaseType("BoolFlix.Models.VideoContent");

                    b.HasDiscriminator().HasValue("Film");
                });

            modelBuilder.Entity("BoolFlix.Models.Playlist", b =>
                {
                    b.HasOne("BoolFlix.Models.Profile", "Profile")
                        .WithMany("Playlists")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("BoolFlix.Models.VideoContent", b =>
                {
                    b.HasOne("BoolFlix.Models.Genre", "Genre")
                        .WithMany("VideoContents")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("PlaylistVideoContent", b =>
                {
                    b.HasOne("BoolFlix.Models.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoolFlix.Models.VideoContent", null)
                        .WithMany()
                        .HasForeignKey("VideoContentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProfileVideoContent", b =>
                {
                    b.HasOne("BoolFlix.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("ProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoolFlix.Models.VideoContent", null)
                        .WithMany()
                        .HasForeignKey("VideoContentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoolFlix.Models.Genre", b =>
                {
                    b.Navigation("VideoContents");
                });

            modelBuilder.Entity("BoolFlix.Models.Profile", b =>
                {
                    b.Navigation("Playlists");
                });
#pragma warning restore 612, 618
        }
    }
}
