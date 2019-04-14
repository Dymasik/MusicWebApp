using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class Album
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        
        public Artist Artist { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
