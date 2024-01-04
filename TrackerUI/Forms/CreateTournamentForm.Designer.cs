namespace TrackerUI.Forms
{
    partial class CreateTournamentForm
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
            tournamentNameLabel = new Label();
            tournamentNameValue = new TextBox();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLinkLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentTeamsListBox = new ListBox();
            label1 = new Label();
            removeSelectedPlayersButton = new Button();
            removeSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            panel1 = new Panel();
            titlePanel = new Label();
            pictureBox1 = new PictureBox();
            closeFormButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.ForeColor = Color.FromArgb(0, 63, 121);
            tournamentNameLabel.Location = new Point(15, 113);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(203, 31);
            tournamentNameLabel.TabIndex = 0;
            tournamentNameLabel.Text = "Tournament Name\r\n";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.BackColor = Color.FromArgb(245, 245, 255);
            tournamentNameValue.BorderStyle = BorderStyle.FixedSingle;
            tournamentNameValue.Location = new Point(20, 147);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(280, 38);
            tournamentNameValue.TabIndex = 1;
            // 
            // entryFeeValue
            // 
            entryFeeValue.BackColor = Color.FromArgb(245, 245, 255);
            entryFeeValue.BorderStyle = BorderStyle.FixedSingle;
            entryFeeValue.ForeColor = Color.FromArgb(0, 63, 121);
            entryFeeValue.Location = new Point(122, 227);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(178, 38);
            entryFeeValue.TabIndex = 3;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.ForeColor = Color.FromArgb(0, 63, 121);
            entryFeeLabel.Location = new Point(15, 229);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(107, 31);
            entryFeeLabel.TabIndex = 2;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.BackColor = Color.FromArgb(245, 245, 255);
            selectTeamDropDown.ForeColor = Color.FromArgb(0, 63, 121);
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(15, 334);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(285, 39);
            selectTeamDropDown.TabIndex = 5;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.FromArgb(0, 63, 121);
            selectTeamLabel.Location = new Point(15, 300);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(135, 31);
            selectTeamLabel.TabIndex = 4;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLinkLabel
            // 
            createNewTeamLinkLabel.AutoSize = true;
            createNewTeamLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            createNewTeamLinkLabel.Location = new Point(201, 307);
            createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            createNewTeamLinkLabel.Size = new Size(99, 23);
            createNewTeamLinkLabel.TabIndex = 6;
            createNewTeamLinkLabel.TabStop = true;
            createNewTeamLinkLabel.Text = "Create New";
            createNewTeamLinkLabel.LinkClicked += createNewTeamLinkLabel_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.FromArgb(0, 63, 121);
            addTeamButton.Location = new Point(43, 386);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(234, 50);
            addTeamButton.TabIndex = 14;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(0, 63, 121);
            createPrizeButton.Location = new Point(43, 458);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(234, 50);
            createPrizeButton.TabIndex = 15;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.BackColor = Color.FromArgb(245, 245, 255);
            tournamentTeamsListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentTeamsListBox.ForeColor = Color.FromArgb(0, 63, 121);
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 31;
            tournamentTeamsListBox.Location = new Point(374, 147);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(313, 157);
            tournamentTeamsListBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 63, 121);
            label1.Location = new Point(374, 113);
            label1.Name = "label1";
            label1.Size = new Size(171, 31);
            label1.TabIndex = 17;
            label1.Text = "Teams / Players";
            // 
            // removeSelectedPlayersButton
            // 
            removeSelectedPlayersButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            removeSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            removeSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            removeSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPlayersButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedPlayersButton.ForeColor = Color.FromArgb(0, 63, 121);
            removeSelectedPlayersButton.Location = new Point(693, 187);
            removeSelectedPlayersButton.Name = "removeSelectedPlayersButton";
            removeSelectedPlayersButton.Size = new Size(118, 73);
            removeSelectedPlayersButton.TabIndex = 18;
            removeSelectedPlayersButton.Text = "Remove Selected";
            removeSelectedPlayersButton.UseVisualStyleBackColor = true;
            removeSelectedPlayersButton.Click += removeSelectedPlayersButton_Click;
            // 
            // removeSelectedPrizeButton
            // 
            removeSelectedPrizeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            removeSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedPrizeButton.ForeColor = Color.FromArgb(0, 63, 121);
            removeSelectedPrizeButton.Location = new Point(693, 393);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new Size(118, 73);
            removeSelectedPrizeButton.TabIndex = 21;
            removeSelectedPrizeButton.Text = "Remove Selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.ForeColor = Color.FromArgb(0, 63, 121);
            prizesLabel.Location = new Point(374, 317);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(73, 31);
            prizesLabel.TabIndex = 20;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.BackColor = Color.FromArgb(245, 245, 255);
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.ForeColor = Color.FromArgb(0, 63, 121);
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 31;
            prizesListBox.Location = new Point(374, 351);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(313, 157);
            prizesListBox.TabIndex = 19;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.FromArgb(0, 63, 121);
            createTournamentButton.Location = new Point(314, 553);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(281, 75);
            createTournamentButton.TabIndex = 22;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 65, 121);
            panel1.Controls.Add(titlePanel);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 79);
            panel1.TabIndex = 23;
            // 
            // titlePanel
            // 
            titlePanel.Dock = DockStyle.Fill;
            titlePanel.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            titlePanel.ForeColor = Color.FromArgb(245, 245, 255);
            titlePanel.Location = new Point(264, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(645, 79);
            titlePanel.TabIndex = 1;
            titlePanel.Text = "Create Tournament";
            titlePanel.TextAlign = ContentAlignment.MiddleLeft;
            titlePanel.MouseDown += titlePanel_MouseDown;
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
            // closeFormButton
            // 
            closeFormButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            closeFormButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            closeFormButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            closeFormButton.FlatStyle = FlatStyle.Flat;
            closeFormButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            closeFormButton.ForeColor = Color.FromArgb(0, 63, 121);
            closeFormButton.Location = new Point(742, 611);
            closeFormButton.Name = "closeFormButton";
            closeFormButton.Size = new Size(155, 58);
            closeFormButton.TabIndex = 24;
            closeFormButton.Text = "Close";
            closeFormButton.UseVisualStyleBackColor = true;
            closeFormButton.Click += closeFormButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 255);
            ClientSize = new Size(909, 681);
            Controls.Add(closeFormButton);
            Controls.Add(panel1);
            Controls.Add(createTournamentButton);
            Controls.Add(removeSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(removeSelectedPlayersButton);
            Controls.Add(label1);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLinkLabel);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "CreateTournamentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateTournamentForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentNameLabel;
        private TextBox tournamentNameValue;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLinkLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentTeamsListBox;
        private Label label1;
        private Button removeSelectedPlayersButton;
        private Button removeSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label titlePanel;
        private Button closeFormButton;
    }
}