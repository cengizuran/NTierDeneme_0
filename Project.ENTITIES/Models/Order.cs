using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order : BaseEntity
    {
        public string SentAddress { get; set; }
        public int AppUserID { get; set; }
        public int ShipperID { get; set; }

        //relational properties

        public virtual List<ProductOrder> ProductOrders { get; set; }
        public virtual AppUser AppUser { get; set; }
        public Shipper Shipper { get; set; }


    }
}
