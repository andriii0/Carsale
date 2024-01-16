using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Sales
{
    public class Customer
    {
        public string SaleDate { get; set; }
        public Car SoldCar { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string ZipCodeCity { get; set; }
        public List<string> Accessories { get; set; } 
    }
}
