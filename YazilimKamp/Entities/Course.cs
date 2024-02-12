using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimKamp.Entities
{
    public class Course
    {
        //Property
        public int Id { get; set; }     
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; internal set; }
    }
}
