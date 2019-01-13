using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBillingApp.BAL
{
    class ProductBAL
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public int Brand_ID { get; set; }
        public decimal Product_Cost { get; set; }
        public decimal Selling_Rate { get; set; }
        public string Description { get; set; }
    }
}
