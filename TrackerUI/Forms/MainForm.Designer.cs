namespace TrackerUI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelTitle = new Panel();
            MinimizeWindow = new FontAwesome.Sharp.IconButton();
            MaxWindowButton = new FontAwesome.Sharp.IconButton();
            CloseProgramButton = new FontAwesome.Sharp.IconButton();
            CurrentFormLabel = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panelMenu = new Panel();
            CloseCurrentFormButton = new Button();
            panel2 = new Panel();
            panelDesktop = new Panel();
            homePageLogo = new PictureBox();
            tournamentDashboardButton = new Button();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homePageLogo).BeginInit();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(0, 63, 121);
            panelTitle.Controls.Add(MinimizeWindow);
            panelTitle.Controls.Add(MaxWindowButton);
            panelTitle.Controls.Add(CloseProgramButton);
            panelTitle.Controls.Add(CurrentFormLabel);
            panelTitle.Controls.Add(pictureBox1);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1382, 81);
            panelTitle.TabIndex = 0;
            panelTitle.Paint += panelTitle_Paint;
            panelTitle.MouseDown += panelTitle_MouseDown;
            // 
            // MinimizeWindow
            // 
            MinimizeWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeWindow.BackColor = Color.FromArgb(0, 63, 121);
            MinimizeWindow.FlatAppearance.BorderSize = 0;
            MinimizeWindow.FlatStyle = FlatStyle.Flat;
            MinimizeWindow.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            MinimizeWindow.IconColor = Color.White;
            MinimizeWindow.IconFont = FontAwesome.Sharp.IconFont.Solid;
            MinimizeWindow.IconSize = 20;
            MinimizeWindow.Location = new Point(1208, 0);
            MinimizeWindow.Name = "MinimizeWindow";
            MinimizeWindow.Size = new Size(58, 36);
            MinimizeWindow.TabIndex = 4;
            MinimizeWindow.UseVisualStyleBackColor = false;
            MinimizeWindow.Click += MinimizeWindow_Click;
            // 
            // MaxWindowButton
            // 
            MaxWindowButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaxWindowButton.BackColor = Color.FromArgb(0, 63, 121);
            MaxWindowButton.FlatAppearance.BorderSize = 0;
            MaxWindowButton.FlatStyle = FlatStyle.Flat;
            MaxWindowButton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            MaxWindowButton.IconColor = Color.White;
            MaxWindowButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            MaxWindowButton.IconSize = 20;
            MaxWindowButton.Location = new Point(1266, 0);
            MaxWindowButton.Name = "MaxWindowButton";
            MaxWindowButton.Size = new Size(58, 36);
            MaxWindowButton.TabIndex = 3;
            MaxWindowButton.UseVisualStyleBackColor = false;
            MaxWindowButton.Click += MaxWindowButton_Click;
            // 
            // CloseProgramButton
            // 
            CloseProgramButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseProgramButton.BackColor = Color.FromArgb(0, 63, 121);
            CloseProgramButton.FlatAppearance.BorderSize = 0;
            CloseProgramButton.FlatAppearance.MouseOverBackColor = Color.Red;
            CloseProgramButton.FlatStyle = FlatStyle.Flat;
            CloseProgramButton.IconChar = FontAwesome.Sharp.IconChar.X;
            CloseProgramButton.IconColor = Color.White;
            CloseProgramButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            CloseProgramButton.IconSize = 20;
            CloseProgramButton.Location = new Point(1324, 0);
            CloseProgramButton.Name = "CloseProgramButton";
            CloseProgramButton.Size = new Size(58, 36);
            CloseProgramButton.TabIndex = 2;
            CloseProgramButton.UseVisualStyleBackColor = false;
            CloseProgramButton.Click += CloseProgramButton_Click;
            // 
            // CurrentFormLabel
            // 
            CurrentFormLabel.Dock = DockStyle.Left;
            CurrentFormLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            CurrentFormLabel.ForeColor = Color.FromArgb(245, 245, 255);
            CurrentFormLabel.Location = new Point(261, 0);
            CurrentFormLabel.Margin = new Padding(0);
            CurrentFormLabel.Name = "CurrentFormLabel";
            CurrentFormLabel.Size = new Size(299, 81);
            CurrentFormLabel.TabIndex = 1;
            CurrentFormLabel.Text = "Home";
            CurrentFormLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 49, 94);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 3);
            panel1.TabIndex = 1;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 63, 121);
            panelMenu.Controls.Add(tournamentDashboardButton);
            panelMenu.Controls.Add(CloseCurrentFormButton);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 84);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1382, 59);
            panelMenu.TabIndex = 2;
            // 
            // CloseCurrentFormButton
            // 
            CloseCurrentFormButton.Dock = DockStyle.Right;
            CloseCurrentFormButton.FlatAppearance.BorderSize = 0;
            CloseCurrentFormButton.FlatStyle = FlatStyle.Flat;
            CloseCurrentFormButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            CloseCurrentFormButton.ForeColor = Color.FromArgb(245, 245, 255);
            CloseCurrentFormButton.Location = new Point(1266, 0);
            CloseCurrentFormButton.Name = "CloseCurrentFormButton";
            CloseCurrentFormButton.Size = new Size(116, 59);
            CloseCurrentFormButton.TabIndex = 4;
            CloseCurrentFormButton.Text = "Close";
            CloseCurrentFormButton.UseVisualStyleBackColor = true;
            CloseCurrentFormButton.Click += CloseCurrentFormButton_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 59);
            panel2.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(245, 245, 255);
            panelDesktop.Controls.Add(homePageLogo);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(0, 143);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1382, 710);
            panelDesktop.TabIndex = 3;
            // 
            // homePageLogo
            // 
            homePageLogo.Dock = DockStyle.Fill;
            homePageLogo.Image = (Image)resources.GetObject("homePageLogo.Image");
            homePageLogo.Location = new Point(0, 0);
            homePageLogo.Name = "homePageLogo";
            homePageLogo.Size = new Size(1382, 710);
            homePageLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            homePageLogo.TabIndex = 0;
            homePageLogo.TabStop = false;
            // 
            // tournamentDashboardButton
            // 
            tournamentDashboardButton.Dock = DockStyle.Left;
            tournamentDashboardButton.FlatAppearance.BorderSize = 0;
            tournamentDashboardButton.FlatStyle = FlatStyle.Flat;
            tournamentDashboardButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tournamentDashboardButton.ForeColor = Color.FromArgb(245, 245, 255);
            tournamentDashboardButton.Location = new Point(50, 0);
            tournamentDashboardButton.Name = "tournamentDashboardButton";
            tournamentDashboardButton.Size = new Size(211, 59);
            tournamentDashboardButton.TabIndex = 5;
            tournamentDashboardButton.Text = "Tournament Dashboard";
            tournamentDashboardButton.UseVisualStyleBackColor = true;
            tournamentDashboardButton.Click += tournamentDashboardButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(panelDesktop);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Controls.Add(panelTitle);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            SizeChanged += MainForm_SizeChanged;
            Resize += MainForm_Resize;
            panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)homePageLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panelMenu;
        private Panel panelDesktop;
        private Label CurrentFormLabel;
        private FontAwesome.Sharp.IconButton CloseProgramButton;
        private FontAwesome.Sharp.IconButton MinimizeWindow;
        private FontAwesome.Sharp.IconButton MaxWindowButton;
        private Panel panel2;
        private Button CloseCurrentFormButton;
        private PictureBox homePageLogo;
        private Button tournamentDashboardButton;
    }
}