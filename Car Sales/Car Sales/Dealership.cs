using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Car_Sales
{
    public class Dealership
    {
        private List<Car> availableCars;
        private List<Customer> soldCars;
        public string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\cars.csv");

        public Dealership()
        {
            availableCars = new List<Car>();
            soldCars = new List<Customer>();
        }

        public void RegisterSale(Customer sale)
        {
            soldCars.Add(sale);
            RemoveSoldCarFromCSV(sale.SoldCar);
        }

        private void RemoveSoldCarFromCSV(Car soldCar)
        {
            try
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                int indexToRemove = -1;
                for (int i = 1; i < lines.Count; i++)
                {
                    string[] data = lines[i].Split(',');
                    Car carInLine = new Car
                    {
                        Brand = data[0].Trim(),
                        Model = data[1].Trim(),
                        Year = int.Parse(data[2].Trim()),
                        Price = double.Parse(data[3].Trim(), CultureInfo.InvariantCulture)
                    };

                    if (carInLine.Equals(soldCar))
                    {
                        indexToRemove = i;
                        break;
                    }
                }

                if (indexToRemove != -1)
                {
                    lines.RemoveAt(indexToRemove);
                    File.WriteAllLines(filePath, lines);
                }

                MessageBox.Show("The car was removed from the CSV file");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the CSV file: " + ex.Message);
            }
        }
    }
}
