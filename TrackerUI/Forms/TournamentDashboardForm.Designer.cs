namespace TrackerUI.Forms
{
    partial class TournamentDashboardForm
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
            loadExistingTournamentDropdown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            panel1 = new Panel();
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            exitProgramButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loadExistingTournamentDropdown
            // 
            loadExistingTournamentDropdown.BackColor = Color.FromArgb(245, 245, 255);
            loadExistingTournamentDropdown.ForeColor = Color.FromArgb(0, 63, 121);
            loadExistingTournamentDropdown.FormattingEnabled = true;
            loadExistingTournamentDropdown.Location = new Point(240, 154);
            loadExistingTournamentDropdown.Name = "loadExistingTournamentDropdown";
            loadExistingTournamentDropdown.Size = new Size(388, 39);
            loadExistingTournamentDropdown.TabIndex = 18;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentLabel.ForeColor = Color.FromArgb(0, 63, 121);
            loadExistingTournamentLabel.Location = new Point(295, 120);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(278, 31);
            loadExistingTournamentLabel.TabIndex = 17;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentButton.ForeColor = Color.FromArgb(0, 63, 121);
            loadTournamentButton.Location = new Point(317, 214);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(234, 50);
            loadTournamentButton.TabIndex = 19;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.FromArgb(0, 63, 121);
            createTournamentButton.Location = new Point(287, 286);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(295, 73);
            createTournamentButton.TabIndex = 23;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 65, 121);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 79);
            panel1.TabIndex = 24;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.FromArgb(245, 245, 255);
            titleLabel.Location = new Point(264, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(604, 79);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Tournament Dashboard";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            titleLabel.MouseDown += titleLabel_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Tracker_Logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // exitProgramButton
            // 
            exitProgramButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            exitProgramButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            exitProgramButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            exitProgramButton.FlatStyle = FlatStyle.Flat;
            exitProgramButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            exitProgramButton.ForeColor = Color.FromArgb(0, 63, 121);
            exitProgramButton.Location = new Point(317, 382);
            exitProgramButton.Name = "exitProgramButton";
            exitProgramButton.Size = new Size(234, 50);
            exitProgramButton.TabIndex = 25;
            exitProgramButton.Text = "Exit Program";
            exitProgramButton.UseVisualStyleBackColor = true;
            exitProgramButton.Click += exitProgramButton_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 255);
            ClientSize = new Size(868, 493);
            Controls.Add(exitProgramButton);
            Controls.Add(panel1);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropdown);
            Controls.Add(loadExistingTournamentLabel);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "TournamentDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TournamentDashboardForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox loadExistingTournamentDropdown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
        private Panel panel1;
        private Label titleLabel;
        private PictureBox pictureBox1;
        private Button exitProgramButton;
    }
}