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
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(574, 129);
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
            UpdateButton.Location = new Point(70, 407);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(127, 55);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update Cars";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(231, 407);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(121, 55);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Register a sale";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(574, 205);
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
            label1.Location = new Point(84, 37);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 8;
            label1.Text = "Avalible Cars:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(574, 79);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Filter:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(574, 37);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 10;
            label3.Text = "Type some keywords to filter";
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(574, 303);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(133, 54);
            ResetButton.TabIndex = 11;
            ResetButton.Text = "Reset filter settings";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // CarSaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 551);
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
            Text = "Form1";
            Load += CarSaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFilter;
        private DataGridView dataGridView;
        private Button UpdateButton;
        private Button RegisterButton;
        private Button SearchButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ResetButton;
    }
}
