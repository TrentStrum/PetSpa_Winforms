namespace TT.Forms.Forms
{
    partial class OLD_SearchCustomerForm
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
            label1 = new Label();
            label2 = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            SearchButton = new Button();
            CustSearchGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CustSearchGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 43);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 102);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(200, 61);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(299, 23);
            FirstNameTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(200, 120);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(299, 23);
            LastNameTextBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(203, 161);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(296, 23);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // CustSearchGridView
            // 
            CustSearchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustSearchGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustSearchGridView.Location = new Point(26, 219);
            CustSearchGridView.Name = "CustSearchGridView";
            CustSearchGridView.RowHeadersVisible = false;
            CustSearchGridView.RowTemplate.Height = 25;
            CustSearchGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustSearchGridView.Size = new Size(711, 306);
            CustSearchGridView.TabIndex = 5;
            CustSearchGridView.CellContentDoubleClick += CustSearchGridView_CellContentDoubleClick;
            // 
            // SearchCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 571);
            Controls.Add(CustSearchGridView);
            Controls.Add(SearchButton);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchCustomerForm";
            Text = "SearchCustomerForm";
            ((System.ComponentModel.ISupportInitialize)CustSearchGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private Button SearchButton;
        private DataGridView CustSearchGridView;
    }
}