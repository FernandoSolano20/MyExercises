using System.Collections.Generic;

namespace Videos.Models
{
    public class Video
    {
        //to save in db
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual int Length { get; set; }
        
    }
}