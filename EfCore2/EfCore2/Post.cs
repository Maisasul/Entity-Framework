using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore2
{
    internal class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string describtion { get; set; }
        public string tag { get; set; }
    }
}
