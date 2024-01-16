namespace CMPE361_FinalProject_A00723_A00217_A00755
{
    partial class ticketForm
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
            this.countryLabel = new System.Windows.Forms.Label();
            this.planePictureBox = new System.Windows.Forms.PictureBox();
            this.planeTimer = new System.Windows.Forms.Timer(this.components);
            this.ticketsListBox = new System.Windows.Forms.ListBox();
            this.flightLabel = new System.Windows.Forms.Label();
            this.stepLabel = new System.Windows.Forms.Label();
            this.DepartingFlightsLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.FROMLabel = new System.Windows.Forms.Label();
            this.DepartingPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DepartureDateLabel = new System.Windows.Forms.Label();
            this.departureTimeLabel = new System.Windows.Forms.Label();
            this.arriveTimeLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FlightPriceLabel = new System.Windows.Forms.Label();
            this.AIRLINELabel = new System.Windows.Forms.Label();
            this.ReturningPanel = new System.Windows.Forms.Panel();
            this.returnFlightPriceLabel = new System.Windows.Forms.Label();
            this.returnToTimeLabel = new System.Windows.Forms.Label();
            this.ReturnToLabel = new System.Windows.Forms.Label();
            this.returnTimeLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ReturnAIRLINELabel = new System.Windows.Forms.Label();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.ReturnFromLabel = new System.Windows.Forms.Label();
            this.ReturningFlightsLabel = new System.Windows.Forms.Label();
            this.STOPLabel = new System.Windows.Forms.Label();
            this.returnSTOPLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.flightTimeLabel = new System.Windows.Forms.Label();
            this.returnFlightTimeLabel = new System.Windows.Forms.Label();
            this.planePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planePictureBox)).BeginInit();
            this.DepartingPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ReturningPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // planePanel
            // 
            this.planePanel.BackColor = System.Drawing.Color.Transparent;
            this.planePanel.Controls.Add(this.countryLabel);
            this.planePanel.Controls.Add(this.planePictureBox);
            this.planePanel.Location = new System.Drawing.Point(1, 1);
            this.planePanel.Margin = new System.Windows.Forms.Padding(2);
            this.planePanel.Name = "planePanel";
            this.planePanel.Size = new System.Drawing.Size(735, 80);
            this.planePanel.TabIndex = 4;
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
            this.countryLabel.Size = new System.Drawing.Size(115, 19);
            this.countryLabel.TabIndex = 1;
            this.countryLabel.Text = "(off to(country))";
            // 
            // planePictureBox
            // 
            this.planePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.planePictureBox.Image = global::CMPE361_FinalProject_A00723_A00217_A00755.Properties.Resources.plane_removebg_preview;
            this.planePictureBox.Location = new System.Drawing.Point(162, 7);
            this.planePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.planePictureBox.Name = "planePictureBox";
            this.planePictureBox.Size = new System.Drawing.Size(137, 71);
            this.planePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planePictureBox.TabIndex = 0;
            this.planePictureBox.TabStop = false;
            // 
            // planeTimer
            // 
            this.planeTimer.Tick += new System.EventHandler(this.planeTimer_Tick);
            // 
            // ticketsListBox
            // 
            this.ticketsListBox.BackColor = System.Drawing.Color.Black;
            this.ticketsListBox.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsListBox.ForeColor = System.Drawing.Color.Pink;
            this.ticketsListBox.FormattingEnabled = true;
            this.ticketsListBox.ItemHeight = 16;
            this.ticketsListBox.Location = new System.Drawing.Point(27, 146);
            this.ticketsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ticketsListBox.MultiColumn = true;
            this.ticketsListBox.Name = "ticketsListBox";
            this.ticketsListBox.Size = new System.Drawing.Size(730, 148);
            this.ticketsListBox.TabIndex = 30;
            this.ticketsListBox.SelectedIndexChanged += new System.EventHandler(this.ticketsListBox_SelectedIndexChanged);
            // 
            // flightLabel
            // 
            this.flightLabel.AutoSize = true;
            this.flightLabel.BackColor = System.Drawing.Color.Transparent;
            this.flightLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.flightLabel.ForeColor = System.Drawing.Color.Pink;
            this.flightLabel.Location = new System.Drawing.Point(24, 116);
            this.flightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flightLabel.Name = "flightLabel";
            this.flightLabel.Size = new System.Drawing.Size(308, 27);
            this.flightLabel.TabIndex = 29;
            this.flightLabel.Text = "Book your flight to (Country):";
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.BackColor = System.Drawing.Color.Transparent;
            this.stepLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepLabel.ForeColor = System.Drawing.Color.White;
            this.stepLabel.Location = new System.Drawing.Point(23, 86);
            this.stepLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(236, 29);
            this.stepLabel.TabIndex = 28;
            this.stepLabel.Text = "You\'re one step ahead!";
            // 
            // DepartingFlightsLabel
            // 
            this.DepartingFlightsLabel.AutoSize = true;
            this.DepartingFlightsLabel.BackColor = System.Drawing.Color.Transparent;
            this.DepartingFlightsLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartingFlightsLabel.ForeColor = System.Drawing.Color.Pink;
            this.DepartingFlightsLabel.Location = new System.Drawing.Point(24, 311);
            this.DepartingFlightsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DepartingFlightsLabel.Name = "DepartingFlightsLabel";
            this.DepartingFlightsLabel.Size = new System.Drawing.Size(182, 27);
            this.DepartingFlightsLabel.TabIndex = 33;
            this.DepartingFlightsLabel.Text = "Departing Flights";
            this.DepartingFlightsLabel.Visible = false;
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.Pink;
            this.goButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(634, 658);
            this.goButton.Margin = new System.Windows.Forms.Padding(2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(123, 34);
            this.goButton.TabIndex = 34;
            this.goButton.Text = "GO!";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(27, 658);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(98, 34);
            this.backButton.TabIndex = 35;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FROMLabel
            // 
            this.FROMLabel.AutoSize = true;
            this.FROMLabel.BackColor = System.Drawing.Color.Transparent;
            this.FROMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FROMLabel.ForeColor = System.Drawing.Color.Black;
            this.FROMLabel.Location = new System.Drawing.Point(36, 47);
            this.FROMLabel.Name = "FROMLabel";
            this.FROMLabel.Size = new System.Drawing.Size(60, 20);
            this.FROMLabel.TabIndex = 36;
            this.FROMLabel.Text = "FROM:";
            // 
            // DepartingPanel
            // 
            this.DepartingPanel.BackColor = System.Drawing.Color.White;
            this.DepartingPanel.Controls.Add(this.flightTimeLabel);
            this.DepartingPanel.Controls.Add(this.panel7);
            this.DepartingPanel.Controls.Add(this.panel5);
            this.DepartingPanel.Controls.Add(this.STOPLabel);
            this.DepartingPanel.Controls.Add(this.FlightPriceLabel);
            this.DepartingPanel.Controls.Add(this.arriveTimeLabel);
            this.DepartingPanel.Controls.Add(this.ToLabel);
            this.DepartingPanel.Controls.Add(this.departureTimeLabel);
            this.DepartingPanel.Controls.Add(this.panel2);
            this.DepartingPanel.Controls.Add(this.FROMLabel);
            this.DepartingPanel.Location = new System.Drawing.Point(29, 341);
            this.DepartingPanel.Name = "DepartingPanel";
            this.DepartingPanel.Size = new System.Drawing.Size(728, 118);
            this.DepartingPanel.TabIndex = 41;
            this.DepartingPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.panel2.Controls.Add(this.AIRLINELabel);
            this.panel2.Controls.Add(this.DepartureDateLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 36);
            this.panel2.TabIndex = 42;
            // 
            // DepartureDateLabel
            // 
            this.DepartureDateLabel.AutoSize = true;
            this.DepartureDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartureDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DepartureDateLabel.Location = new System.Drawing.Point(11, 7);
            this.DepartureDateLabel.Name = "DepartureDateLabel";
            this.DepartureDateLabel.Size = new System.Drawing.Size(131, 24);
            this.DepartureDateLabel.TabIndex = 0;
            this.DepartureDateLabel.Text = "DepartureDate";
            // 
            // departureTimeLabel
            // 
            this.departureTimeLabel.AutoSize = true;
            this.departureTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.departureTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.departureTimeLabel.Location = new System.Drawing.Point(36, 67);
            this.departureTimeLabel.Name = "departureTimeLabel";
            this.departureTimeLabel.Size = new System.Drawing.Size(47, 20);
            this.departureTimeLabel.TabIndex = 43;
            this.departureTimeLabel.Text = "TIME";
            // 
            // arriveTimeLabel
            // 
            this.arriveTimeLabel.AutoSize = true;
            this.arriveTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.arriveTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arriveTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.arriveTimeLabel.Location = new System.Drawing.Point(384, 67);
            this.arriveTimeLabel.Name = "arriveTimeLabel";
            this.arriveTimeLabel.Size = new System.Drawing.Size(47, 20);
            this.arriveTimeLabel.TabIndex = 45;
            this.arriveTimeLabel.Text = "TIME";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.BackColor = System.Drawing.Color.Transparent;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.ForeColor = System.Drawing.Color.Black;
            this.ToLabel.Location = new System.Drawing.Point(384, 47);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(30, 20);
            this.ToLabel.TabIndex = 44;
            this.ToLabel.Text = "TO";
            // 
            // FlightPriceLabel
            // 
            this.FlightPriceLabel.AutoSize = true;
            this.FlightPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.FlightPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.FlightPriceLabel.Location = new System.Drawing.Point(624, 67);
            this.FlightPriceLabel.Name = "FlightPriceLabel";
            this.FlightPriceLabel.Size = new System.Drawing.Size(58, 20);
            this.FlightPriceLabel.TabIndex = 46;
            this.FlightPriceLabel.Text = "PRICE";
            // 
            // AIRLINELabel
            // 
            this.AIRLINELabel.AutoSize = true;
            this.AIRLINELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIRLINELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AIRLINELabel.Location = new System.Drawing.Point(333, 7);
            this.AIRLINELabel.Name = "AIRLINELabel";
            this.AIRLINELabel.Size = new System.Drawing.Size(81, 24);
            this.AIRLINELabel.TabIndex = 1;
            this.AIRLINELabel.Text = "AIRLINE";
            // 
            // ReturningPanel
            // 
            this.ReturningPanel.BackColor = System.Drawing.Color.White;
            this.ReturningPanel.Controls.Add(this.returnFlightTimeLabel);
            this.ReturningPanel.Controls.Add(this.panel8);
            this.ReturningPanel.Controls.Add(this.panel6);
            this.ReturningPanel.Controls.Add(this.returnSTOPLabel);
            this.ReturningPanel.Controls.Add(this.returnFlightPriceLabel);
            this.ReturningPanel.Controls.Add(this.returnToTimeLabel);
            this.ReturningPanel.Controls.Add(this.ReturnToLabel);
            this.ReturningPanel.Controls.Add(this.returnTimeLabel);
            this.ReturningPanel.Controls.Add(this.panel4);
            this.ReturningPanel.Controls.Add(this.ReturnFromLabel);
            this.ReturningPanel.Location = new System.Drawing.Point(29, 512);
            this.ReturningPanel.Name = "ReturningPanel";
            this.ReturningPanel.Size = new System.Drawing.Size(728, 118);
            this.ReturningPanel.TabIndex = 43;
            this.ReturningPanel.Visible = false;
            // 
            // returnFlightPriceLabel
            // 
            this.returnFlightPriceLabel.AutoSize = true;
            this.returnFlightPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.returnFlightPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnFlightPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.returnFlightPriceLabel.Location = new System.Drawing.Point(624, 67);
            this.returnFlightPriceLabel.Name = "returnFlightPriceLabel";
            this.returnFlightPriceLabel.Size = new System.Drawing.Size(58, 20);
            this.returnFlightPriceLabel.TabIndex = 46;
            this.returnFlightPriceLabel.Text = "PRICE";
            // 
            // returnToTimeLabel
            // 
            this.returnToTimeLabel.AutoSize = true;
            this.returnToTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.returnToTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.returnToTimeLabel.Location = new System.Drawing.Point(384, 67);
            this.returnToTimeLabel.Name = "returnToTimeLabel";
            this.returnToTimeLabel.Size = new System.Drawing.Size(47, 20);
            this.returnToTimeLabel.TabIndex = 45;
            this.returnToTimeLabel.Text = "TIME";
            // 
            // ReturnToLabel
            // 
            this.ReturnToLabel.AutoSize = true;
            this.ReturnToLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReturnToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToLabel.ForeColor = System.Drawing.Color.Black;
            this.ReturnToLabel.Location = new System.Drawing.Point(384, 47);
            this.ReturnToLabel.Name = "ReturnToLabel";
            this.ReturnToLabel.Size = new System.Drawing.Size(30, 20);
            this.ReturnToLabel.TabIndex = 44;
            this.ReturnToLabel.Text = "TO";
            // 
            // returnTimeLabel
            // 
            this.returnTimeLabel.AutoSize = true;
            this.returnTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.returnTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.returnTimeLabel.Location = new System.Drawing.Point(36, 67);
            this.returnTimeLabel.Name = "returnTimeLabel";
            this.returnTimeLabel.Size = new System.Drawing.Size(47, 20);
            this.returnTimeLabel.TabIndex = 43;
            this.returnTimeLabel.Text = "TIME";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.panel4.Controls.Add(this.ReturnAIRLINELabel);
            this.panel4.Controls.Add(this.ReturnDateLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(728, 36);
            this.panel4.TabIndex = 42;
            // 
            // ReturnAIRLINELabel
            // 
            this.ReturnAIRLINELabel.AutoSize = true;
            this.ReturnAIRLINELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnAIRLINELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReturnAIRLINELabel.Location = new System.Drawing.Point(333, 7);
            this.ReturnAIRLINELabel.Name = "ReturnAIRLINELabel";
            this.ReturnAIRLINELabel.Size = new System.Drawing.Size(81, 24);
            this.ReturnAIRLINELabel.TabIndex = 1;
            this.ReturnAIRLINELabel.Text = "AIRLINE";
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReturnDateLabel.Location = new System.Drawing.Point(11, 7);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(104, 24);
            this.ReturnDateLabel.TabIndex = 0;
            this.ReturnDateLabel.Text = "ReturnDate";
            // 
            // ReturnFromLabel
            // 
            this.ReturnFromLabel.AutoSize = true;
            this.ReturnFromLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReturnFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnFromLabel.ForeColor = System.Drawing.Color.Black;
            this.ReturnFromLabel.Location = new System.Drawing.Point(36, 47);
            this.ReturnFromLabel.Name = "ReturnFromLabel";
            this.ReturnFromLabel.Size = new System.Drawing.Size(60, 20);
            this.ReturnFromLabel.TabIndex = 36;
            this.ReturnFromLabel.Text = "FROM:";
            // 
            // ReturningFlightsLabel
            // 
            this.ReturningFlightsLabel.AutoSize = true;
            this.ReturningFlightsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReturningFlightsLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturningFlightsLabel.ForeColor = System.Drawing.Color.Pink;
            this.ReturningFlightsLabel.Location = new System.Drawing.Point(24, 482);
            this.ReturningFlightsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReturningFlightsLabel.Name = "ReturningFlightsLabel";
            this.ReturningFlightsLabel.Size = new System.Drawing.Size(183, 27);
            this.ReturningFlightsLabel.TabIndex = 42;
            this.ReturningFlightsLabel.Text = "Returning Flights";
            this.ReturningFlightsLabel.Visible = false;
            // 
            // STOPLabel
            // 
            this.STOPLabel.AutoSize = true;
            this.STOPLabel.BackColor = System.Drawing.Color.Transparent;
            this.STOPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STOPLabel.ForeColor = System.Drawing.Color.Black;
            this.STOPLabel.Location = new System.Drawing.Point(206, 79);
            this.STOPLabel.Name = "STOPLabel";
            this.STOPLabel.Size = new System.Drawing.Size(51, 20);
            this.STOPLabel.TabIndex = 47;
            this.STOPLabel.Text = "STOP";
            // 
            // returnSTOPLabel
            // 
            this.returnSTOPLabel.AutoSize = true;
            this.returnSTOPLabel.BackColor = System.Drawing.Color.Transparent;
            this.returnSTOPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnSTOPLabel.ForeColor = System.Drawing.Color.Black;
            this.returnSTOPLabel.Location = new System.Drawing.Point(197, 83);
            this.returnSTOPLabel.Name = "returnSTOPLabel";
            this.returnSTOPLabel.Size = new System.Drawing.Size(51, 20);
            this.returnSTOPLabel.TabIndex = 48;
            this.returnSTOPLabel.Text = "STOP";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(134, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 2);
            this.panel5.TabIndex = 48;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(143, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 2);
            this.panel6.TabIndex = 49;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(538, 49);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 50);
            this.panel7.TabIndex = 49;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(538, 53);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 50);
            this.panel8.TabIndex = 50;
            // 
            // flightTimeLabel
            // 
            this.flightTimeLabel.AutoSize = true;
            this.flightTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.flightTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.flightTimeLabel.Location = new System.Drawing.Point(206, 43);
            this.flightTimeLabel.Name = "flightTimeLabel";
            this.flightTimeLabel.Size = new System.Drawing.Size(51, 20);
            this.flightTimeLabel.TabIndex = 50;
            this.flightTimeLabel.Text = "STOP";
            // 
            // returnFlightTimeLabel
            // 
            this.returnFlightTimeLabel.AutoSize = true;
            this.returnFlightTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.returnFlightTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnFlightTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.returnFlightTimeLabel.Location = new System.Drawing.Point(206, 44);
            this.returnFlightTimeLabel.Name = "returnFlightTimeLabel";
            this.returnFlightTimeLabel.Size = new System.Drawing.Size(51, 20);
            this.returnFlightTimeLabel.TabIndex = 51;
            this.returnFlightTimeLabel.Text = "STOP";
            // 
            // ticketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPE361_FinalProject_A00723_A00217_A00755.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(812, 705);
            this.Controls.Add(this.ReturningPanel);
            this.Controls.Add(this.ReturningFlightsLabel);
            this.Controls.Add(this.DepartingPanel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.DepartingFlightsLabel);
            this.Controls.Add(this.ticketsListBox);
            this.Controls.Add(this.flightLabel);
            this.Controls.Add(this.stepLabel);
            this.Controls.Add(this.planePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ticketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book your ticket";
            this.Load += new System.EventHandler(this.ticketForm_Load);
            this.planePanel.ResumeLayout(false);
            this.planePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planePictureBox)).EndInit();
            this.DepartingPanel.ResumeLayout(false);
            this.DepartingPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ReturningPanel.ResumeLayout(false);
            this.ReturningPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel planePanel;
        private System.Windows.Forms.PictureBox planePictureBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Timer planeTimer;
        private System.Windows.Forms.ListBox ticketsListBox;
        private System.Windows.Forms.Label flightLabel;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.Label DepartingFlightsLabel;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label FROMLabel;
        private System.Windows.Forms.Panel DepartingPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DepartureDateLabel;
        private System.Windows.Forms.Label arriveTimeLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label departureTimeLabel;
        private System.Windows.Forms.Label FlightPriceLabel;
        private System.Windows.Forms.Label AIRLINELabel;
        private System.Windows.Forms.Panel ReturningPanel;
        private System.Windows.Forms.Label returnFlightPriceLabel;
        private System.Windows.Forms.Label returnToTimeLabel;
        private System.Windows.Forms.Label ReturnToLabel;
        private System.Windows.Forms.Label returnTimeLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ReturnAIRLINELabel;
        private System.Windows.Forms.Label ReturnDateLabel;
        private System.Windows.Forms.Label ReturnFromLabel;
        private System.Windows.Forms.Label ReturningFlightsLabel;
        private System.Windows.Forms.Label STOPLabel;
        private System.Windows.Forms.Label returnSTOPLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label flightTimeLabel;
        private System.Windows.Forms.Label returnFlightTimeLabel;
    }
}