using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Tag : BaseEntity
    {
        public string TagName { get; set; }
        public string Description { get; set; }
        //relational properties

       public virtual List<TagProducts> TagProducts { get; set; }
    }
}
