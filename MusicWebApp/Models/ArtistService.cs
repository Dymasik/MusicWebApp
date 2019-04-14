using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class ArtistService
    {
        public long Id { get; set; }
        
        public Artist Artist { get; set; }
        public Service Service { get; set; }
    }
}
