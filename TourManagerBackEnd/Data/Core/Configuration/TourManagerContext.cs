using System.IO;
using Data.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Data.Core.Configuration
{
    public class TourManagerContext: DbContext
    {
        public DbSet<Venues> Venues { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public TourManagerContext (DbContextOptions<TourManagerContext> options) : base(options)
        {
            Database.Migrate();
        }
        //FIMXE: pay technical deb
        /*public TourManagerContext () : base()
        {
            Database.Migrate();
        }*/
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {           
            var h = GetAExePath();
            //options.UseSqlite($"Data Source={h}/TourManager.db");  
        }
        
        //TODO: fix this
        public string GetAExePath()
        {
            var exePath =   Path.GetDirectoryName(System.Reflection
                .Assembly.GetExecutingAssembly().CodeBase);
            return exePath;

        }
        
    }
}