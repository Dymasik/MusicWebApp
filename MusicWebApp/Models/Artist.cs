using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Country ArtCountry { get; set; }
        public ICollection<ArtistService> ArtistServices { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
