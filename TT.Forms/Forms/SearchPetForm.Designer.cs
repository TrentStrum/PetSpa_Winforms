namespace TT.Forms
{
    partial class SearchPetForm
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
            PetSearchGridView = new DataGridView();
            EmployeeSearchPanel = new Panel();
            label6 = new Label();
            PetSearchButton = new Button();
            label5 = new Label();
            PetNameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PetSearchGridView).BeginInit();
            EmployeeSearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PetSearchGridView
            // 
            PetSearchGridView.AllowUserToAddRows = false;
            PetSearchGridView.AllowUserToDeleteRows = false;
            PetSearchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PetSearchGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PetSearchGridView.Location = new Point(261, 0);
            PetSearchGridView.Name = "PetSearchGridView";
            PetSearchGridView.ReadOnly = true;
            PetSearchGridView.RowHeadersVisible = false;
            PetSearchGridView.RowTemplate.Height = 25;
            PetSearchGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PetSearchGridView.Size = new Size(808, 444);
            PetSearchGridView.TabIndex = 8;
            PetSearchGridView.CellContentClick += PetSearchGridView_CellContentClick;
            PetSearchGridView.CellContentDoubleClick += PetSearchGridView_CellContentDoubleClick;
            // 
            // EmployeeSearchPanel
            // 
            EmployeeSearchPanel.BackColor = Color.White;
            EmployeeSearchPanel.BorderStyle = BorderStyle.FixedSingle;
            EmployeeSearchPanel.Controls.Add(label6);
            EmployeeSearchPanel.Controls.Add(PetSearchButton);
            EmployeeSearchPanel.Controls.Add(label5);
            EmployeeSearchPanel.Controls.Add(PetNameTextBox);
            EmployeeSearchPanel.Controls.Add(label3);
            EmployeeSearchPanel.Controls.Add(label4);
            EmployeeSearchPanel.Controls.Add(LastNameTextBox);
            EmployeeSearchPanel.Controls.Add(FirstNameTextBox);
            EmployeeSearchPanel.Controls.Add(label2);
            EmployeeSearchPanel.Controls.Add(label1);
            EmployeeSearchPanel.Location = new Point(1, 0);
            EmployeeSearchPanel.Name = "EmployeeSearchPanel";
            EmployeeSearchPanel.Size = new Size(260, 444);
            EmployeeSearchPanel.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(104, 215);
            label6.Name = "label6";
            label6.Size = new Size(33, 29);
            label6.TabIndex = 12;
            label6.Text = "Or";
            // 
            // PetSearchButton
            // 
            PetSearchButton.BackColor = Color.DarkTurquoise;
            PetSearchButton.FlatAppearance.BorderSize = 0;
            PetSearchButton.FlatStyle = FlatStyle.Flat;
            PetSearchButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PetSearchButton.ForeColor = Color.White;
            PetSearchButton.Location = new Point(15, 385);
            PetSearchButton.Name = "PetSearchButton";
            PetSearchButton.Size = new Size(232, 35);
            PetSearchButton.TabIndex = 11;
            PetSearchButton.Text = "Search";
            PetSearchButton.UseVisualStyleBackColor = false;
            PetSearchButton.Click += PetSearchButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(47, 253);
            label5.Name = "label5";
            label5.Size = new Size(122, 29);
            label5.TabIndex = 10;
            label5.Text = "Search by Pet";
            // 
            // PetNameTextBox
            // 
            PetNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            PetNameTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PetNameTextBox.Location = new Point(15, 321);
            PetNameTextBox.Name = "PetNameTextBox";
            PetNameTextBox.Size = new Size(232, 37);
            PetNameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(15, 289);
            label3.Name = "label3";
            label3.Size = new Size(90, 29);
            label3.TabIndex = 8;
            label3.Text = "Pet Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(47, 8);
            label4.Name = "label4";
            label4.Size = new Size(172, 29);
            label4.TabIndex = 7;
            label4.Text = "Search by Customer";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            LastNameTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTextBox.Location = new Point(15, 159);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(232, 37);
            LastNameTextBox.TabIndex = 4;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            FirstNameTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTextBox.Location = new Point(15, 75);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(232, 37);
            FirstNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(15, 127);
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
            label1.Location = new Point(15, 43);
            label1.Name = "label1";
            label1.Size = new Size(98, 29);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // SearchPetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 444);
            Controls.Add(EmployeeSearchPanel);
            Controls.Add(PetSearchGridView);
            Name = "SearchPetForm";
            ShowIcon = false;
            Text = "Search Pet";
            ((System.ComponentModel.ISupportInitialize)PetSearchGridView).EndInit();
            EmployeeSearchPanel.ResumeLayout(false);
            EmployeeSearchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PetSearchGridView;
        public Panel EmployeeSearchPanel;
        private Button EmployeeSearchButton;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox PetNameTextBox;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button PetSearchButton;
    }
}