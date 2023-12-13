namespace TrackerUI.Forms
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            addMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            groupBox1 = new GroupBox();
            createMemberButton = new Button();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            label1 = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedMemberButton = new Button();
            createTeamButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            teamNameValue.BackColor = Color.FromArgb(245, 245, 255);
            teamNameValue.BorderStyle = BorderStyle.FixedSingle;
            teamNameValue.Location = new Point(40, 60);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(388, 38);
            teamNameValue.TabIndex = 3;
            // 
            // teamNameLabel
            // 
            teamNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            teamNameLabel.AutoSize = true;
            teamNameLabel.ForeColor = Color.FromArgb(0, 63, 121);
            teamNameLabel.Location = new Point(35, 26);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(135, 31);
            teamNameLabel.TabIndex = 2;
            teamNameLabel.Text = "Team Name\r\n";
            // 
            // addMemberButton
            // 
            addMemberButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addMemberButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberButton.ForeColor = Color.FromArgb(0, 63, 121);
            addMemberButton.Location = new Point(63, 231);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(234, 50);
            addMemberButton.TabIndex = 17;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectTeamMemberDropDown.BackColor = Color.FromArgb(245, 245, 255);
            selectTeamMemberDropDown.ForeColor = Color.FromArgb(0, 63, 121);
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(40, 164);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(388, 39);
            selectTeamMemberDropDown.TabIndex = 16;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = Color.FromArgb(0, 63, 121);
            selectTeamMemberLabel.Location = new Point(35, 130);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(228, 31);
            selectTeamMemberLabel.TabIndex = 15;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(createMemberButton);
            groupBox1.Controls.Add(cellphoneValue);
            groupBox1.Controls.Add(cellphoneLabel);
            groupBox1.Controls.Add(emailValue);
            groupBox1.Controls.Add(emailLabel);
            groupBox1.Controls.Add(lastNameValue);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(firstNameValue);
            groupBox1.Controls.Add(firstNameLabel);
            groupBox1.ForeColor = Color.FromArgb(0, 63, 121);
            groupBox1.Location = new Point(35, 314);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 311);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = Color.FromArgb(0, 63, 121);
            createMemberButton.Location = new Point(115, 248);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(194, 50);
            createMemberButton.TabIndex = 19;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneValue
            // 
            cellphoneValue.BackColor = Color.FromArgb(245, 245, 255);
            cellphoneValue.BorderStyle = BorderStyle.FixedSingle;
            cellphoneValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneValue.ForeColor = Color.FromArgb(0, 63, 121);
            cellphoneValue.Location = new Point(145, 194);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(218, 38);
            cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneLabel.ForeColor = Color.FromArgb(0, 63, 121);
            cellphoneLabel.Location = new Point(19, 196);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(122, 31);
            cellphoneLabel.TabIndex = 15;
            cellphoneLabel.Text = "Cell Phone";
            // 
            // emailValue
            // 
            emailValue.BackColor = Color.FromArgb(245, 245, 255);
            emailValue.BorderStyle = BorderStyle.FixedSingle;
            emailValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            emailValue.ForeColor = Color.FromArgb(0, 63, 121);
            emailValue.Location = new Point(145, 147);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(218, 38);
            emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.FromArgb(0, 63, 121);
            emailLabel.Location = new Point(71, 149);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(70, 31);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.BackColor = Color.FromArgb(245, 245, 255);
            lastNameValue.BorderStyle = BorderStyle.FixedSingle;
            lastNameValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameValue.ForeColor = Color.FromArgb(0, 63, 121);
            lastNameValue.Location = new Point(145, 100);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(218, 38);
            lastNameValue.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 63, 121);
            label1.Location = new Point(19, 102);
            label1.Name = "label1";
            label1.Size = new Size(122, 31);
            label1.TabIndex = 11;
            label1.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.BackColor = Color.FromArgb(245, 245, 255);
            firstNameValue.BorderStyle = BorderStyle.FixedSingle;
            firstNameValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameValue.ForeColor = Color.FromArgb(0, 63, 121);
            firstNameValue.Location = new Point(145, 53);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(218, 38);
            firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.FromArgb(0, 63, 121);
            firstNameLabel.Location = new Point(17, 55);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(124, 31);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            teamMembersListBox.BackColor = Color.FromArgb(245, 245, 255);
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.ForeColor = Color.FromArgb(0, 63, 121);
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 31;
            teamMembersListBox.Location = new Point(484, 60);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(313, 560);
            teamMembersListBox.TabIndex = 19;
            // 
            // removeSelectedMemberButton
            // 
            removeSelectedMemberButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeSelectedMemberButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            removeSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            removeSelectedMemberButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedMemberButton.ForeColor = Color.FromArgb(0, 63, 121);
            removeSelectedMemberButton.Location = new Point(543, 645);
            removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            removeSelectedMemberButton.Size = new Size(194, 73);
            removeSelectedMemberButton.TabIndex = 20;
            removeSelectedMemberButton.Text = "Remove Selected";
            removeSelectedMemberButton.UseVisualStyleBackColor = true;
            removeSelectedMemberButton.Click += removeSelectedMemberButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createTeamButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = Color.FromArgb(0, 63, 121);
            createTeamButton.Location = new Point(82, 645);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(295, 73);
            createTeamButton.TabIndex = 21;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 255);
            ClientSize = new Size(1300, 746);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(groupBox1);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "CreateTeamForm";
            Text = "CreateTeamForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox groupBox1;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label label1;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button removeSelectedMemberButton;
        private Button createTeamButton;
    }
}