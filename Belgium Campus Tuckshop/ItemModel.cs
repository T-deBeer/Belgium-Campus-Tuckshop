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
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public double ProductCost { get; set; }
        
        public int Popular { get; set; }
        public string ItemDescription { get; set; }
    }
}
