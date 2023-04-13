namespace TT.Forms.Forms
{
    partial class AdminControlsForm
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
            SearchEmployeeButton = new Button();
            SuspendLayout();
            // 
            // SearchEmployeeButton
            // 
            SearchEmployeeButton.BackColor = Color.DarkTurquoise;
            SearchEmployeeButton.FlatStyle = FlatStyle.Flat;
            SearchEmployeeButton.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchEmployeeButton.ForeColor = Color.White;
            SearchEmployeeButton.Location = new Point(78, 32);
            SearchEmployeeButton.Name = "SearchEmployeeButton";
            SearchEmployeeButton.Size = new Size(189, 33);
            SearchEmployeeButton.TabIndex = 0;
            SearchEmployeeButton.Text = "Search Employee";
            SearchEmployeeButton.UseVisualStyleBackColor = false;
            SearchEmployeeButton.Click += SearchEmployeeButton_Click;
            // 
            // AdminControlsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 91);
            Controls.Add(SearchEmployeeButton);
            Name = "AdminControlsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Admin Controls";
            ResumeLayout(false);
        }

        #endregion

        private Button SearchEmployeeButton;
    }
}