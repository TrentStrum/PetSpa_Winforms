namespace TT.Forms.Forms
{
    partial class DashboardForm
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
            Button CustomerSearchButton;
            Button AddCustomerButton;
            Button SearchPetButton;
            TodaysCheckInGridView = new DataGridView();
            label1 = new Label();
            appointmentRepositoryBindingSource = new BindingSource(components);
            appointmentBindingSource = new BindingSource(components);
            appointmentRepositoryBindingSource1 = new BindingSource(components);
            TodaysCheckOutGridView = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            CustomerSearchButton = new Button();
            AddCustomerButton = new Button();
            SearchPetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TodaysCheckInGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appointmentRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appointmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appointmentRepositoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TodaysCheckOutGridView).BeginInit();
            SuspendLayout();
            // 
            // CustomerSearchButton
            // 
            CustomerSearchButton.Anchor = AnchorStyles.Top;
            CustomerSearchButton.BackColor = Color.DarkTurquoise;
            CustomerSearchButton.FlatAppearance.BorderColor = Color.White;
            CustomerSearchButton.FlatAppearance.BorderSize = 0;
            CustomerSearchButton.FlatStyle = FlatStyle.Flat;
            CustomerSearchButton.Font = new Font("Sans Serif Collection", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerSearchButton.ForeColor = Color.White;
            CustomerSearchButton.Location = new Point(101, 401);
            CustomerSearchButton.Margin = new Padding(50, 3, 3, 3);
            CustomerSearchButton.Name = "CustomerSearchButton";
            CustomerSearchButton.Size = new Size(362, 41);
            CustomerSearchButton.TabIndex = 0;
            CustomerSearchButton.Text = "Search Customer";
            CustomerSearchButton.UseVisualStyleBackColor = false;
            CustomerSearchButton.Click += CustomerSearchButton_Click;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Anchor = AnchorStyles.Top;
            AddCustomerButton.BackColor = Color.DarkTurquoise;
            AddCustomerButton.FlatAppearance.BorderColor = Color.White;
            AddCustomerButton.FlatAppearance.BorderSize = 0;
            AddCustomerButton.FlatStyle = FlatStyle.Flat;
            AddCustomerButton.Font = new Font("Sans Serif Collection", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AddCustomerButton.ForeColor = Color.White;
            AddCustomerButton.Location = new Point(101, 462);
            AddCustomerButton.Margin = new Padding(50, 3, 3, 3);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(362, 41);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add Customer";
            AddCustomerButton.UseVisualStyleBackColor = false;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // SearchPetButton
            // 
            SearchPetButton.Anchor = AnchorStyles.Top;
            SearchPetButton.BackColor = Color.DarkTurquoise;
            SearchPetButton.FlatAppearance.BorderColor = Color.White;
            SearchPetButton.FlatAppearance.BorderSize = 0;
            SearchPetButton.FlatStyle = FlatStyle.Flat;
            SearchPetButton.Font = new Font("Sans Serif Collection", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SearchPetButton.ForeColor = Color.White;
            SearchPetButton.Location = new Point(484, 401);
            SearchPetButton.Margin = new Padding(50, 3, 3, 3);
            SearchPetButton.Name = "SearchPetButton";
            SearchPetButton.Size = new Size(362, 41);
            SearchPetButton.TabIndex = 3;
            SearchPetButton.Text = "Search Pet";
            SearchPetButton.UseVisualStyleBackColor = false;
            SearchPetButton.Click += SearchPetButton_Click;
            // 
            // TodaysCheckInGridView
            // 
            TodaysCheckInGridView.AllowUserToAddRows = false;
            TodaysCheckInGridView.AllowUserToDeleteRows = false;
            TodaysCheckInGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TodaysCheckInGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TodaysCheckInGridView.Location = new Point(12, 88);
            TodaysCheckInGridView.MultiSelect = false;
            TodaysCheckInGridView.Name = "TodaysCheckInGridView";
            TodaysCheckInGridView.ReadOnly = true;
            TodaysCheckInGridView.RowHeadersVisible = false;
            TodaysCheckInGridView.RowTemplate.Height = 25;
            TodaysCheckInGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TodaysCheckInGridView.Size = new Size(926, 130);
            TodaysCheckInGridView.TabIndex = 7;
            TodaysCheckInGridView.TabStop = false;
            TodaysCheckInGridView.CellContentClick += TodayScheduleDataGridView_CellContentClick;
            TodaysCheckInGridView.CellContentDoubleClick += TodaysCheckInGridView_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.Font = new Font("Sans Serif Collection", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(282, 21);
            label1.Name = "label1";
            label1.Size = new Size(362, 61);
            label1.TabIndex = 4;
            label1.Text = "Today's Schedule";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // appointmentRepositoryBindingSource
            // 
            appointmentRepositoryBindingSource.DataSource = typeof(Data.Repositories.AppointmentRepository);
            // 
            // appointmentBindingSource
            // 
            appointmentBindingSource.DataSource = typeof(Data.Entities.Appointment);
            // 
            // appointmentRepositoryBindingSource1
            // 
            appointmentRepositoryBindingSource1.DataSource = typeof(Data.Repositories.AppointmentRepository);
            // 
            // TodaysCheckOutGridView
            // 
            TodaysCheckOutGridView.AllowUserToAddRows = false;
            TodaysCheckOutGridView.AllowUserToDeleteRows = false;
            TodaysCheckOutGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TodaysCheckOutGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TodaysCheckOutGridView.Location = new Point(12, 253);
            TodaysCheckOutGridView.MultiSelect = false;
            TodaysCheckOutGridView.Name = "TodaysCheckOutGridView";
            TodaysCheckOutGridView.ReadOnly = true;
            TodaysCheckOutGridView.RowHeadersVisible = false;
            TodaysCheckOutGridView.RowTemplate.Height = 25;
            TodaysCheckOutGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TodaysCheckOutGridView.Size = new Size(926, 142);
            TodaysCheckOutGridView.TabIndex = 8;
            TodaysCheckOutGridView.TabStop = false;
            TodaysCheckOutGridView.CellContentDoubleClick += TodaysCheckOutGridView_CellContentDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(81, 29);
            label2.TabIndex = 5;
            label2.Text = "Check In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(12, 221);
            label3.Name = "label3";
            label3.Size = new Size(96, 29);
            label3.TabIndex = 6;
            label3.Text = "Check Out";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 517);
            Controls.Add(SearchPetButton);
            Controls.Add(AddCustomerButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TodaysCheckOutGridView);
            Controls.Add(CustomerSearchButton);
            Controls.Add(label1);
            Controls.Add(TodaysCheckInGridView);
            Name = "DashboardForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)TodaysCheckInGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)appointmentRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)appointmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)appointmentRepositoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TodaysCheckOutGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TodaysCheckInGridView;
        private Label label1;
        private Button CustomerSearchButton;
        private BindingSource appointmentRepositoryBindingSource;
        private BindingSource appointmentBindingSource;
        private BindingSource appointmentRepositoryBindingSource1;
        private DataGridView TodaysCheckOutGridView;
        private Label label2;
        private Label label3;
    }
}