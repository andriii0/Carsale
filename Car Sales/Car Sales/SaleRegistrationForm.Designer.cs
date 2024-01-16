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
            RearCamera = new CheckBox();
            label5 = new Label();
            LeatherInterior = new CheckBox();
            MatrixHeadlights = new CheckBox();
            CruiseСontrol = new CheckBox();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(157, 45);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(100, 23);
            txtCustomerName.TabIndex = 0;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(157, 83);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(100, 23);
            txtPhoneNo.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(157, 123);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(145, 22);
            label1.TabIndex = 3;
            label1.Text = "Customer name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 14.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(134, 22);
            label2.TabIndex = 4;
            label2.Text = "Phone number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 14.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 126);
            label3.Name = "label3";
            label3.Size = new Size(71, 22);
            label3.TabIndex = 5;
            label3.Text = "Adress";
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(92, 363);
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
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 14.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 163);
            label4.Name = "label4";
            label4.Size = new Size(89, 22);
            label4.TabIndex = 8;
            label4.Text = "Zip Code";
            // 
            // txtZip
            // 
            txtZip.Location = new Point(157, 163);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(100, 23);
            txtZip.TabIndex = 7;
            // 
            // RearCamera
            // 
            RearCamera.AutoSize = true;
            RearCamera.BackColor = Color.Transparent;
            RearCamera.Font = new Font("Arial", 12F);
            RearCamera.Location = new Point(143, 204);
            RearCamera.Name = "RearCamera";
            RearCamera.Size = new Size(161, 22);
            RearCamera.TabIndex = 9;
            RearCamera.Text = "Rear View Camera";
            RearCamera.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 14.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 203);
            label5.Name = "label5";
            label5.Size = new Size(116, 22);
            label5.TabIndex = 10;
            label5.Text = "Accessories";
            // 
            // LeatherInterior
            // 
            LeatherInterior.AutoSize = true;
            LeatherInterior.BackColor = Color.Transparent;
            LeatherInterior.Font = new Font("Arial", 12F);
            LeatherInterior.Location = new Point(143, 239);
            LeatherInterior.Name = "LeatherInterior";
            LeatherInterior.Size = new Size(161, 22);
            LeatherInterior.TabIndex = 11;
            LeatherInterior.Text = "Leather Car Interior";
            LeatherInterior.UseVisualStyleBackColor = false;
            // 
            // MatrixHeadlights
            // 
            MatrixHeadlights.AutoSize = true;
            MatrixHeadlights.BackColor = Color.Transparent;
            MatrixHeadlights.Font = new Font("Arial", 12F);
            MatrixHeadlights.Location = new Point(143, 275);
            MatrixHeadlights.Name = "MatrixHeadlights";
            MatrixHeadlights.Size = new Size(147, 22);
            MatrixHeadlights.TabIndex = 12;
            MatrixHeadlights.Text = "Matrix Headlights";
            MatrixHeadlights.UseVisualStyleBackColor = false;
            // 
            // CruiseСontrol
            // 
            CruiseСontrol.AutoSize = true;
            CruiseСontrol.BackColor = Color.Transparent;
            CruiseСontrol.Font = new Font("Arial", 12F);
            CruiseСontrol.Location = new Point(143, 313);
            CruiseСontrol.Name = "CruiseСontrol";
            CruiseСontrol.Size = new Size(123, 22);
            CruiseСontrol.TabIndex = 13;
            CruiseСontrol.Text = "Cruise control";
            CruiseСontrol.UseVisualStyleBackColor = false;
            // 
            // SaleRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.v463_aum_69_abstractbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(349, 442);
            Controls.Add(CruiseСontrol);
            Controls.Add(MatrixHeadlights);
            Controls.Add(LeatherInterior);
            Controls.Add(label5);
            Controls.Add(RearCamera);
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
            Text = "Sale Registration";
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
        private CheckBox RearCamera;
        private Label label5;
        private CheckBox LeatherInterior;
        private CheckBox MatrixHeadlights;
        private CheckBox CruiseСontrol;
    }
}