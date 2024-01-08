using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Car_Sales
{
    public class DataManager
    {
        private List<Car> availableCars;
        private List<Sale> soldCars;

        public List<Car> AvailableCars { get { return availableCars; } }
        public List<Sale> SoldCars { get { return soldCars; } }

        public DataManager()
        {
            availableCars = new List<Car>();
            soldCars = new List<Sale>();
        }

        public void ImportFromCSV(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines.Skip(1))
                {
                    string[] data = line.Split(',');

                    if (data.Length >= 4)
                    {
                        string brand = data[0].Trim();
                        string model = data[1].Trim();
                        int year = int.Parse(data[2].Trim());
                        //this one is written by gpt im gonna be honest
                        double price;
                        if (!double.TryParse(data[3].Trim(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out price))
                        {
                            MessageBox.Show("Error with this: " + data[3]);
                        }



                        Car newCar = new Car
                        {
                            Brand = brand,
                            Model = model,
                            Year = year,
                            Price = price
                        };

                        availableCars.Add(newCar);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error with importing from CSV: " + ex.Message);
            }
        }

        public void RegisterSale(Sale sale)
        {
            if (!soldCars.Any(s => s.SoldCar == sale.SoldCar))
            {
                soldCars.Add(sale);
            }
            else
            {
                MessageBox.Show("This auto is sold.");
            }
        }


        public List<Car> SearchCars(string brand, string model, double price)
        {
            List<Car> result = availableCars;

            if (!string.IsNullOrEmpty(brand))
            {
                result = result.Where(c => c.Brand.ToLower().Contains(brand.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(model))
            {
                result = result.Where(c => c.Model.ToLower().Contains(model.ToLower())).ToList();
            }

            if (price > 0)
            {
                result = result.Where(c => c.Price <= price).ToList();
            }

            return result;
        }
    }
}
