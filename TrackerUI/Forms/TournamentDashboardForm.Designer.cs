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
            SuspendLayout();
            // 
            // loadExistingTournamentDropdown
            // 
            loadExistingTournamentDropdown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loadExistingTournamentDropdown.BackColor = Color.FromArgb(245, 245, 255);
            loadExistingTournamentDropdown.ForeColor = Color.FromArgb(0, 63, 121);
            loadExistingTournamentDropdown.FormattingEnabled = true;
            loadExistingTournamentDropdown.Location = new Point(37, 61);
            loadExistingTournamentDropdown.Name = "loadExistingTournamentDropdown";
            loadExistingTournamentDropdown.Size = new Size(388, 39);
            loadExistingTournamentDropdown.TabIndex = 18;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentLabel.ForeColor = Color.FromArgb(0, 63, 121);
            loadExistingTournamentLabel.Location = new Point(92, 27);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(278, 31);
            loadExistingTournamentLabel.TabIndex = 17;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loadTournamentButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentButton.ForeColor = Color.FromArgb(0, 63, 121);
            loadTournamentButton.Location = new Point(114, 121);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(234, 50);
            loadTournamentButton.TabIndex = 19;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createTournamentButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.FromArgb(0, 63, 121);
            createTournamentButton.Location = new Point(84, 193);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(295, 73);
            createTournamentButton.TabIndex = 23;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 255);
            ClientSize = new Size(1300, 698);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropdown);
            Controls.Add(loadExistingTournamentLabel);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "TournamentDashboardForm";
            Text = "TournamentDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox loadExistingTournamentDropdown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}