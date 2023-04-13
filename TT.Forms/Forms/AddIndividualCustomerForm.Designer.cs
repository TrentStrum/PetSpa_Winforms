namespace TT.Forms.Forms
{
    partial class AddIndividualCustomerForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            PhoneNumberLabel = new Label();
            EmailLabel = new Label();
            StreetAddressLabel = new Label();
            CityLabel = new Label();
            StateLabel = new Label();
            ZipCodeLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            MobileNumberTextBox = new TextBox();
            PersonalEmailTextBox = new TextBox();
            ShippingStreetAddressTextBox = new TextBox();
            ShippingCityTextBox = new TextBox();
            ShippingZipCodeTextBox = new TextBox();
            ShippingStateComboBox = new ComboBox();
            AddCustomerSubmitButton = new Button();
            ValidEmailErrorProvider = new ErrorProvider(components);
            FirstNameErrorProvider = new ErrorProvider(components);
            LastNameErrorProvider = new ErrorProvider(components);
            CityErrorProvider = new ErrorProvider(components);
            StateErrorProvider = new ErrorProvider(components);
            ZipErrorProvider = new ErrorProvider(components);
            PhoneErrorProvider = new ErrorProvider(components);
            HomeNumberTextBox = new TextBox();
            label2 = new Label();
            WorkEmailTextBox = new TextBox();
            label3 = new Label();
            BillingStateComboBox = new ComboBox();
            BillingZipCodeTextBox = new TextBox();
            BillingCityTextBox = new TextBox();
            BillingStreetTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            BillingSupplementalTextBox = new TextBox();
            label10 = new Label();
            ShippingSupplementalTextBox = new TextBox();
            label11 = new Label();
            BillingSameAsShippingCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)ValidEmailErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FirstNameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LastNameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CityErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StateErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ZipErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhoneErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(580, 51);
            label1.Name = "label1";
            label1.Size = new Size(409, 54);
            label1.TabIndex = 9;
            label1.Text = "Create New Customer";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.ForeColor = SystemColors.GrayText;
            FirstNameLabel.Location = new Point(77, 140);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(165, 44);
            FirstNameLabel.TabIndex = 10;
            FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.ForeColor = SystemColors.GrayText;
            LastNameLabel.Location = new Point(745, 140);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(162, 44);
            LastNameLabel.TabIndex = 11;
            LastNameLabel.Text = "Last Name:";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberLabel.ForeColor = SystemColors.GrayText;
            PhoneNumberLabel.Location = new Point(132, 208);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(110, 44);
            PhoneNumberLabel.TabIndex = 12;
            PhoneNumberLabel.Text = "Mobile:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.ForeColor = SystemColors.GrayText;
            EmailLabel.Location = new Point(29, 272);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(213, 44);
            EmailLabel.TabIndex = 13;
            EmailLabel.Text = "Personal Email";
            // 
            // StreetAddressLabel
            // 
            StreetAddressLabel.AutoSize = true;
            StreetAddressLabel.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            StreetAddressLabel.ForeColor = SystemColors.GrayText;
            StreetAddressLabel.Location = new Point(141, 400);
            StreetAddressLabel.Name = "StreetAddressLabel";
            StreetAddressLabel.Size = new Size(101, 44);
            StreetAddressLabel.TabIndex = 14;
            StreetAddressLabel.Text = "Street:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CityLabel.ForeColor = SystemColors.GrayText;
            CityLabel.Location = new Point(167, 547);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(75, 44);
            CityLabel.TabIndex = 15;
            CityLabel.Text = "City:";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            StateLabel.ForeColor = SystemColors.GrayText;
            StateLabel.Location = new Point(151, 613);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(91, 44);
            StateLabel.TabIndex = 16;
            StateLabel.Text = "State:";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ZipCodeLabel.ForeColor = SystemColors.GrayText;
            ZipCodeLabel.Location = new Point(103, 677);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(139, 44);
            ZipCodeLabel.TabIndex = 17;
            ZipCodeLabel.Text = "Zip Code:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            FirstNameTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTextBox.Location = new Point(259, 138);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(409, 50);
            FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            LastNameTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTextBox.Location = new Point(931, 138);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(409, 50);
            LastNameTextBox.TabIndex = 1;
            // 
            // MobileNumberTextBox
            // 
            MobileNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            MobileNumberTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            MobileNumberTextBox.Location = new Point(259, 206);
            MobileNumberTextBox.Name = "MobileNumberTextBox";
            MobileNumberTextBox.Size = new Size(409, 50);
            MobileNumberTextBox.TabIndex = 2;
            // 
            // PersonalEmailTextBox
            // 
            PersonalEmailTextBox.BorderStyle = BorderStyle.FixedSingle;
            PersonalEmailTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PersonalEmailTextBox.Location = new Point(259, 270);
            PersonalEmailTextBox.Name = "PersonalEmailTextBox";
            PersonalEmailTextBox.Size = new Size(409, 50);
            PersonalEmailTextBox.TabIndex = 3;
            PersonalEmailTextBox.Validating += EmailTextBox_Validating;
            // 
            // ShippingStreetAddressTextBox
            // 
            ShippingStreetAddressTextBox.BorderStyle = BorderStyle.FixedSingle;
            ShippingStreetAddressTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ShippingStreetAddressTextBox.Location = new Point(259, 398);
            ShippingStreetAddressTextBox.Name = "ShippingStreetAddressTextBox";
            ShippingStreetAddressTextBox.Size = new Size(409, 50);
            ShippingStreetAddressTextBox.TabIndex = 4;
            // 
            // ShippingCityTextBox
            // 
            ShippingCityTextBox.BorderStyle = BorderStyle.FixedSingle;
            ShippingCityTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ShippingCityTextBox.Location = new Point(259, 545);
            ShippingCityTextBox.Name = "ShippingCityTextBox";
            ShippingCityTextBox.Size = new Size(409, 50);
            ShippingCityTextBox.TabIndex = 5;
            // 
            // ShippingZipCodeTextBox
            // 
            ShippingZipCodeTextBox.BorderStyle = BorderStyle.FixedSingle;
            ShippingZipCodeTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ShippingZipCodeTextBox.Location = new Point(259, 675);
            ShippingZipCodeTextBox.Name = "ShippingZipCodeTextBox";
            ShippingZipCodeTextBox.Size = new Size(409, 50);
            ShippingZipCodeTextBox.TabIndex = 7;
            // 
            // ShippingStateComboBox
            // 
            ShippingStateComboBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ShippingStateComboBox.FormattingEnabled = true;
            ShippingStateComboBox.Location = new Point(259, 610);
            ShippingStateComboBox.Name = "ShippingStateComboBox";
            ShippingStateComboBox.Size = new Size(409, 50);
            ShippingStateComboBox.TabIndex = 6;
            // 
            // AddCustomerSubmitButton
            // 
            AddCustomerSubmitButton.BackColor = Color.DarkTurquoise;
            AddCustomerSubmitButton.FlatAppearance.BorderSize = 0;
            AddCustomerSubmitButton.FlatStyle = FlatStyle.Flat;
            AddCustomerSubmitButton.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            AddCustomerSubmitButton.ForeColor = Color.White;
            AddCustomerSubmitButton.Location = new Point(580, 791);
            AddCustomerSubmitButton.Name = "AddCustomerSubmitButton";
            AddCustomerSubmitButton.Size = new Size(409, 53);
            AddCustomerSubmitButton.TabIndex = 8;
            AddCustomerSubmitButton.Text = "Submit";
            AddCustomerSubmitButton.TextAlign = ContentAlignment.BottomCenter;
            AddCustomerSubmitButton.UseVisualStyleBackColor = false;
            AddCustomerSubmitButton.Click += AddCustomerSubmitButton_Click;
            // 
            // ValidEmailErrorProvider
            // 
            ValidEmailErrorProvider.ContainerControl = this;
            // 
            // FirstNameErrorProvider
            // 
            FirstNameErrorProvider.ContainerControl = this;
            // 
            // LastNameErrorProvider
            // 
            LastNameErrorProvider.ContainerControl = this;
            // 
            // CityErrorProvider
            // 
            CityErrorProvider.ContainerControl = this;
            // 
            // StateErrorProvider
            // 
            StateErrorProvider.ContainerControl = this;
            // 
            // ZipErrorProvider
            // 
            ZipErrorProvider.ContainerControl = this;
            // 
            // PhoneErrorProvider
            // 
            PhoneErrorProvider.ContainerControl = this;
            // 
            // HomeNumberTextBox
            // 
            HomeNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            HomeNumberTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            HomeNumberTextBox.Location = new Point(931, 204);
            HomeNumberTextBox.Name = "HomeNumberTextBox";
            HomeNumberTextBox.Size = new Size(409, 50);
            HomeNumberTextBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(805, 206);
            label2.Name = "label2";
            label2.Size = new Size(102, 44);
            label2.TabIndex = 19;
            label2.Text = "Home:";
            // 
            // WorkEmailTextBox
            // 
            WorkEmailTextBox.BorderStyle = BorderStyle.FixedSingle;
            WorkEmailTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            WorkEmailTextBox.Location = new Point(931, 270);
            WorkEmailTextBox.Name = "WorkEmailTextBox";
            WorkEmailTextBox.Size = new Size(409, 50);
            WorkEmailTextBox.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(736, 272);
            label3.Name = "label3";
            label3.Size = new Size(171, 44);
            label3.TabIndex = 21;
            label3.Text = "Work Email:";
            // 
            // BillingStateComboBox
            // 
            BillingStateComboBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BillingStateComboBox.FormattingEnabled = true;
            BillingStateComboBox.Location = new Point(931, 610);
            BillingStateComboBox.Name = "BillingStateComboBox";
            BillingStateComboBox.Size = new Size(409, 50);
            BillingStateComboBox.TabIndex = 24;
            // 
            // BillingZipCodeTextBox
            // 
            BillingZipCodeTextBox.BorderStyle = BorderStyle.FixedSingle;
            BillingZipCodeTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BillingZipCodeTextBox.Location = new Point(931, 675);
            BillingZipCodeTextBox.Name = "BillingZipCodeTextBox";
            BillingZipCodeTextBox.Size = new Size(409, 50);
            BillingZipCodeTextBox.TabIndex = 25;
            // 
            // BillingCityTextBox
            // 
            BillingCityTextBox.BorderStyle = BorderStyle.FixedSingle;
            BillingCityTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BillingCityTextBox.Location = new Point(931, 545);
            BillingCityTextBox.Name = "BillingCityTextBox";
            BillingCityTextBox.Size = new Size(409, 50);
            BillingCityTextBox.TabIndex = 23;
            // 
            // BillingStreetTextBox
            // 
            BillingStreetTextBox.BorderStyle = BorderStyle.FixedSingle;
            BillingStreetTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BillingStreetTextBox.Location = new Point(931, 398);
            BillingStreetTextBox.Name = "BillingStreetTextBox";
            BillingStreetTextBox.Size = new Size(409, 50);
            BillingStreetTextBox.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(775, 677);
            label4.Name = "label4";
            label4.Size = new Size(139, 44);
            label4.TabIndex = 29;
            label4.Text = "Zip Code:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(823, 613);
            label5.Name = "label5";
            label5.Size = new Size(91, 44);
            label5.TabIndex = 28;
            label5.Text = "State:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(839, 547);
            label6.Name = "label6";
            label6.Size = new Size(75, 44);
            label6.TabIndex = 27;
            label6.Text = "City:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(813, 400);
            label7.Name = "label7";
            label7.Size = new Size(101, 44);
            label7.TabIndex = 26;
            label7.Text = "Street:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.GrayText;
            label8.Location = new Point(336, 351);
            label8.Name = "label8";
            label8.Size = new Size(244, 44);
            label8.TabIndex = 30;
            label8.Text = "Shipping Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.GrayText;
            label9.Location = new Point(1067, 351);
            label9.Name = "label9";
            label9.Size = new Size(210, 44);
            label9.TabIndex = 31;
            label9.Text = "Billing Address";
            // 
            // BillingSupplementalTextBox
            // 
            BillingSupplementalTextBox.BorderStyle = BorderStyle.FixedSingle;
            BillingSupplementalTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BillingSupplementalTextBox.Location = new Point(931, 472);
            BillingSupplementalTextBox.Name = "BillingSupplementalTextBox";
            BillingSupplementalTextBox.Size = new Size(409, 50);
            BillingSupplementalTextBox.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.GrayText;
            label10.Location = new Point(712, 474);
            label10.Name = "label10";
            label10.Size = new Size(202, 44);
            label10.TabIndex = 35;
            label10.Text = "Supplemental:";
            // 
            // ShippingSupplementalTextBox
            // 
            ShippingSupplementalTextBox.BorderStyle = BorderStyle.FixedSingle;
            ShippingSupplementalTextBox.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ShippingSupplementalTextBox.Location = new Point(259, 472);
            ShippingSupplementalTextBox.Name = "ShippingSupplementalTextBox";
            ShippingSupplementalTextBox.Size = new Size(409, 50);
            ShippingSupplementalTextBox.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sans Serif Collection", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.GrayText;
            label11.Location = new Point(40, 474);
            label11.Name = "label11";
            label11.Size = new Size(202, 44);
            label11.TabIndex = 33;
            label11.Text = "Supplemental:";
            // 
            // BillingSameAsShippingCheckBox
            // 
            BillingSameAsShippingCheckBox.AutoSize = true;
            BillingSameAsShippingCheckBox.Location = new Point(259, 731);
            BillingSameAsShippingCheckBox.Name = "BillingSameAsShippingCheckBox";
            BillingSameAsShippingCheckBox.Size = new Size(295, 19);
            BillingSameAsShippingCheckBox.TabIndex = 36;
            BillingSameAsShippingCheckBox.Text = "Is the billing address the same as shipping address?";
            BillingSameAsShippingCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddIndividualCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1407, 875);
            Controls.Add(BillingSameAsShippingCheckBox);
            Controls.Add(BillingSupplementalTextBox);
            Controls.Add(label10);
            Controls.Add(ShippingSupplementalTextBox);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(BillingStateComboBox);
            Controls.Add(BillingZipCodeTextBox);
            Controls.Add(BillingCityTextBox);
            Controls.Add(BillingStreetTextBox);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(WorkEmailTextBox);
            Controls.Add(label3);
            Controls.Add(HomeNumberTextBox);
            Controls.Add(label2);
            Controls.Add(AddCustomerSubmitButton);
            Controls.Add(ShippingStateComboBox);
            Controls.Add(ShippingZipCodeTextBox);
            Controls.Add(ShippingCityTextBox);
            Controls.Add(ShippingStreetAddressTextBox);
            Controls.Add(PersonalEmailTextBox);
            Controls.Add(MobileNumberTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(ZipCodeLabel);
            Controls.Add(StateLabel);
            Controls.Add(CityLabel);
            Controls.Add(StreetAddressLabel);
            Controls.Add(EmailLabel);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(label1);
            ForeColor = SystemColors.GrayText;
            Name = "AddIndividualCustomerForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Customer";
            ((System.ComponentModel.ISupportInitialize)ValidEmailErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)FirstNameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)LastNameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)CityErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)StateErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)ZipErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhoneErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label PhoneNumberLabel;
        private Label EmailLabel;
        private Label StreetAddressLabel;
        private Label CityLabel;
        private Label StateLabel;
        private Label ZipCodeLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox MobileNumberTextBox;
        private TextBox PersonalEmailTextBox;
        private TextBox ShippingStreetAddressTextBox;
        private TextBox ShippingCityTextBox;
        private TextBox ShippingZipCodeTextBox;
        private ComboBox ShippingStateComboBox;
        private Button AddCustomerSubmitButton;
        private ErrorProvider ValidEmailErrorProvider;
        private ErrorProvider FirstNameErrorProvider;
        private ErrorProvider LastNameErrorProvider;
        private ErrorProvider CityErrorProvider;
        private ErrorProvider StateErrorProvider;
        private ErrorProvider ZipErrorProvider;
        private ErrorProvider PhoneErrorProvider;
        private Label label9;
        private Label label8;
        private ComboBox BillingStateComboBox;
        private TextBox BillingZipCodeTextBox;
        private TextBox BillingCityTextBox;
        private TextBox BillingStreetTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox WorkEmailTextBox;
        private Label label3;
        private TextBox HomeNumberTextBox;
        private Label label2;
        private TextBox BillingSupplementalTextBox;
        private Label label10;
        private TextBox ShippingSupplementalTextBox;
        private Label label11;
        private CheckBox BillingSameAsShippingCheckBox;
    }
}