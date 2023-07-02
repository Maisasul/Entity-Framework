using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC3.Moduls
{
    public class Author
    {
        public int id { get; set; }
        public string name { get; set; }
        public string field { get; set; }
        public int age { get; set; }
        public Blog Blog { get; set; }
    }
}
