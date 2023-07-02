using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC3.Moduls
{
    public class Blog
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }

        public List<Post> post { get; set; }
        public int AuthorId { get; set; }
        public Author author { get; set; }
    }
}
