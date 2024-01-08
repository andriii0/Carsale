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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            dataGridView = new DataGridView();
            UpdateButton = new Button();
            RegisterButton = new Button();
            SearchButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(525, 97);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(162, 154);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(742, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(70, 79);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(434, 298);
            dataGridView.TabIndex = 2;
            dataGridView.ReadOnly = true;
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
            SearchButton.Location = new Point(374, 407);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(115, 44);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
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
            // CarSaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 551);
            Controls.Add(label1);
            Controls.Add(SearchButton);
            Controls.Add(RegisterButton);
            Controls.Add(UpdateButton);
            Controls.Add(dataGridView);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "CarSaleForm";
            Text = "Form1";
            Load += CarSaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private DataGridView dataGridView;
        private Button UpdateButton;
        private Button RegisterButton;
        private Button SearchButton;
        private Label label1;
    }
}
