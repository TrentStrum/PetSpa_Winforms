namespace TT.Forms.Forms
{
    partial class LoginForm
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
            LoginButton = new Button();
            CreateProfileButton = new Button();
            UsernameTextbox = new TextBox();
            PasswordTextBox = new TextBox();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Silver;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Sans Serif Collection", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(56, 439);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(379, 42);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // CreateProfileButton
            // 
            CreateProfileButton.BackColor = Color.White;
            CreateProfileButton.FlatAppearance.BorderSize = 0;
            CreateProfileButton.FlatStyle = FlatStyle.Flat;
            CreateProfileButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CreateProfileButton.ForeColor = Color.DarkTurquoise;
            CreateProfileButton.Location = new Point(316, 385);
            CreateProfileButton.Name = "CreateProfileButton";
            CreateProfileButton.Size = new Size(119, 32);
            CreateProfileButton.TabIndex = 1;
            CreateProfileButton.Text = "New employee?";
            CreateProfileButton.UseVisualStyleBackColor = false;
            CreateProfileButton.Click += CreateProfileButton_Click;
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.BorderStyle = BorderStyle.FixedSingle;
            UsernameTextbox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTextbox.Location = new Point(53, 268);
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.Size = new Size(382, 31);
            UsernameTextbox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(56, 348);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(379, 31);
            PasswordTextBox.TabIndex = 3;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.ForeColor = Color.Gray;
            UsernameLabel.Location = new Point(53, 236);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(95, 29);
            UsernameLabel.TabIndex = 4;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.Gray;
            PasswordLabel.Location = new Point(56, 318);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(92, 29);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(53, 165);
            label1.Name = "label1";
            label1.Size = new Size(382, 54);
            label1.TabIndex = 6;
            label1.Text = "Login to Your Account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_Only;
            pictureBox1.Location = new Point(138, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = LoginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 519);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextbox);
            Controls.Add(CreateProfileButton);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Button CreateProfileButton;
        private TextBox UsernameTextbox;
        private TextBox PasswordTextBox;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label label1;
        private PictureBox pictureBox1;
    }
}