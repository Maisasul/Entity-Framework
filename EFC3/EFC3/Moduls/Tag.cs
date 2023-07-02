using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC3.Moduls
{
    public class Tag
    {
        public int id { get; set; }
        public  string name { get; set; }
        public ICollection<Post> posts { get; set; }
    }
}
