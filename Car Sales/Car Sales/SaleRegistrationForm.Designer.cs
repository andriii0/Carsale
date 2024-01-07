namespace Car_Sales
{
    partial class SaleRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCustomerName = new TextBox();
            txtPhoneNo = new TextBox();
            txtAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            RegisterBtn = new Button();
            label4 = new Label();
            txtZip = new TextBox();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(171, 126);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(100, 23);
            txtCustomerName.TabIndex = 0;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(171, 164);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(100, 23);
            txtPhoneNo.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(171, 204);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 126);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 3;
            label1.Text = "Customer name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 164);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "Phone number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 207);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Adress";
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(96, 293);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(146, 50);
            RegisterBtn.TabIndex = 6;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 244);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Zip Code";
            // 
            // txtZip
            // 
            txtZip.Location = new Point(171, 244);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(100, 23);
            txtZip.TabIndex = 7;
            // 
            // SaleRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 438);
            Controls.Add(label4);
            Controls.Add(txtZip);
            Controls.Add(RegisterBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtCustomerName);
            Name = "SaleRegistrationForm";
            Text = "SaleRegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private TextBox txtPhoneNo;
        private TextBox txtAddress;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button RegisterBtn;
        private Label label4;
        private TextBox txtZip;
    }
}