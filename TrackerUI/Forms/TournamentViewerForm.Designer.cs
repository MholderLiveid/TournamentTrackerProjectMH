namespace TrackerUI.Forms
{
    partial class TournamentViewerForm
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
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBos = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoLabel = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 63, 121);
            label1.Location = new Point(14, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 0;
            label1.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.ForeColor = Color.FromArgb(0, 63, 121);
            tournamentName.Location = new Point(151, 40);
            tournamentName.Margin = new Padding(4, 0, 4, 0);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(97, 31);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = Color.FromArgb(0, 63, 121);
            roundLabel.Location = new Point(14, 110);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(80, 31);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.BackColor = Color.FromArgb(245, 245, 255);
            roundDropDown.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            roundDropDown.ForeColor = Color.FromArgb(0, 63, 121);
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(90, 107);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(249, 39);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBos
            // 
            unplayedOnlyCheckBos.AutoSize = true;
            unplayedOnlyCheckBos.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckBos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckBos.ForeColor = Color.FromArgb(0, 63, 121);
            unplayedOnlyCheckBos.Location = new Point(90, 152);
            unplayedOnlyCheckBos.Name = "unplayedOnlyCheckBos";
            unplayedOnlyCheckBos.Size = new Size(183, 35);
            unplayedOnlyCheckBos.TabIndex = 4;
            unplayedOnlyCheckBos.Text = "Unplayed Only";
            unplayedOnlyCheckBos.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BackColor = Color.FromArgb(245, 245, 255);
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            matchupListBox.ForeColor = Color.FromArgb(0, 63, 121);
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 31;
            matchupListBox.Location = new Point(14, 219);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(366, 250);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.ForeColor = Color.FromArgb(0, 63, 121);
            teamOneName.Location = new Point(444, 219);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(142, 31);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.ForeColor = Color.FromArgb(0, 63, 121);
            teamOneScoreLabel.Location = new Point(406, 263);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(70, 31);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.BackColor = Color.FromArgb(245, 245, 255);
            teamOneScoreValue.BorderStyle = BorderStyle.FixedSingle;
            teamOneScoreValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreValue.ForeColor = Color.FromArgb(0, 63, 121);
            teamOneScoreValue.Location = new Point(482, 261);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(135, 38);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.BackColor = Color.FromArgb(245, 245, 255);
            teamTwoScoreValue.BorderStyle = BorderStyle.FixedSingle;
            teamTwoScoreValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreValue.ForeColor = Color.FromArgb(0, 63, 121);
            teamTwoScoreValue.Location = new Point(482, 403);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(135, 38);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreLabel.ForeColor = Color.FromArgb(0, 63, 121);
            teamTwoScoreLabel.Location = new Point(406, 405);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(70, 31);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoLabel
            // 
            teamTwoLabel.AutoSize = true;
            teamTwoLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoLabel.ForeColor = Color.FromArgb(0, 63, 121);
            teamTwoLabel.Location = new Point(444, 357);
            teamTwoLabel.Name = "teamTwoLabel";
            teamTwoLabel.Size = new Size(142, 31);
            teamTwoLabel.TabIndex = 9;
            teamTwoLabel.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            versusLabel.ForeColor = Color.FromArgb(0, 63, 121);
            versusLabel.Location = new Point(482, 312);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(70, 31);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "- VS -";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            scoreButton.ForeColor = Color.FromArgb(0, 63, 121);
            scoreButton.Location = new Point(622, 326);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(128, 50);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 255);
            ClientSize = new Size(902, 508);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBos);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(245, 245, 255);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TournamentViewerForm";
            Text = "TournamentViewerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBos;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoLabel;
        private Label versusLabel;
        private Button scoreButton;
    }
}