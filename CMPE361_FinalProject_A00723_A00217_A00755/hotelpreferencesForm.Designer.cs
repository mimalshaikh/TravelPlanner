namespace CMPE361_FinalProject_A00723_A00217_A00755
{
    partial class hotelpreferencesForm
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
            this.components = new System.ComponentModel.Container();
            this.planePanel = new System.Windows.Forms.Panel();
            this.planePictureBox = new System.Windows.Forms.PictureBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.planeTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.checkINLabel = new System.Windows.Forms.Label();
            this.stepLabel = new System.Windows.Forms.Label();
            this.checkInComboBox = new System.Windows.Forms.ComboBox();
            this.checkOutComboBox = new System.Windows.Forms.ComboBox();
            this.breakFastGroupBox = new System.Windows.Forms.GroupBox();
            this.noBRadioButton = new System.Windows.Forms.RadioButton();
            this.withBRadioButton = new System.Windows.Forms.RadioButton();
            this.preferencesGroupBox = new System.Windows.Forms.GroupBox();
            this.star5RadioButton = new System.Windows.Forms.RadioButton();
            this.star4RadioButton = new System.Windows.Forms.RadioButton();
            this.star3RadioButton = new System.Windows.Forms.RadioButton();
            this.star2RadioButton = new System.Windows.Forms.RadioButton();
            this.backButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.planePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planePictureBox)).BeginInit();
            this.breakFastGroupBox.SuspendLayout();
            this.preferencesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // planePanel
            // 
            this.planePanel.BackColor = System.Drawing.Color.Transparent;
            this.planePanel.Controls.Add(this.planePictureBox);
            this.planePanel.Controls.Add(this.countryLabel);
            this.planePanel.Location = new System.Drawing.Point(1, 1);
            this.planePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.planePanel.Name = "planePanel";
            this.planePanel.Size = new System.Drawing.Size(736, 80);
            this.planePanel.TabIndex = 5;
            // 
            // planePictureBox
            // 
            this.planePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.planePictureBox.Image = global::CMPE361_FinalProject_A00723_A00217_A00755.Properties.Resources.plane_removebg_preview;
            this.planePictureBox.Location = new System.Drawing.Point(167, 5);
            this.planePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.planePictureBox.Name = "planePictureBox";
            this.planePictureBox.Size = new System.Drawing.Size(137, 71);
            this.planePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planePictureBox.TabIndex = 0;
            this.planePictureBox.TabStop = false;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.BackColor = System.Drawing.Color.Transparent;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.ForeColor = System.Drawing.Color.White;
            this.countryLabel.Location = new System.Drawing.Point(40, 30);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(132, 19);
            this.countryLabel.TabIndex = 1;
            this.countryLabel.Text = "mejor experiencia!";
            // 
            // planeTimer
            // 
            this.planeTimer.Tick += new System.EventHandler(this.planeTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(371, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Check out:";
            // 
            // checkINLabel
            // 
            this.checkINLabel.AutoSize = true;
            this.checkINLabel.BackColor = System.Drawing.Color.Transparent;
            this.checkINLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkINLabel.ForeColor = System.Drawing.Color.Pink;
            this.checkINLabel.Location = new System.Drawing.Point(133, 155);
            this.checkINLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkINLabel.Name = "checkINLabel";
            this.checkINLabel.Size = new System.Drawing.Size(71, 19);
            this.checkINLabel.TabIndex = 42;
            this.checkINLabel.Text = "Check in:";
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.BackColor = System.Drawing.Color.Transparent;
            this.stepLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepLabel.ForeColor = System.Drawing.Color.White;
            this.stepLabel.Location = new System.Drawing.Point(191, 103);
            this.stepLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(270, 29);
            this.stepLabel.TabIndex = 41;
            this.stepLabel.Text = "Pick your hotel prefrences:";
            // 
            // checkInComboBox
            // 
            this.checkInComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInComboBox.FormattingEnabled = true;
            this.checkInComboBox.Items.AddRange(new object[] {
            "4:00am",
            "6:00am",
            "8:00am",
            "10:00am",
            "12:00pm",
            "6:00pm",
            "8:00pm",
            "10:00pm"});
            this.checkInComboBox.Location = new System.Drawing.Point(136, 188);
            this.checkInComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkInComboBox.Name = "checkInComboBox";
            this.checkInComboBox.Size = new System.Drawing.Size(137, 27);
            this.checkInComboBox.TabIndex = 45;
            this.checkInComboBox.Text = "Select time";
            // 
            // checkOutComboBox
            // 
            this.checkOutComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutComboBox.FormattingEnabled = true;
            this.checkOutComboBox.Items.AddRange(new object[] {
            "12:00am",
            "2:00am",
            "5:00am",
            "11:00am",
            "7:00pm",
            "11:00pm"});
            this.checkOutComboBox.Location = new System.Drawing.Point(375, 188);
            this.checkOutComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkOutComboBox.Name = "checkOutComboBox";
            this.checkOutComboBox.Size = new System.Drawing.Size(137, 27);
            this.checkOutComboBox.TabIndex = 46;
            this.checkOutComboBox.Text = "Select time";
            // 
            // breakFastGroupBox
            // 
            this.breakFastGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.breakFastGroupBox.Controls.Add(this.noBRadioButton);
            this.breakFastGroupBox.Controls.Add(this.withBRadioButton);
            this.breakFastGroupBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakFastGroupBox.ForeColor = System.Drawing.Color.Pink;
            this.breakFastGroupBox.Location = new System.Drawing.Point(375, 274);
            this.breakFastGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.breakFastGroupBox.Name = "breakFastGroupBox";
            this.breakFastGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.breakFastGroupBox.Size = new System.Drawing.Size(142, 125);
            this.breakFastGroupBox.TabIndex = 48;
            this.breakFastGroupBox.TabStop = false;
            this.breakFastGroupBox.Text = "Would you like:";
            // 
            // noBRadioButton
            // 
            this.noBRadioButton.AutoSize = true;
            this.noBRadioButton.ForeColor = System.Drawing.Color.White;
            this.noBRadioButton.Location = new System.Drawing.Point(5, 84);
            this.noBRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noBRadioButton.Name = "noBRadioButton";
            this.noBRadioButton.Size = new System.Drawing.Size(145, 23);
            this.noBRadioButton.TabIndex = 1;
            this.noBRadioButton.TabStop = true;
            this.noBRadioButton.Text = "Without Breakfast";
            this.noBRadioButton.UseVisualStyleBackColor = true;
            // 
            // withBRadioButton
            // 
            this.withBRadioButton.AutoSize = true;
            this.withBRadioButton.ForeColor = System.Drawing.Color.White;
            this.withBRadioButton.Location = new System.Drawing.Point(5, 36);
            this.withBRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.withBRadioButton.Name = "withBRadioButton";
            this.withBRadioButton.Size = new System.Drawing.Size(123, 23);
            this.withBRadioButton.TabIndex = 0;
            this.withBRadioButton.TabStop = true;
            this.withBRadioButton.Text = "With breakfast";
            this.withBRadioButton.UseVisualStyleBackColor = true;
            // 
            // preferencesGroupBox
            // 
            this.preferencesGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.preferencesGroupBox.Controls.Add(this.star5RadioButton);
            this.preferencesGroupBox.Controls.Add(this.star4RadioButton);
            this.preferencesGroupBox.Controls.Add(this.star3RadioButton);
            this.preferencesGroupBox.Controls.Add(this.star2RadioButton);
            this.preferencesGroupBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferencesGroupBox.ForeColor = System.Drawing.Color.Pink;
            this.preferencesGroupBox.Location = new System.Drawing.Point(136, 274);
            this.preferencesGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.preferencesGroupBox.Name = "preferencesGroupBox";
            this.preferencesGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.preferencesGroupBox.Size = new System.Drawing.Size(203, 125);
            this.preferencesGroupBox.TabIndex = 47;
            this.preferencesGroupBox.TabStop = false;
            this.preferencesGroupBox.Text = "Choose your preferences :";
            // 
            // star5RadioButton
            // 
            this.star5RadioButton.AutoSize = true;
            this.star5RadioButton.ForeColor = System.Drawing.Color.White;
            this.star5RadioButton.Location = new System.Drawing.Point(111, 84);
            this.star5RadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.star5RadioButton.Name = "star5RadioButton";
            this.star5RadioButton.Size = new System.Drawing.Size(89, 23);
            this.star5RadioButton.TabIndex = 5;
            this.star5RadioButton.TabStop = true;
            this.star5RadioButton.Text = "Five Stars";
            this.star5RadioButton.UseVisualStyleBackColor = true;
            // 
            // star4RadioButton
            // 
            this.star4RadioButton.AutoSize = true;
            this.star4RadioButton.ForeColor = System.Drawing.Color.White;
            this.star4RadioButton.Location = new System.Drawing.Point(8, 84);
            this.star4RadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.star4RadioButton.Name = "star4RadioButton";
            this.star4RadioButton.Size = new System.Drawing.Size(92, 23);
            this.star4RadioButton.TabIndex = 4;
            this.star4RadioButton.TabStop = true;
            this.star4RadioButton.Text = "Four Stars";
            this.star4RadioButton.UseVisualStyleBackColor = true;
            // 
            // star3RadioButton
            // 
            this.star3RadioButton.AutoSize = true;
            this.star3RadioButton.ForeColor = System.Drawing.Color.White;
            this.star3RadioButton.Location = new System.Drawing.Point(111, 36);
            this.star3RadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.star3RadioButton.Name = "star3RadioButton";
            this.star3RadioButton.Size = new System.Drawing.Size(100, 23);
            this.star3RadioButton.TabIndex = 3;
            this.star3RadioButton.TabStop = true;
            this.star3RadioButton.Text = "Three Stars";
            this.star3RadioButton.UseVisualStyleBackColor = true;
            // 
            // star2RadioButton
            // 
            this.star2RadioButton.AutoSize = true;
            this.star2RadioButton.ForeColor = System.Drawing.Color.White;
            this.star2RadioButton.Location = new System.Drawing.Point(8, 36);
            this.star2RadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.star2RadioButton.Name = "star2RadioButton";
            this.star2RadioButton.Size = new System.Drawing.Size(89, 23);
            this.star2RadioButton.TabIndex = 2;
            this.star2RadioButton.TabStop = true;
            this.star2RadioButton.Text = "Two stars";
            this.star2RadioButton.UseVisualStyleBackColor = true;
            this.star2RadioButton.CheckedChanged += new System.EventHandler(this.star1RadioButton_CheckedChanged);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Pink;
            this.backButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(570, 372);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 26);
            this.backButton.TabIndex = 50;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.Pink;
            this.goButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(570, 321);
            this.goButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(143, 41);
            this.goButton.TabIndex = 49;
            this.goButton.Text = "GO!";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // hotelpreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPE361_FinalProject_A00723_A00217_A00755.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(735, 427);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.breakFastGroupBox);
            this.Controls.Add(this.preferencesGroupBox);
            this.Controls.Add(this.checkOutComboBox);
            this.Controls.Add(this.checkInComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkINLabel);
            this.Controls.Add(this.stepLabel);
            this.Controls.Add(this.planePanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "hotelpreferencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hotelpreferencesForm1";
            this.Load += new System.EventHandler(this.hotelpreferencesForm_Load);
            this.planePanel.ResumeLayout(false);
            this.planePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planePictureBox)).EndInit();
            this.breakFastGroupBox.ResumeLayout(false);
            this.breakFastGroupBox.PerformLayout();
            this.preferencesGroupBox.ResumeLayout(false);
            this.preferencesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel planePanel;
        private System.Windows.Forms.PictureBox planePictureBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Timer planeTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label checkINLabel;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.ComboBox checkInComboBox;
        private System.Windows.Forms.ComboBox checkOutComboBox;
        private System.Windows.Forms.GroupBox breakFastGroupBox;
        private System.Windows.Forms.RadioButton noBRadioButton;
        private System.Windows.Forms.RadioButton withBRadioButton;
        private System.Windows.Forms.GroupBox preferencesGroupBox;
        private System.Windows.Forms.RadioButton star5RadioButton;
        private System.Windows.Forms.RadioButton star4RadioButton;
        private System.Windows.Forms.RadioButton star3RadioButton;
        private System.Windows.Forms.RadioButton star2RadioButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button goButton;
    }
}