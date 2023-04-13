namespace TT.Forms.Forms
{
    partial class CustomerProfileForm
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
            customerBindingSource = new BindingSource(components);
            customerRepositoryBindingSource = new BindingSource(components);
            customerRepositoryBindingSource1 = new BindingSource(components);
            CustomerViewAddressButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CustPetDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerRepositoryBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // CustFirstNameTextBox
            // 
            CustFirstNameTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustFirstNameTextBox.Location = new Point(15, 117);
            CustFirstNameTextBox.Name = "CustFirstNameTextBox";
            CustFirstNameTextBox.Size = new Size(270, 37);
            CustFirstNameTextBox.TabIndex = 0;
            // 
            // CustLastNameTextBox
            // 
            CustLastNameTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustLastNameTextBox.Location = new Point(393, 117);
            CustLastNameTextBox.Name = "CustLastNameTextBox";
            CustLastNameTextBox.Size = new Size(270, 37);
            CustLastNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(393, 27);
            label1.Name = "label1";
            label1.Size = new Size(232, 39);
            label1.TabIndex = 2;
            label1.Text = "Customer Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(15, 86);
            label2.Name = "label2";
            label2.Size = new Size(98, 29);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(393, 86);
            label3.Name = "label3";
            label3.Size = new Size(97, 29);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(771, 174);
            label5.Name = "label5";
            label5.Size = new Size(57, 29);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(15, 174);
            label6.Name = "label6";
            label6.Size = new Size(131, 29);
            label6.TabIndex = 7;
            label6.Text = "Mobile Number";
            // 
            // CustEmailTextBox
            // 
            CustEmailTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustEmailTextBox.Location = new Point(771, 206);
            CustEmailTextBox.Name = "CustEmailTextBox";
            CustEmailTextBox.Size = new Size(270, 37);
            CustEmailTextBox.TabIndex = 8;
            // 
            // CustMobileTextbox
            // 
            CustMobileTextbox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustMobileTextbox.Location = new Point(15, 206);
            CustMobileTextbox.Name = "CustMobileTextbox";
            CustMobileTextbox.Size = new Size(270, 37);
            CustMobileTextbox.TabIndex = 9;
            // 
            // CustPetDataGridView
            // 
            CustPetDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustPetDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustPetDataGridView.Location = new Point(12, 432);
            CustPetDataGridView.Name = "CustPetDataGridView";
            CustPetDataGridView.RowHeadersVisible = false;
            CustPetDataGridView.RowTemplate.Height = 25;
            CustPetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustPetDataGridView.Size = new Size(745, 161);
            CustPetDataGridView.TabIndex = 10;
            CustPetDataGridView.CellContentDoubleClick += CustPetDataGridView_CellContentDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(349, 390);
            label4.Name = "label4";
            label4.Size = new Size(76, 39);
            label4.TabIndex = 11;
            label4.Text = "Pets";
            // 
            // UpdateCustomerButton
            // 
            UpdateCustomerButton.BackColor = Color.DarkTurquoise;
            UpdateCustomerButton.FlatStyle = FlatStyle.Flat;
            UpdateCustomerButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateCustomerButton.ForeColor = Color.White;
            UpdateCustomerButton.Location = new Point(393, 287);
            UpdateCustomerButton.Name = "UpdateCustomerButton";
            UpdateCustomerButton.Size = new Size(270, 38);
            UpdateCustomerButton.TabIndex = 12;
            UpdateCustomerButton.Text = "Update Customer";
            UpdateCustomerButton.UseVisualStyleBackColor = false;
            UpdateCustomerButton.Click += UpdateCustomerButton_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.GrayText;
            label17.Location = new Point(393, 174);
            label17.Name = "label17";
            label17.Size = new Size(126, 29);
            label17.TabIndex = 23;
            label17.Text = "Home Number";
            // 
            // CustHomeTextBox
            // 
            CustHomeTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustHomeTextBox.Location = new Point(393, 206);
            CustHomeTextBox.Name = "CustHomeTextBox";
            CustHomeTextBox.Size = new Size(270, 37);
            CustHomeTextBox.TabIndex = 26;
            // 
            // CustRegistrationDateTextBox
            // 
            CustRegistrationDateTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustRegistrationDateTextBox.Location = new Point(771, 117);
            CustRegistrationDateTextBox.Name = "CustRegistrationDateTextBox";
            CustRegistrationDateTextBox.Size = new Size(270, 37);
            CustRegistrationDateTextBox.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(770, 86);
            label7.Name = "label7";
            label7.Size = new Size(150, 29);
            label7.TabIndex = 27;
            label7.Text = "Registration Date";
            // 
            // AddPetButton
            // 
            AddPetButton.BackColor = Color.DarkTurquoise;
            AddPetButton.FlatStyle = FlatStyle.Flat;
            AddPetButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddPetButton.ForeColor = Color.White;
            AddPetButton.Location = new Point(770, 432);
            AddPetButton.Name = "AddPetButton";
            AddPetButton.Size = new Size(271, 34);
            AddPetButton.TabIndex = 29;
            AddPetButton.Text = "Add Pet";
            AddPetButton.UseVisualStyleBackColor = false;
            AddPetButton.Click += AddPetButton_Click;
            // 
            // UpdatePetButton
            // 
            UpdatePetButton.BackColor = Color.DarkTurquoise;
            UpdatePetButton.FlatStyle = FlatStyle.Flat;
            UpdatePetButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UpdatePetButton.ForeColor = Color.White;
            UpdatePetButton.Location = new Point(771, 495);
            UpdatePetButton.Name = "UpdatePetButton";
            UpdatePetButton.Size = new Size(270, 34);
            UpdatePetButton.TabIndex = 31;
            UpdatePetButton.Text = "Update Pet";
            UpdatePetButton.UseVisualStyleBackColor = false;
            UpdatePetButton.Click += UpdatePetButton_Click;
            // 
            // RemovePetButton
            // 
            RemovePetButton.BackColor = Color.DarkTurquoise;
            RemovePetButton.FlatStyle = FlatStyle.Flat;
            RemovePetButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemovePetButton.ForeColor = Color.White;
            RemovePetButton.Location = new Point(772, 558);
            RemovePetButton.Name = "RemovePetButton";
            RemovePetButton.Size = new Size(270, 34);
            RemovePetButton.TabIndex = 32;
            RemovePetButton.Text = "Remove Pet";
            RemovePetButton.UseVisualStyleBackColor = false;
            RemovePetButton.Click += RemovePetButton_Click;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Data.Entities.Customer);
            // 
            // customerRepositoryBindingSource
            // 
            customerRepositoryBindingSource.DataSource = typeof(Data.Repositories.CustomerRepository);
            // 
            // customerRepositoryBindingSource1
            // 
            customerRepositoryBindingSource1.DataSource = typeof(Data.Repositories.CustomerRepository);
            // 
            // CustomerViewAddressButton
            // 
            CustomerViewAddressButton.Cursor = Cursors.Hand;
            CustomerViewAddressButton.FlatAppearance.BorderSize = 0;
            CustomerViewAddressButton.FlatStyle = FlatStyle.Flat;
            CustomerViewAddressButton.Font = new Font("Sans Serif Collection", 6F, FontStyle.Underline, GraphicsUnit.Point);
            CustomerViewAddressButton.Location = new Point(899, 249);
            CustomerViewAddressButton.Name = "CustomerViewAddressButton";
            CustomerViewAddressButton.Size = new Size(142, 38);
            CustomerViewAddressButton.TabIndex = 50;
            CustomerViewAddressButton.Text = "View Address";
            CustomerViewAddressButton.UseVisualStyleBackColor = true;
            CustomerViewAddressButton.Click += CustomerViewAddressButton_Click;
            // 
            // CustomerProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 607);
            Controls.Add(CustomerViewAddressButton);
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
            Name = "CustomerProfileForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Profile";
            Load += CustomerProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)CustPetDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerRepositoryBindingSource1).EndInit();
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
        private BindingSource customerBindingSource;
        private BindingSource customerRepositoryBindingSource;
        private BindingSource customerRepositoryBindingSource1;
        private Button CustomerViewAddressButton;
    }
}