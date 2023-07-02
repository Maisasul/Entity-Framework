using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC3.Moduls
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public Blog blogs { get; set; }  
        
        public ICollection<Tag> tags { get; set; }  
    }
}
