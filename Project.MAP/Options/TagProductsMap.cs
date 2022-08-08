using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class TagProductsMap : BaseMap<TagProducts>
    {
        public TagProductsMap()
        {
            ToTable("Urun Etiketleri");
            Ignore(x => x.ID);
            HasKey(x => new { x.ProductID, x.TagID });
        }
    }
}
