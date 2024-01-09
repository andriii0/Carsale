using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Sales
{
    public partial class SaleRegistrationForm : Form
    {
        private CarSaleForm carSaleForm;

        public SaleRegistrationForm(CarSaleForm form)
        {
            InitializeComponent();
            carSaleForm = form;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNo.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtZip.Text))

            {
                MessageBox.Show("Please enter all required information.");
                return;
            }

            DataGridViewRow selectedRow = carSaleForm.SelectedCarRow;

            CultureInfo culture = CultureInfo.InvariantCulture;
            if (selectedRow != null && selectedRow.Index != 0)
            {
                Sale newSale = new Sale
                {
                    SoldCar = new Car 
                    {
                        Brand = selectedRow.Cells[0].Value?.ToString(),
                        Model = selectedRow.Cells[1].Value?.ToString(),
                        Year = Convert.ToInt32(selectedRow.Cells[2].Value),
                        Price = Convert.ToDouble(selectedRow.Cells[3].Value, culture)
                    },
                    CustomerName = txtCustomerName.Text,
                    PhoneNo = txtPhoneNo.Text,
                    Address = txtAddress.Text,
                    ZipCodeCity = txtZip.Text
                };

                DataManager dataManager = new DataManager();
                dataManager.RegisterSale(newSale);

                string markdownContent = $"# {DateTime.Now} | {newSale.SoldCar.Brand} {newSale.SoldCar.Model} ({newSale.SoldCar.Year})" +
                                            $"\n- *Price*: {newSale.SoldCar.Price}" +
                                            $"\n- *Customer*: {newSale.CustomerName}" +
                                            $"\n- *Phone no.*: {newSale.PhoneNo}" +
                                            $"\n- *Address*: {newSale.Address}" +
                                            $"\n- *ZipCode*: {newSale.ZipCodeCity}\n---\n";

                string filePath = "sales_export.md";
                File.AppendAllText(filePath, markdownContent);

                MessageBox.Show("Sale data added to Markdown file.");
            }
            else
            {
                MessageBox.Show("Please select a car to make a sale.");
            }
        }


    }
}
