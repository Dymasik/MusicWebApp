using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public static class MusicDbContextSeedData
    {
        static object synchlock = new object();
        static volatile bool seeded = false;

        public static void Init(this MusicDbContext context)
        {
            if (!seeded && context.Artists.Count() == 0)
            {
                lock (synchlock)
                {
                    if (!seeded)
                    {
                        GenerateDb(context);
                        context.SaveChanges();
                        seeded = true;
                    }
                }
            }
        }

        private static void GenerateDb(MusicDbContext context)
        {
            
        }
    }
}
