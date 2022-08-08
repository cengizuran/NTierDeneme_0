using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class TagProducts : BaseEntity
    {
        public int TagID { get; set; }
        public int ProductID { get; set; }
        //relational properties

        public virtual Tag Tag { get; set; }
        public virtual Product Product { get; set; }
    }
}
