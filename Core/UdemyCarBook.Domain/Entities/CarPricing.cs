using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class CarPricing
    {
        public int CarPiricingID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int PiricingID { get; set; }
        public Pricing Pricing { get; set; }
        public decimal Amount { get; set; }

    }
}
