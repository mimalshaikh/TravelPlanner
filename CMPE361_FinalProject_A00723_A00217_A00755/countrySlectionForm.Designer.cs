namespace CMPE361_FinalProject_A00723_A00217_A00755
{
    partial class countrySlectionForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.planePictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseCountLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.planeTimer = new System.Windows.Forms.Timer(this.components);
            this.countriesComboBox = new System.Windows.Forms.ComboBox();
            this.planePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // planePanel
            // 
            this.planePanel.BackColor = System.Drawing.Color.Transparent;
            this.planePanel.Controls.Add(this.welcomeLabel);
            this.planePanel.Controls.Add(this.planePictureBox);
            this.planePanel.Location = new System.Drawing.Point(1, 1);
            this.planePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.planePanel.Name = "planePanel";
            this.planePanel.Size = new System.Drawing.Size(739, 80);
            this.planePanel.TabIndex = 3;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Pink;
            this.welcomeLabel.Location = new System.Drawing.Point(1, 32);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(190, 19);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome (fname)(lname)";
            // 
            // planePictureBox
            // 
            this.planePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.planePictureBox.Image = global::CMPE361_FinalProject_A00723_A00217_A00755.Properties.Resources.plane_removebg_preview;
            this.planePictureBox.Location = new System.Drawing.Point(183, 7);
            this.planePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.planePictureBox.Name = "planePictureBox";
            this.planePictureBox.Size = new System.Drawing.Size(137, 71);
            this.planePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planePictureBox.TabIndex = 0;
            this.planePictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(268, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Where would you like to visit?";
            // 
            // chooseCountLabel
            // 
            this.chooseCountLabel.AutoSize = true;
            this.chooseCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.chooseCountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCountLabel.ForeColor = System.Drawing.Color.White;
            this.chooseCountLabel.Location = new System.Drawing.Point(241, 153);
            this.chooseCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseCountLabel.Name = "chooseCountLabel";
            this.chooseCountLabel.Size = new System.Drawing.Size(288, 29);
            this.chooseCountLabel.TabIndex = 27;
            this.chooseCountLabel.Text = "choose your next adventure:";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Pink;
            this.backButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(620, 382);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 26);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.Pink;
            this.goButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(467, 367);
            this.goButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(143, 41);
            this.goButton.TabIndex = 30;
            this.goButton.Text = "GO!";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // planeTimer
            // 
            this.planeTimer.Tick += new System.EventHandler(this.planeTimer_Tick);
            // 
            // countriesComboBox
            // 
            this.countriesComboBox.BackColor = System.Drawing.Color.DarkGray;
            this.countriesComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countriesComboBox.FormattingEnabled = true;
            this.countriesComboBox.Location = new System.Drawing.Point(282, 239);
            this.countriesComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countriesComboBox.Name = "countriesComboBox";
            this.countriesComboBox.Size = new System.Drawing.Size(186, 27);
            this.countriesComboBox.TabIndex = 32;
            this.countriesComboBox.Text = "Choose your destination";
            this.countriesComboBox.SelectedIndexChanged += new System.EventHandler(this.countriesComboBox_SelectedIndexChanged);
            // 
            // countrySlectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::CMPE361_FinalProject_A00723_A00217_A00755.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(735, 427);
            this.Controls.Add(this.countriesComboBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseCountLabel);
            this.Controls.Add(this.planePanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "countrySlectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start your journey";
            this.Load += new System.EventHandler(this.welcomeForm_Load);
            this.planePanel.ResumeLayout(false);
            this.planePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel planePanel;
        private System.Windows.Forms.PictureBox planePictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chooseCountLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Timer planeTimer;
        private System.Windows.Forms.ComboBox countriesComboBox;
    }
}