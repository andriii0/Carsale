using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Car_Sales
{
    public partial class CarSaleForm : Form
    {
        public Dealership dataManager;
        public string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\cars.csv");
        private List<string[]> originalRows;


        public CarSaleForm()
        {
            InitializeComponent();
            dataManager = new Dealership();
            dataManager.ImportFromCSV();


            if (File.Exists(filePath))
            {
                originalRows = File.ReadAllLines(filePath)
                                    .Select(line => line.Split(','))
                                    .ToList();
            }
        }
        public DataGridViewRow SelectedCarRow
        {
            get { return dataGridView.CurrentRow; }
        }


        private void CarSaleForm_Load(object sender, EventArgs e)
        {
            UpdateButton_Click(sender, e);
        }

        public void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    List<string[]> rows = File.ReadAllLines(filePath)
                                            .Select(line => line.Split(','))
                                            .ToList();

                    dataGridView.Rows.Clear();
                    dataGridView.ColumnCount = rows.First().Length;

                    foreach (var row in rows)
                    {
                        dataGridView.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = SelectedCarRow;

            bool isValidCarSelected = selectedRow != null &&
                                      selectedRow.Cells.Count >= 4 &&
                                      selectedRow.Cells[0].Value?.ToString().ToLower() == "brand" &&
                                      selectedRow.Cells[1].Value?.ToString().ToLower() == "model";

            if (isValidCarSelected)
            {
                MessageBox.Show("Please select a valid car to make a sale.");
            }
            else
            {
                SaleRegistrationForm saleRegistrationForm = new SaleRegistrationForm(this, filePath);
                saleRegistrationForm.ShowDialog();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtFilter.Text.ToLower();

                List<string[]> filteredRows = originalRows
                    .Where(row => row.Any(cell => cell.ToLower().Contains(searchText)))
                    .ToList();

                dataGridView.Rows.Clear();

                foreach (var row in filteredRows)
                {
                    dataGridView.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";

            if (originalRows != null && originalRows.Any())
            {
                dataGridView.Rows.Clear();
                originalRows.ForEach(row => dataGridView.Rows.Add(row));
            }
            else
            {
                MessageBox.Show("No original data to reset.");
            }
        }

        private void AdvancedSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string brandSearchText = BrandtxtBox.Text.ToLower();
                string modelSearchText = ModeltxtBox.Text.ToLower();
                string yearSearchText = YearTxtBox.Text.ToLower();
                string priceSearchText = PriceTxtBox.Text.ToLower();

                List<string[]> filteredRows = originalRows
                    .Where(row =>
                        (string.IsNullOrWhiteSpace(brandSearchText) || row[0].ToLower().Contains(brandSearchText)) &&
                        (string.IsNullOrWhiteSpace(modelSearchText) || row[1].ToLower().Contains(modelSearchText)) &&
                        (string.IsNullOrWhiteSpace(yearSearchText) || row[2].ToLower().Contains(yearSearchText)) &&
                        (string.IsNullOrWhiteSpace(priceSearchText) || row[3].ToLower().Contains(priceSearchText))
                    )
                    .ToList();

                dataGridView.Rows.Clear();

                foreach (var row in filteredRows)
                {
                    dataGridView.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }

}
