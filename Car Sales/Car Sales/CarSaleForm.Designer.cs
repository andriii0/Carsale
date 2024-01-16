namespace Car_Sales
{
    partial class CarSaleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFilter = new TextBox();
            dataGridView = new DataGridView();
            UpdateButton = new Button();
            RegisterButton = new Button();
            SearchButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ResetButton = new Button();
            label4 = new Label();
            BrandtxtBox = new TextBox();
            ModeltxtBox = new TextBox();
            YearTxtBox = new TextBox();
            PriceTxtBox = new TextBox();
            AdvancedSearch = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(574, 107);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(133, 23);
            txtFilter.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(70, 79);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(434, 298);
            dataGridView.TabIndex = 2;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(47, 407);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(127, 55);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update Cars";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(364, 407);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(121, 55);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Register a sale";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(574, 168);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(133, 54);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 37);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 8;
            label1.Text = "Avalible Cars:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 14.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(574, 79);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 9;
            label2.Text = "Filter:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Narrow", 14.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(545, 37);
            label3.Name = "label3";
            label3.Size = new Size(203, 23);
            label3.TabIndex = 10;
            label3.Text = "Type some keywords to filter";
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(574, 461);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(133, 54);
            ResetButton.TabIndex = 11;
            ResetButton.Text = "Reset filter settings";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Narrow", 14.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(574, 239);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 12;
            label4.Text = "Advanced filter:";
            // 
            // BrandtxtBox
            // 
            BrandtxtBox.Location = new Point(574, 276);
            BrandtxtBox.Name = "BrandtxtBox";
            BrandtxtBox.PlaceholderText = "Brand";
            BrandtxtBox.Size = new Size(133, 23);
            BrandtxtBox.TabIndex = 13;
            // 
            // ModeltxtBox
            // 
            ModeltxtBox.Location = new Point(574, 305);
            ModeltxtBox.Name = "ModeltxtBox";
            ModeltxtBox.PlaceholderText = "Model";
            ModeltxtBox.Size = new Size(133, 23);
            ModeltxtBox.TabIndex = 14;
            // 
            // YearTxtBox
            // 
            YearTxtBox.Location = new Point(574, 334);
            YearTxtBox.Name = "YearTxtBox";
            YearTxtBox.PlaceholderText = "Year";
            YearTxtBox.Size = new Size(133, 23);
            YearTxtBox.TabIndex = 15;
            // 
            // PriceTxtBox
            // 
            PriceTxtBox.Location = new Point(574, 363);
            PriceTxtBox.Name = "PriceTxtBox";
            PriceTxtBox.PlaceholderText = "Price";
            PriceTxtBox.Size = new Size(133, 23);
            PriceTxtBox.TabIndex = 16;
            // 
            // AdvancedSearch
            // 
            AdvancedSearch.Location = new Point(574, 392);
            AdvancedSearch.Name = "AdvancedSearch";
            AdvancedSearch.Size = new Size(133, 54);
            AdvancedSearch.TabIndex = 17;
            AdvancedSearch.Text = "Search";
            AdvancedSearch.UseVisualStyleBackColor = true;
            AdvancedSearch.Click += AdvancedSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 388);
            label5.Name = "label5";
            label5.Size = new Size(218, 16);
            label5.TabIndex = 18;
            label5.Text = "cars.csv should be in the main folder";
            // 
            // CarSaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.abstract_bluish_paint_background_wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(778, 551);
            Controls.Add(label5);
            Controls.Add(AdvancedSearch);
            Controls.Add(PriceTxtBox);
            Controls.Add(YearTxtBox);
            Controls.Add(ModeltxtBox);
            Controls.Add(BrandtxtBox);
            Controls.Add(label4);
            Controls.Add(ResetButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchButton);
            Controls.Add(RegisterButton);
            Controls.Add(UpdateButton);
            Controls.Add(dataGridView);
            Controls.Add(txtFilter);
            Name = "CarSaleForm";
            Text = "Car Sale";
            Load += CarSaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFilter;
        public DataGridView dataGridView;
        private Button UpdateButton;
        private Button RegisterButton;
        private Button SearchButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ResetButton;
        private Label label4;
        private TextBox BrandtxtBox;
        private TextBox ModeltxtBox;
        private TextBox YearTxtBox;
        private TextBox PriceTxtBox;
        private Button AdvancedSearch;
        private Label label5;
    }
}
