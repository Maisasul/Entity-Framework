using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore2
{
    internal class Book
    {
        [Key]   
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
    }
}
