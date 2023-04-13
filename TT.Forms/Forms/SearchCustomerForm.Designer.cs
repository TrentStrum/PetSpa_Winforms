namespace TT.Forms.Forms
{
    partial class SearchCustomerForm
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
            CustSearchPanel = new Panel();
            CustSearchButton = new Button();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            AddCustomerButton = new Button();
            CustSearchGridView = new DataGridView();
            CustSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustSearchGridView).BeginInit();
            SuspendLayout();
            // 
            // CustSearchPanel
            // 
            CustSearchPanel.BackColor = Color.White;
            CustSearchPanel.BorderStyle = BorderStyle.FixedSingle;
            CustSearchPanel.Controls.Add(CustSearchButton);
            CustSearchPanel.Controls.Add(LastNameTextBox);
            CustSearchPanel.Controls.Add(AddCustomerButton);
            CustSearchPanel.Controls.Add(FirstNameTextBox);
            CustSearchPanel.Controls.Add(label2);
            CustSearchPanel.Controls.Add(label1);
            CustSearchPanel.Location = new Point(3, 3);
            CustSearchPanel.Name = "CustSearchPanel";
            CustSearchPanel.Size = new Size(260, 444);
            CustSearchPanel.TabIndex = 0;
            // 
            // CustSearchButton
            // 
            CustSearchButton.BackColor = Color.DarkTurquoise;
            CustSearchButton.FlatAppearance.BorderSize = 0;
            CustSearchButton.FlatStyle = FlatStyle.Flat;
            CustSearchButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustSearchButton.ForeColor = Color.White;
            CustSearchButton.Location = new Point(15, 206);
            CustSearchButton.Name = "CustSearchButton";
            CustSearchButton.Size = new Size(232, 35);
            CustSearchButton.TabIndex = 5;
            CustSearchButton.Text = "Search";
            CustSearchButton.UseVisualStyleBackColor = false;
            CustSearchButton.Click += CustSearchButton_Click;
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
            // AddCustomerButton
            // 
            AddCustomerButton.BackColor = Color.DarkTurquoise;
            AddCustomerButton.FlatAppearance.BorderSize = 0;
            AddCustomerButton.FlatStyle = FlatStyle.Flat;
            AddCustomerButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddCustomerButton.ForeColor = Color.White;
            AddCustomerButton.Location = new Point(15, 377);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(232, 35);
            AddCustomerButton.TabIndex = 8;
            AddCustomerButton.Text = "Add Customer";
            AddCustomerButton.UseVisualStyleBackColor = false;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // CustSearchGridView
            // 
            CustSearchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustSearchGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustSearchGridView.Location = new Point(257, 1);
            CustSearchGridView.Name = "CustSearchGridView";
            CustSearchGridView.RowHeadersVisible = false;
            CustSearchGridView.RowTemplate.Height = 25;
            CustSearchGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustSearchGridView.Size = new Size(811, 446);
            CustSearchGridView.TabIndex = 6;
            CustSearchGridView.CellContentDoubleClick += CustSearchGridView_CellContentDoubleClick_1;
            // 
            // SearchCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1068, 448);
            Controls.Add(CustSearchGridView);
            Controls.Add(CustSearchPanel);
            Name = "SearchCustomerForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Search";
            CustSearchPanel.ResumeLayout(false);
            CustSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustSearchGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private Label label2;
        private Label label1;
        private Button CustSearchButton;
        private Button button5;
        public Panel CustSearchPanel;
        public Button AddCustomerButton;
        private DataGridView CustSearchGridView;
    }
}