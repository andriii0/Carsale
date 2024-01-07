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
        private bool changesMade = false;
        public string filePath = "cars.csv";



        public CarSaleForm()
        {
            InitializeComponent();
            dataManager = new DataManager();
            dataManager.ImportFromCSV(filePath);
        }
        public DataGridViewRow SelectedCarRow
        {
            get { return dataGridView.CurrentRow; }
        }


        private void CarSaleForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var rows = File.ReadAllLines(filePath)
                                   .Select(line => line.Split(','))
                                   .ToList();

                    if (rows.Any())
                    {
                        dataGridView.ColumnCount = rows[0].Length;

                        foreach (var row in rows)
                        {
                            dataGridView.Rows.Add(row);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The file is empty.");
                    }
                }
                else
                {
                    MessageBox.Show("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changesMade = true;
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


    }

}
