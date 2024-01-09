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
        private DataManager dataManager;
        public string filePath = "cars.csv";
        private List<string[]> originalRows;


        public CarSaleForm()
        {
            InitializeComponent();
            dataManager = new DataManager();
            dataManager.ImportFromCSV(filePath);

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

        private void UpdateButton_Click(object sender, EventArgs e)
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
            SaleRegistrationForm saleRegistrationForm = new SaleRegistrationForm(this);
            saleRegistrationForm.ShowDialog();
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
    }

}
