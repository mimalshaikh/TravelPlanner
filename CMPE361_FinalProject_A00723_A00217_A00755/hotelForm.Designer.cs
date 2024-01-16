namespace CMPE361_FinalProject_A00723_A00217_A00755
{
    partial class hotelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hotelForm));
            this.bagTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hotelsListBox = new System.Windows.Forms.ListBox();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.bagPanel = new System.Windows.Forms.Panel();
            this.bagPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.bagPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bagPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bagTimer
            // 
            this.bagTimer.Tick += new System.EventHandler(this.bagTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "YOU\'RE ALMOST THERE!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Hotel Selection:";
            // 
            // hotelsListBox
            // 
            this.hotelsListBox.BackColor = System.Drawing.Color.Black;
            this.hotelsListBox.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelsListBox.ForeColor = System.Drawing.Color.Pink;
            this.hotelsListBox.ItemHeight = 16;
            this.hotelsListBox.Location = new System.Drawing.Point(196, 110);
            this.hotelsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.hotelsListBox.Name = "hotelsListBox";
            this.hotelsListBox.Size = new System.Drawing.Size(354, 84);
            this.hotelsListBox.TabIndex = 41;
            this.hotelsListBox.SelectedIndexChanged += new System.EventHandler(this.hotelsListBox_SelectedIndexChanged);
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.BackColor = System.Drawing.Color.Transparent;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.ForeColor = System.Drawing.Color.White;
            this.chooseLabel.Location = new System.Drawing.Point(23, 23);
            this.chooseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(304, 29);
            this.chooseLabel.TabIndex = 40;
            this.chooseLabel.Text = "Where would you like to stay?";
            // 
            // bagPanel
            // 
            this.bagPanel.BackColor = System.Drawing.Color.Transparent;
            this.bagPanel.Controls.Add(this.bagPictureBox);
            this.bagPanel.Location = new System.Drawing.Point(1, 265);
            this.bagPanel.Margin = new System.Windows.Forms.Padding(2);
            this.bagPanel.Name = "bagPanel";
            this.bagPanel.Size = new System.Drawing.Size(738, 159);
            this.bagPanel.TabIndex = 44;
            // 
            // bagPictureBox
            // 
            this.bagPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bagPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("bagPictureBox.Image")));
            this.bagPictureBox.Location = new System.Drawing.Point(2, 3);
            this.bagPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.bagPictureBox.Name = "bagPictureBox";
            this.bagPictureBox.Size = new System.Drawing.Size(165, 156);
            this.bagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bagPictureBox.TabIndex = 0;
            this.bagPictureBox.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Pink;
            this.backButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(625, 235);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 26);
            this.backButton.TabIndex = 46;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.Pink;
            this.goButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(471, 220);
            this.goButton.Margin = new System.Windows.Forms.Padding(2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(143, 41);
            this.goButton.TabIndex = 45;
            this.goButton.Text = "Next";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // hotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPE361_FinalProject_A00723_A00217_A00755.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(735, 427);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.bagPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hotelsListBox);
            this.Controls.Add(this.chooseLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "hotelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel selection";
            this.Load += new System.EventHandler(this.hotelForm_Load);
            this.bagPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bagPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer bagTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox hotelsListBox;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Panel bagPanel;
        private System.Windows.Forms.PictureBox bagPictureBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button goButton;
    }
}