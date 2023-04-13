namespace TT.Forms.Forms
{
    partial class PetProfileForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            RecentApptDataGridView = new DataGridView();
            NameTextBox = new TextBox();
            SpeciesTextBox = new TextBox();
            BreedTextBox = new TextBox();
            AgeTextBox = new TextBox();
            WeightTextBox = new TextBox();
            SexTextBox = new TextBox();
            UpdatePetButton = new Button();
            DeletePetButton = new Button();
            NewAppointmentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)RecentApptDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(59, 41);
            label1.Name = "label1";
            label1.Size = new Size(60, 29);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(42, 89);
            label2.Name = "label2";
            label2.Size = new Size(77, 29);
            label2.TabIndex = 1;
            label2.Text = "Species";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(58, 138);
            label3.Name = "label3";
            label3.Size = new Size(61, 29);
            label3.TabIndex = 2;
            label3.Text = "Breed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(74, 183);
            label4.Name = "label4";
            label4.Size = new Size(45, 29);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(50, 229);
            label5.Name = "label5";
            label5.Size = new Size(69, 29);
            label5.TabIndex = 4;
            label5.Text = "Weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(75, 275);
            label6.Name = "label6";
            label6.Size = new Size(44, 29);
            label6.TabIndex = 5;
            label6.Text = "Sex";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(367, 41);
            label7.Name = "label7";
            label7.Size = new Size(116, 29);
            label7.TabIndex = 6;
            label7.Text = "Recent Visits";
            // 
            // RecentApptDataGridView
            // 
            RecentApptDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecentApptDataGridView.Location = new Point(367, 73);
            RecentApptDataGridView.Name = "RecentApptDataGridView";
            RecentApptDataGridView.RowTemplate.Height = 25;
            RecentApptDataGridView.ShowRowErrors = false;
            RecentApptDataGridView.Size = new Size(488, 150);
            RecentApptDataGridView.TabIndex = 7;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(125, 38);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(208, 37);
            NameTextBox.TabIndex = 8;
            // 
            // SpeciesTextBox
            // 
            SpeciesTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SpeciesTextBox.Location = new Point(125, 86);
            SpeciesTextBox.Name = "SpeciesTextBox";
            SpeciesTextBox.Size = new Size(208, 37);
            SpeciesTextBox.TabIndex = 9;
            // 
            // BreedTextBox
            // 
            BreedTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BreedTextBox.Location = new Point(125, 135);
            BreedTextBox.Name = "BreedTextBox";
            BreedTextBox.Size = new Size(208, 37);
            BreedTextBox.TabIndex = 10;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AgeTextBox.Location = new Point(125, 180);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(208, 37);
            AgeTextBox.TabIndex = 11;
            // 
            // WeightTextBox
            // 
            WeightTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            WeightTextBox.Location = new Point(125, 226);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.Size = new Size(208, 37);
            WeightTextBox.TabIndex = 12;
            // 
            // SexTextBox
            // 
            SexTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SexTextBox.Location = new Point(125, 272);
            SexTextBox.Name = "SexTextBox";
            SexTextBox.Size = new Size(208, 37);
            SexTextBox.TabIndex = 13;
            // 
            // UpdatePetButton
            // 
            UpdatePetButton.BackColor = Color.DarkTurquoise;
            UpdatePetButton.FlatStyle = FlatStyle.Flat;
            UpdatePetButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UpdatePetButton.ForeColor = Color.White;
            UpdatePetButton.Location = new Point(125, 331);
            UpdatePetButton.Name = "UpdatePetButton";
            UpdatePetButton.Size = new Size(208, 35);
            UpdatePetButton.TabIndex = 14;
            UpdatePetButton.Text = "Update Pet";
            UpdatePetButton.UseVisualStyleBackColor = false;
            UpdatePetButton.Click += UpdatePetButton_Click;
            // 
            // DeletePetButton
            // 
            DeletePetButton.BackColor = Color.DarkTurquoise;
            DeletePetButton.FlatStyle = FlatStyle.Flat;
            DeletePetButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeletePetButton.ForeColor = Color.White;
            DeletePetButton.Location = new Point(125, 372);
            DeletePetButton.Name = "DeletePetButton";
            DeletePetButton.Size = new Size(208, 36);
            DeletePetButton.TabIndex = 15;
            DeletePetButton.Text = "Delete Pet";
            DeletePetButton.UseVisualStyleBackColor = false;
            DeletePetButton.Click += DeletePetButton_Click;
            // 
            // NewAppointmentButton
            // 
            NewAppointmentButton.BackColor = Color.DarkTurquoise;
            NewAppointmentButton.FlatStyle = FlatStyle.Flat;
            NewAppointmentButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NewAppointmentButton.ForeColor = Color.White;
            NewAppointmentButton.Location = new Point(647, 238);
            NewAppointmentButton.Name = "NewAppointmentButton";
            NewAppointmentButton.Size = new Size(208, 36);
            NewAppointmentButton.TabIndex = 16;
            NewAppointmentButton.Text = "New Appointment";
            NewAppointmentButton.UseVisualStyleBackColor = false;
            NewAppointmentButton.Click += NewAppointmentButton_Click;
            // 
            // PetProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 420);
            Controls.Add(NewAppointmentButton);
            Controls.Add(DeletePetButton);
            Controls.Add(UpdatePetButton);
            Controls.Add(SexTextBox);
            Controls.Add(WeightTextBox);
            Controls.Add(AgeTextBox);
            Controls.Add(BreedTextBox);
            Controls.Add(SpeciesTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(RecentApptDataGridView);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PetProfileForm";
            ShowIcon = false;
            Text = "Pet Profile";
            Load += PetProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)RecentApptDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView RecentApptDataGridView;
        private TextBox NameTextBox;
        private TextBox SpeciesTextBox;
        private TextBox BreedTextBox;
        private TextBox AgeTextBox;
        private TextBox WeightTextBox;
        private TextBox SexTextBox;
        private Button UpdatePetButton;
        private Button DeletePetButton;
        private Button NewAppointmentButton;
    }
}