using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ItemModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        
        public int Popular { get; set; }
        public string Description { get; set; }
    }
}
