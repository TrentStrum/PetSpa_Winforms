namespace TT.Forms.Forms
{
    partial class CustomerProfileFormCW
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
            CustFirstNameTextBox = new TextBox();
            CustLastNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            CustEmailTextBox = new TextBox();
            CustMobileTextbox = new TextBox();
            CustPetDataGridView = new DataGridView();
            label4 = new Label();
            UpdateCustomerButton = new Button();
            label17 = new Label();
            CustHomeTextBox = new TextBox();
            CustRegistrationDateTextBox = new TextBox();
            label7 = new Label();
            AddPetButton = new Button();
            UpdatePetButton = new Button();
            RemovePetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CustPetDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CustFirstNameTextBox
            // 
            CustFirstNameTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustFirstNameTextBox.Location = new Point(15, 92);
            CustFirstNameTextBox.Name = "CustFirstNameTextBox";
            CustFirstNameTextBox.Size = new Size(270, 37);
            CustFirstNameTextBox.TabIndex = 2;
            // 
            // CustLastNameTextBox
            // 
            CustLastNameTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustLastNameTextBox.Location = new Point(302, 92);
            CustLastNameTextBox.Name = "CustLastNameTextBox";
            CustLastNameTextBox.Size = new Size(270, 37);
            CustLastNameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(287, 22);
            label1.Name = "label1";
            label1.Size = new Size(232, 39);
            label1.TabIndex = 0;
            label1.Text = "Customer Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 61);
            label2.Name = "label2";
            label2.Size = new Size(98, 29);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(302, 61);
            label3.Name = "label3";
            label3.Size = new Size(97, 29);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(578, 149);
            label5.Name = "label5";
            label5.Size = new Size(57, 29);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 149);
            label6.Name = "label6";
            label6.Size = new Size(131, 29);
            label6.TabIndex = 7;
            label6.Text = "Mobile Number";
            // 
            // CustEmailTextBox
            // 
            CustEmailTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustEmailTextBox.Location = new Point(578, 181);
            CustEmailTextBox.Name = "CustEmailTextBox";
            CustEmailTextBox.Size = new Size(270, 37);
            CustEmailTextBox.TabIndex = 12;
            // 
            // CustMobileTextbox
            // 
            CustMobileTextbox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustMobileTextbox.Location = new Point(15, 181);
            CustMobileTextbox.Name = "CustMobileTextbox";
            CustMobileTextbox.Size = new Size(270, 37);
            CustMobileTextbox.TabIndex = 8;
            // 
            // CustPetDataGridView
            // 
            CustPetDataGridView.AllowUserToAddRows = false;
            CustPetDataGridView.AllowUserToDeleteRows = false;
            CustPetDataGridView.AllowUserToResizeColumns = false;
            CustPetDataGridView.AllowUserToResizeRows = false;
            CustPetDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustPetDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            CustPetDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustPetDataGridView.Location = new Point(15, 346);
            CustPetDataGridView.Name = "CustPetDataGridView";
            CustPetDataGridView.ReadOnly = true;
            CustPetDataGridView.RowHeadersVisible = false;
            CustPetDataGridView.RowTemplate.Height = 25;
            CustPetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustPetDataGridView.Size = new Size(745, 161);
            CustPetDataGridView.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(352, 304);
            label4.Name = "label4";
            label4.Size = new Size(76, 39);
            label4.TabIndex = 14;
            label4.Text = "Pets";
            // 
            // UpdateCustomerButton
            // 
            UpdateCustomerButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateCustomerButton.Location = new Point(302, 237);
            UpdateCustomerButton.Name = "UpdateCustomerButton";
            UpdateCustomerButton.Size = new Size(270, 38);
            UpdateCustomerButton.TabIndex = 13;
            UpdateCustomerButton.Text = "Update Customer";
            UpdateCustomerButton.UseVisualStyleBackColor = true;
            UpdateCustomerButton.Click += UpdateCustomerButton_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(302, 149);
            label17.Name = "label17";
            label17.Size = new Size(126, 29);
            label17.TabIndex = 9;
            label17.Text = "Home Number";
            // 
            // CustHomeTextBox
            // 
            CustHomeTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustHomeTextBox.Location = new Point(302, 181);
            CustHomeTextBox.Name = "CustHomeTextBox";
            CustHomeTextBox.Size = new Size(270, 37);
            CustHomeTextBox.TabIndex = 10;
            // 
            // CustRegistrationDateTextBox
            // 
            CustRegistrationDateTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustRegistrationDateTextBox.Location = new Point(578, 92);
            CustRegistrationDateTextBox.Name = "CustRegistrationDateTextBox";
            CustRegistrationDateTextBox.Size = new Size(270, 37);
            CustRegistrationDateTextBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(577, 61);
            label7.Name = "label7";
            label7.Size = new Size(150, 29);
            label7.TabIndex = 5;
            label7.Text = "Registration Date";
            // 
            // AddPetButton
            // 
            AddPetButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddPetButton.Location = new Point(773, 346);
            AddPetButton.Name = "AddPetButton";
            AddPetButton.Size = new Size(271, 34);
            AddPetButton.TabIndex = 16;
            AddPetButton.Text = "Add Pet";
            AddPetButton.UseVisualStyleBackColor = true;
            AddPetButton.Click += AddPetButton_Click;
            // 
            // UpdatePetButton
            // 
            UpdatePetButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UpdatePetButton.Location = new Point(774, 409);
            UpdatePetButton.Name = "UpdatePetButton";
            UpdatePetButton.Size = new Size(270, 34);
            UpdatePetButton.TabIndex = 17;
            UpdatePetButton.Text = "Update Pet";
            UpdatePetButton.UseVisualStyleBackColor = true;
            UpdatePetButton.Click += UpdatePetButton_Click;
            // 
            // RemovePetButton
            // 
            RemovePetButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemovePetButton.Location = new Point(775, 472);
            RemovePetButton.Name = "RemovePetButton";
            RemovePetButton.Size = new Size(270, 34);
            RemovePetButton.TabIndex = 18;
            RemovePetButton.Text = "Remove Pet";
            RemovePetButton.UseVisualStyleBackColor = true;
            // 
            // CustomerProfileFormCW
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 517);
            Controls.Add(RemovePetButton);
            Controls.Add(UpdatePetButton);
            Controls.Add(AddPetButton);
            Controls.Add(CustRegistrationDateTextBox);
            Controls.Add(label7);
            Controls.Add(CustHomeTextBox);
            Controls.Add(label17);
            Controls.Add(UpdateCustomerButton);
            Controls.Add(label4);
            Controls.Add(CustPetDataGridView);
            Controls.Add(CustMobileTextbox);
            Controls.Add(CustEmailTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CustLastNameTextBox);
            Controls.Add(CustFirstNameTextBox);
            Name = "CustomerProfileFormCW";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerProfileForm";
            Load += CustomerProfileFormCW_Load;
            ((System.ComponentModel.ISupportInitialize)CustPetDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox CustFirstNameTextBox;
        public TextBox CustLastNameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox CustEmailTextBox;
        private TextBox CustMobileTextbox;
        private DataGridView CustPetDataGridView;
        private Label label4;
        private Button UpdateCustomerButton;
        private Label label17;
        private TextBox CustHomeTextBox;
        private TextBox CustRegistrationDateTextBox;
        private Label label7;
        private Button AddPetButton;
        private Button UpdatePetButton;
        private Button RemovePetButton;
    }
}