using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerTypes
{
    public class Orders
    {
        public int Id { get; set; }
        public string OrderDetails { get; set; }
        public Addresses ShippingAddress { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

    }
}
