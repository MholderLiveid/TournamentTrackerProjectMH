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
            SuspendLayout();
            // 
            // placeNumberValue
            // 
            placeNumberValue.BackColor = Color.FromArgb(245, 245, 255);
            placeNumberValue.BorderStyle = BorderStyle.FixedSingle;
            placeNumberValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberValue.ForeColor = Color.FromArgb(0, 63, 121);
            placeNumberValue.Location = new Point(256, 73);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(218, 38);
            placeNumberValue.TabIndex = 12;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = Color.FromArgb(0, 63, 121);
            placeNumberLabel.Location = new Point(80, 75);
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
            placeNameValue.Location = new Point(256, 126);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(218, 38);
            placeNameValue.TabIndex = 14;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = Color.FromArgb(0, 63, 121);
            placeNameLabel.Location = new Point(103, 128);
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
            prizeAmountValue.Location = new Point(256, 179);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(218, 38);
            prizeAmountValue.TabIndex = 16;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = Color.FromArgb(0, 63, 121);
            prizeAmountLabel.Location = new Point(87, 181);
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
            prizePercentageValue.Location = new Point(256, 306);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(218, 38);
            prizePercentageValue.TabIndex = 18;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = Color.FromArgb(0, 63, 121);
            prizePercentageLabel.Location = new Point(55, 308);
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
            orLabel.Location = new Point(216, 243);
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
            createPrizeButton.Location = new Point(138, 397);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(295, 73);
            createPrizeButton.TabIndex = 22;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 255);
            ClientSize = new Size(1300, 698);
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
            Margin = new Padding(5, 5, 5, 5);
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
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
    }
}