using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCRental.Appceptance.Test.Support
{
    public class CatalogContext
    {
        public CatalogContext()
        {
            ReferenceProperty = new ListProperty();
        }

        public ListProperty ReferenceProperty { get; set; }
    }
}
