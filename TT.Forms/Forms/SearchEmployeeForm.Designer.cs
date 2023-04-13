namespace TT.Forms.Forms
{
    partial class SearchEmployeeForm
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
            EmployeeSearchPanel = new Panel();
            EmployeeSearchButton = new Button();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            EmployeeSearchGridView = new DataGridView();
            AddEmployeeButton = new Button();
            EmployeeSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeSearchGridView).BeginInit();
            SuspendLayout();
            // 
            // EmployeeSearchPanel
            // 
            EmployeeSearchPanel.BackColor = Color.White;
            EmployeeSearchPanel.BorderStyle = BorderStyle.FixedSingle;
            EmployeeSearchPanel.Controls.Add(EmployeeSearchButton);
            EmployeeSearchPanel.Controls.Add(LastNameTextBox);
            EmployeeSearchPanel.Controls.Add(AddEmployeeButton);
            EmployeeSearchPanel.Controls.Add(FirstNameTextBox);
            EmployeeSearchPanel.Controls.Add(label2);
            EmployeeSearchPanel.Controls.Add(label1);
            EmployeeSearchPanel.Location = new Point(1, 3);
            EmployeeSearchPanel.Name = "EmployeeSearchPanel";
            EmployeeSearchPanel.Size = new Size(260, 339);
            EmployeeSearchPanel.TabIndex = 1;
            // 
            // EmployeeSearchButton
            // 
            EmployeeSearchButton.BackColor = Color.DarkTurquoise;
            EmployeeSearchButton.FlatAppearance.BorderSize = 0;
            EmployeeSearchButton.FlatStyle = FlatStyle.Flat;
            EmployeeSearchButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeSearchButton.ForeColor = Color.White;
            EmployeeSearchButton.Location = new Point(15, 206);
            EmployeeSearchButton.Name = "EmployeeSearchButton";
            EmployeeSearchButton.Size = new Size(232, 35);
            EmployeeSearchButton.TabIndex = 5;
            EmployeeSearchButton.Text = "Search";
            EmployeeSearchButton.UseVisualStyleBackColor = false;
            EmployeeSearchButton.Click += EmployeeSearchButton_Click;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            LastNameTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTextBox.Location = new Point(15, 140);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(232, 37);
            LastNameTextBox.TabIndex = 4;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            FirstNameTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTextBox.Location = new Point(15, 56);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(232, 37);
            FirstNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(15, 108);
            label2.Name = "label2";
            label2.Size = new Size(97, 29);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(15, 24);
            label1.Name = "label1";
            label1.Size = new Size(98, 29);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // EmployeeSearchGridView
            // 
            EmployeeSearchGridView.AllowUserToAddRows = false;
            EmployeeSearchGridView.AllowUserToDeleteRows = false;
            EmployeeSearchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeSearchGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeSearchGridView.Location = new Point(261, 3);
            EmployeeSearchGridView.Name = "EmployeeSearchGridView";
            EmployeeSearchGridView.ReadOnly = true;
            EmployeeSearchGridView.RowHeadersVisible = false;
            EmployeeSearchGridView.RowTemplate.Height = 25;
            EmployeeSearchGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeSearchGridView.Size = new Size(808, 339);
            EmployeeSearchGridView.TabIndex = 7;
            EmployeeSearchGridView.CellContentDoubleClick += EmployeeSearchGridView_CellContentDoubleClick;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.BackColor = Color.DarkTurquoise;
            AddEmployeeButton.FlatAppearance.BorderSize = 0;
            AddEmployeeButton.FlatStyle = FlatStyle.Flat;
            AddEmployeeButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddEmployeeButton.ForeColor = Color.White;
            AddEmployeeButton.Location = new Point(15, 291);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new Size(232, 35);
            AddEmployeeButton.TabIndex = 8;
            AddEmployeeButton.Text = "Add Employee";
            AddEmployeeButton.UseVisualStyleBackColor = false;
            AddEmployeeButton.Click += AddEmployeeButton_Click;
            // 
            // SearchEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 344);
            Controls.Add(EmployeeSearchGridView);
            Controls.Add(EmployeeSearchPanel);
            Name = "SearchEmployeeForm";
            ShowIcon = false;
            Text = "Search Employee";
            EmployeeSearchPanel.ResumeLayout(false);
            EmployeeSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeSearchGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel EmployeeSearchPanel;
        private Button EmployeeSearchButton;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private Label label2;
        private Label label1;
        private DataGridView EmployeeSearchGridView;
        public Button AddEmployeeButton;
    }
}