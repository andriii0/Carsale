using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public void ImportFromCSV()
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
                MessageBox.Show("An error occurred while importing from CSV: " + ex.Message);
            }
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
                        Price = double.Parse(data[3].Trim())
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
