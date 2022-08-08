using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Product :BaseEntity
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int CategoryID { get; set; }

        //relational properties

        public Category Category { get; set; }
        public virtual List<TagProducts> TagProducts { get; set; }
    }
}
