namespace TT.Forms.Forms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            personalInfoToolStripMenuItem1 = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            individualToolStripMenuItem = new ToolStripMenuItem();
            businessToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            petToolStripMenuItem = new ToolStripMenuItem();
            searchPetToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, employeeToolStripMenuItem, dashboardToolStripMenuItem, customerToolStripMenuItem, petToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1406, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(110, 22);
            adminToolStripMenuItem.Text = "&Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalInfoToolStripMenuItem1 });
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(71, 20);
            employeeToolStripMenuItem.Text = "&Employee";
            // 
            // personalInfoToolStripMenuItem1
            // 
            personalInfoToolStripMenuItem1.Name = "personalInfoToolStripMenuItem1";
            personalInfoToolStripMenuItem1.Size = new Size(143, 22);
            personalInfoToolStripMenuItem1.Text = "&Personal Info";
            personalInfoToolStripMenuItem1.Click += personalInfoToolStripMenuItem1_Click;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(76, 20);
            dashboardToolStripMenuItem.Text = "&Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, searchToolStripMenuItem });
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(71, 20);
            customerToolStripMenuItem.Text = "&Customer";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { individualToolStripMenuItem, businessToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(109, 22);
            addToolStripMenuItem.Text = "&Add";
            // 
            // individualToolStripMenuItem
            // 
            individualToolStripMenuItem.Name = "individualToolStripMenuItem";
            individualToolStripMenuItem.Size = new Size(126, 22);
            individualToolStripMenuItem.Text = "&Individual";
            individualToolStripMenuItem.Click += individualToolStripMenuItem_Click;
            // 
            // businessToolStripMenuItem
            // 
            businessToolStripMenuItem.Name = "businessToolStripMenuItem";
            businessToolStripMenuItem.Size = new Size(126, 22);
            businessToolStripMenuItem.Text = "&Business";
            businessToolStripMenuItem.Click += businessToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(109, 22);
            searchToolStripMenuItem.Text = "&Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // petToolStripMenuItem
            // 
            petToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchPetToolStripMenuItem });
            petToolStripMenuItem.Name = "petToolStripMenuItem";
            petToolStripMenuItem.Size = new Size(36, 20);
            petToolStripMenuItem.Text = "&Pet";
            // 
            // searchPetToolStripMenuItem
            // 
            searchPetToolStripMenuItem.Name = "searchPetToolStripMenuItem";
            searchPetToolStripMenuItem.Size = new Size(180, 22);
            searchPetToolStripMenuItem.Text = "&Search";
            searchPetToolStripMenuItem.Click += searchPetToolStripMenuItem_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1406, 1061);
            Controls.Add(menuStrip1);
            Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 6, 4, 6);
            Name = "MainMenuForm";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            WindowState = FormWindowState.Maximized;
            Load += MainMenuForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem personalInfoToolStripMenuItem1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem individualToolStripMenuItem;
        private ToolStripMenuItem businessToolStripMenuItem;
        private ToolStripMenuItem petToolStripMenuItem;
        private ToolStripMenuItem searchPetToolStripMenuItem;
    }
}