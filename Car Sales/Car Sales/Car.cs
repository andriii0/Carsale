using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Sales
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public bool Equals(object obj)
        {
            if (obj is not Car otherCar)
                return false;

            return string.Equals(Brand, otherCar.Brand, StringComparison.OrdinalIgnoreCase) &&
                   string.Equals(Model, otherCar.Model, StringComparison.OrdinalIgnoreCase) &&
                   Year == otherCar.Year &&
                   Math.Abs(Price - otherCar.Price) < double.Epsilon;
        }


        public int GetHashCode()
        {
            return HashCode.Combine(Brand?.ToLower(), Model?.ToLower(), Year, Price);
        }
    }
}
