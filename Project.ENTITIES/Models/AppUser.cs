using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        //relational properties

        public virtual AppUserProfile UserProfile { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
