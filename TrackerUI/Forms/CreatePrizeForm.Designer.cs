namespace TrackerUI.Forms
{
    partial class CreatePrizeForm
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
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            invalidPlaceNumberLabel = new Label();
            invalidPlaceNameLabel = new Label();
            invalidPrizeAmountLabel = new Label();
            invalidPrizePercentageLabel = new Label();
            invalidPlaceNumberValueLabel = new Label();
            invalidPlaceNameFormatLabel = new Label();
            closeFormButton = new Button();
            panel1 = new Panel();
            titlePanel = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // placeNumberValue
            // 
            placeNumberValue.BackColor = Color.FromArgb(245, 245, 255);
            placeNumberValue.BorderStyle = BorderStyle.FixedSingle;
            placeNumberValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberValue.ForeColor = Color.FromArgb(0, 63, 121);
            placeNumberValue.Location = new Point(229, 98);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(218, 38);
            placeNumberValue.TabIndex = 12;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = Color.FromArgb(0, 63, 121);
            placeNumberLabel.Location = new Point(53, 100);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(158, 31);
            placeNumberLabel.TabIndex = 11;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.BackColor = Color.FromArgb(245, 245, 255);
            placeNameValue.BorderStyle = BorderStyle.FixedSingle;
            placeNameValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameValue.ForeColor = Color.FromArgb(0, 63, 121);
            placeNameValue.Location = new Point(229, 186);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(218, 38);
            placeNameValue.TabIndex = 14;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = Color.FromArgb(0, 63, 121);
            placeNameLabel.Location = new Point(76, 188);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(135, 31);
            placeNameLabel.TabIndex = 13;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.BackColor = Color.FromArgb(245, 245, 255);
            prizeAmountValue.BorderStyle = BorderStyle.FixedSingle;
            prizeAmountValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountValue.ForeColor = Color.FromArgb(0, 63, 121);
            prizeAmountValue.Location = new Point(229, 280);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(218, 38);
            prizeAmountValue.TabIndex = 16;
            prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = Color.FromArgb(0, 63, 121);
            prizeAmountLabel.Location = new Point(60, 282);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(151, 31);
            prizeAmountLabel.TabIndex = 15;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.BackColor = Color.FromArgb(245, 245, 255);
            prizePercentageValue.BorderStyle = BorderStyle.FixedSingle;
            prizePercentageValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageValue.ForeColor = Color.FromArgb(0, 63, 121);
            prizePercentageValue.Location = new Point(229, 423);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(218, 38);
            prizePercentageValue.TabIndex = 18;
            prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = Color.FromArgb(0, 63, 121);
            prizePercentageLabel.Location = new Point(28, 425);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(183, 31);
            prizePercentageLabel.TabIndex = 17;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = Color.FromArgb(0, 63, 121);
            orLabel.Location = new Point(193, 363);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(71, 31);
            orLabel.TabIndex = 19;
            orLabel.Text = " - or -";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(0, 63, 121);
            createPrizeButton.Location = new Point(229, 514);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(218, 65);
            createPrizeButton.TabIndex = 22;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // invalidPlaceNumberLabel
            // 
            invalidPlaceNumberLabel.AutoSize = true;
            invalidPlaceNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            invalidPlaceNumberLabel.ForeColor = Color.Red;
            invalidPlaceNumberLabel.Location = new Point(229, 139);
            invalidPlaceNumberLabel.Name = "invalidPlaceNumberLabel";
            invalidPlaceNumberLabel.Size = new Size(385, 28);
            invalidPlaceNumberLabel.TabIndex = 23;
            invalidPlaceNumberLabel.Text = "Invalid format, please enter a valid number\r\n";
            invalidPlaceNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            invalidPlaceNumberLabel.Visible = false;
            // 
            // invalidPlaceNameLabel
            // 
            invalidPlaceNameLabel.AutoSize = true;
            invalidPlaceNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            invalidPlaceNameLabel.ForeColor = Color.Red;
            invalidPlaceNameLabel.Location = new Point(229, 227);
            invalidPlaceNameLabel.Name = "invalidPlaceNameLabel";
            invalidPlaceNameLabel.Size = new Size(300, 28);
            invalidPlaceNameLabel.TabIndex = 24;
            invalidPlaceNameLabel.Text = "Invalid format, entry can't be null\r\n";
            invalidPlaceNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            invalidPlaceNameLabel.Visible = false;
            // 
            // invalidPrizeAmountLabel
            // 
            invalidPrizeAmountLabel.AutoSize = true;
            invalidPrizeAmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            invalidPrizeAmountLabel.ForeColor = Color.Red;
            invalidPrizeAmountLabel.Location = new Point(229, 321);
            invalidPrizeAmountLabel.Name = "invalidPrizeAmountLabel";
            invalidPrizeAmountLabel.Size = new Size(385, 28);
            invalidPrizeAmountLabel.TabIndex = 25;
            invalidPrizeAmountLabel.Text = "Invalid format, please enter a valid number\r\n";
            invalidPrizeAmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            invalidPrizeAmountLabel.Visible = false;
            // 
            // invalidPrizePercentageLabel
            // 
            invalidPrizePercentageLabel.AutoSize = true;
            invalidPrizePercentageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            invalidPrizePercentageLabel.ForeColor = Color.Red;
            invalidPrizePercentageLabel.Location = new Point(229, 464);
            invalidPrizePercentageLabel.Name = "invalidPrizePercentageLabel";
            invalidPrizePercentageLabel.Size = new Size(385, 28);
            invalidPrizePercentageLabel.TabIndex = 26;
            invalidPrizePercentageLabel.Text = "Invalid format, please enter a valid number\r\n";
            invalidPrizePercentageLabel.TextAlign = ContentAlignment.MiddleCenter;
            invalidPrizePercentageLabel.Visible = false;
            // 
            // invalidPlaceNumberValueLabel
            // 
            invalidPlaceNumberValueLabel.AutoSize = true;
            invalidPlaceNumberValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            invalidPlaceNumberValueLabel.ForeColor = Color.Red;
            invalidPlaceNumberValueLabel.Location = new Point(229, 139);
            invalidPlaceNumberValueLabel.Name = "invalidPlaceNumberValueLabel";
            invalidPlaceNumberValueLabel.Size = new Size(415, 28);
            invalidPlaceNumberValueLabel.TabIndex = 27;
            invalidPlaceNumberValueLabel.Text = "Invalid format, number must be greater than 1\r\n";
            invalidPlaceNumberValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            invalidPlaceNumberValueLabel.Visible = false;
            // 
            // invalidPlaceNameFormatLabel
            // 
            invalidPlaceNameFormatLabel.AutoSize = true;
            invalidPlaceNameFormatLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            invalidPlaceNameFormatLabel.ForeColor = Color.Red;
            invalidPlaceNameFormatLabel.Location = new Point(229, 227);
            invalidPlaceNameFormatLabel.Name = "invalidPlaceNameFormatLabel";
            invalidPlaceNameFormatLabel.Size = new Size(395, 28);
            invalidPlaceNameFormatLabel.TabIndex = 28;
            invalidPlaceNameFormatLabel.Text = "Invalid format, entry can only contain letters\r\n";
            invalidPlaceNameFormatLabel.TextAlign = ContentAlignment.MiddleCenter;
            invalidPlaceNameFormatLabel.Visible = false;
            // 
            // closeFormButton
            // 
            closeFormButton.FlatAppearance.BorderColor = Color.FromArgb(0, 63, 121);
            closeFormButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 63, 121);
            closeFormButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            closeFormButton.FlatStyle = FlatStyle.Flat;
            closeFormButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            closeFormButton.ForeColor = Color.FromArgb(0, 63, 121);
            closeFormButton.Location = new Point(581, 548);
            closeFormButton.Name = "closeFormButton";
            closeFormButton.Size = new Size(155, 58);
            closeFormButton.TabIndex = 30;
            closeFormButton.Text = "Close";
            closeFormButton.UseVisualStyleBackColor = true;
            closeFormButton.Click += closeFormButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 65, 121);
            panel1.Controls.Add(titlePanel);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 79);
            panel1.TabIndex = 31;
            // 
            // titlePanel
            // 
            titlePanel.Dock = DockStyle.Fill;
            titlePanel.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            titlePanel.ForeColor = Color.FromArgb(245, 245, 255);
            titlePanel.Location = new Point(264, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(484, 79);
            titlePanel.TabIndex = 1;
            titlePanel.Text = "Create Prize";
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
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 255);
            ClientSize = new Size(748, 618);
            Controls.Add(panel1);
            Controls.Add(closeFormButton);
            Controls.Add(invalidPlaceNameFormatLabel);
            Controls.Add(invalidPlaceNumberValueLabel);
            Controls.Add(invalidPrizePercentageLabel);
            Controls.Add(invalidPrizeAmountLabel);
            Controls.Add(invalidPlaceNameLabel);
            Controls.Add(invalidPlaceNumberLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "CreatePrizeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatePrizeForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
        private Label invalidPlaceNumberLabel;
        private Label invalidPlaceNameLabel;
        private Label invalidPrizeAmountLabel;
        private Label invalidPrizePercentageLabel;
        private Label invalidPlaceNumberValueLabel;
        private Label invalidPlaceNameFormatLabel;
        private Button closeFormButton;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label titlePanel;
    }
}