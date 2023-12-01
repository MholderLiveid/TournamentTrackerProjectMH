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
            tournamentPlayersListBox = new ListBox();
            label1 = new Label();
            deleteSelectedPlayersButton = new Button();
            deleteSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.ForeColor = Color.FromArgb(0, 63, 121);
            tournamentNameLabel.Location = new Point(21, 31);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(203, 31);
            tournamentNameLabel.TabIndex = 0;
            tournamentNameLabel.Text = "Tournament Name\r\n";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.BackColor = Color.FromArgb(245, 245, 255);
            tournamentNameValue.BorderStyle = BorderStyle.FixedSingle;
            tournamentNameValue.Location = new Point(26, 65);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(280, 38);
            tournamentNameValue.TabIndex = 1;
            // 
            // entryFeeValue
            // 
            entryFeeValue.BackColor = Color.FromArgb(245, 245, 255);
            entryFeeValue.BorderStyle = BorderStyle.FixedSingle;
            entryFeeValue.ForeColor = Color.FromArgb(0, 63, 121);
            entryFeeValue.Location = new Point(128, 145);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(178, 38);
            entryFeeValue.TabIndex = 3;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.ForeColor = Color.FromArgb(0, 63, 121);
            entryFeeLabel.Location = new Point(21, 147);
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
            selectTeamDropDown.Location = new Point(21, 252);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(285, 39);
            selectTeamDropDown.TabIndex = 5;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.FromArgb(0, 63, 121);
            selectTeamLabel.Location = new Point(21, 218);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(135, 31);
            selectTeamLabel.TabIndex = 4;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLinkLabel
            // 
            createNewTeamLinkLabel.AutoSize = true;
            createNewTeamLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            createNewTeamLinkLabel.Location = new Point(207, 225);
            createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            createNewTeamLinkLabel.Size = new Size(99, 23);
            createNewTeamLinkLabel.TabIndex = 6;
            createNewTeamLinkLabel.TabStop = true;
            createNewTeamLinkLabel.Text = "Create New";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.FromArgb(0, 63, 121);
            addTeamButton.Location = new Point(49, 317);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(234, 50);
            addTeamButton.TabIndex = 14;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(0, 63, 121);
            createPrizeButton.Location = new Point(49, 373);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(234, 50);
            createPrizeButton.TabIndex = 15;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BackColor = Color.FromArgb(245, 245, 255);
            tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayersListBox.ForeColor = Color.FromArgb(0, 63, 121);
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 31;
            tournamentPlayersListBox.Location = new Point(380, 65);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(313, 219);
            tournamentPlayersListBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 63, 121);
            label1.Location = new Point(380, 31);
            label1.Name = "label1";
            label1.Size = new Size(171, 31);
            label1.TabIndex = 17;
            label1.Text = "Teams / Players";
            // 
            // deleteSelectedPlayersButton
            // 
            deleteSelectedPlayersButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            deleteSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayersButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPlayersButton.ForeColor = Color.FromArgb(0, 63, 121);
            deleteSelectedPlayersButton.Location = new Point(720, 138);
            deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            deleteSelectedPlayersButton.Size = new Size(118, 73);
            deleteSelectedPlayersButton.TabIndex = 18;
            deleteSelectedPlayersButton.Text = "Delete Selected";
            deleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPrizeButton.ForeColor = Color.FromArgb(0, 63, 121);
            deleteSelectedPrizeButton.Location = new Point(720, 406);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(118, 73);
            deleteSelectedPrizeButton.TabIndex = 21;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.ForeColor = Color.FromArgb(0, 63, 121);
            prizesLabel.Location = new Point(380, 299);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(171, 31);
            prizesLabel.TabIndex = 20;
            prizesLabel.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            prizesListBox.BackColor = Color.FromArgb(245, 245, 255);
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.ForeColor = Color.FromArgb(0, 63, 121);
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 31;
            prizesListBox.Location = new Point(380, 333);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(313, 219);
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
            createTournamentButton.Location = new Point(254, 594);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(255, 71);
            createTournamentButton.TabIndex = 22;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 255);
            ClientSize = new Size(1300, 697);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(deleteSelectedPlayersButton);
            Controls.Add(label1);
            Controls.Add(tournamentPlayersListBox);
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
            Margin = new Padding(5);
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
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
        private ListBox tournamentPlayersListBox;
        private Label label1;
        private Button deleteSelectedPlayersButton;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}