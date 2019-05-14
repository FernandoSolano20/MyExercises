using System.Data.Entity;

namespace Videos.Models
{
    public class VideoDb : DbContext
    {
        //entityframework context
        public DbSet<Video> Videos { get; set; }        
    }
}