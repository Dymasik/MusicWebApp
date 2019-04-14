using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class Ganre
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<SongGanre> SongGanres { get; set; }
    }
}
