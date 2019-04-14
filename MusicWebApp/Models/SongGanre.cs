using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class SongGanre
    {
        public long Id { get; set; }

        public Song Song { get; set; }
        public Ganre Ganre { get; set; }
    }
}
