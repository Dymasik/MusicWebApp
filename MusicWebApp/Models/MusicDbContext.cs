using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class MusicDbContext : DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<ArtistService> ArtistServices { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongGanre> SongGanres { get; set; }
        public DbSet<Ganre> Ganres { get; set; }

        public MusicDbContext(DbContextOptions<MusicDbContext> options)
            : base(options)
        {
            this.Init();
        }
    }
}
