namespace TT.Forms.Forms
{
    partial class AddAppointmentForm
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
            CheckInDateTimePicker = new DateTimePicker();
            CheckOutDateTimePicker = new DateTimePicker();
            SubmitButton = new Button();
            label3 = new Label();
            SpecialInstructionsTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(59, 55);
            label1.Name = "label1";
            label1.Size = new Size(123, 29);
            label1.TabIndex = 0;
            label1.Text = "Check-in Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(48, 99);
            label2.Name = "label2";
            label2.Size = new Size(134, 29);
            label2.TabIndex = 1;
            label2.Text = "Check-out Date";
            // 
            // CheckInDateTimePicker
            // 
            CheckInDateTimePicker.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CheckInDateTimePicker.Location = new Point(188, 49);
            CheckInDateTimePicker.Name = "CheckInDateTimePicker";
            CheckInDateTimePicker.Size = new Size(534, 37);
            CheckInDateTimePicker.TabIndex = 2;
            // 
            // CheckOutDateTimePicker
            // 
            CheckOutDateTimePicker.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CheckOutDateTimePicker.Location = new Point(188, 93);
            CheckOutDateTimePicker.Name = "CheckOutDateTimePicker";
            CheckOutDateTimePicker.Size = new Size(534, 37);
            CheckOutDateTimePicker.TabIndex = 3;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.DarkTurquoise;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(188, 205);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(534, 33);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(16, 144);
            label3.Name = "label3";
            label3.Size = new Size(166, 29);
            label3.TabIndex = 5;
            label3.Text = "Special Instructions";
            // 
            // SpecialInstructionsTextBox
            // 
            SpecialInstructionsTextBox.BorderStyle = BorderStyle.None;
            SpecialInstructionsTextBox.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SpecialInstructionsTextBox.Location = new Point(188, 141);
            SpecialInstructionsTextBox.Name = "SpecialInstructionsTextBox";
            SpecialInstructionsTextBox.Size = new Size(534, 30);
            SpecialInstructionsTextBox.TabIndex = 6;
            // 
            // AddAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(760, 268);
            Controls.Add(SpecialInstructionsTextBox);
            Controls.Add(label3);
            Controls.Add(SubmitButton);
            Controls.Add(CheckOutDateTimePicker);
            Controls.Add(CheckInDateTimePicker);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "AddAppointmentForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Appointment";
            Load += AddAppointmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker CheckInDateTimePicker;
        private DateTimePicker CheckOutDateTimePicker;
        private Button SubmitButton;
        private Label label3;
        private TextBox SpecialInstructionsTextBox;
    }
}