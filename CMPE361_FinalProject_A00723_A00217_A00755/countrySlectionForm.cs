using CMPE361_FinalProject_A00723_A00217_A00755.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE361_FinalProject_A00723_A00217_A00755
{
    public partial class countrySlectionForm : Form
    {
        User user;
        DBManager dBManager;
        public countrySlectionForm()
        {
            InitializeComponent();
            user = LoginControl.loggedInUser;
            dBManager = new DBManager();
        }

        private void planeTimer_Tick(object sender, EventArgs e)
        {
            int x = (welcomeLabel.Location.X + 5) % (planePanel.Width);
            int y = (planePictureBox.Location.X + 5) % (planePanel.Width);


            welcomeLabel.Location = new Point(x, welcomeLabel.Location.Y);
            planePictureBox.Location = new Point(y, planePictureBox.Location.Y);
        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {
            loadCountry();
            planeTimer.Interval = 50;
            planeTimer.Start();

            welcomeLabel.Text = "Welcome " + user.FName.Substring(0,1).ToUpper()+ 
            user.FName.Substring(1).ToLower() + " " +
            user.LName.Substring(0, 1).ToUpper() + user.LName.Substring(1).ToLower();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
           Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            
            //Plan.user = LoginControl.loggedInUser;
            ticketForm ticket = new ticketForm();
            ticket.Show();
            this.Hide();

        }

        private void loadCountry()
        {
            string query = "SELECT * FROM Country";
           
            DataTable countries = dBManager.ExecuteQuery(query);
            string[] countriesList = new string[countries.Rows.Count];

            for (int i = 0; i < countries.Rows.Count; i++)
            {
                countriesList[i] = countries.Rows[i]["CountryName"].ToString();
            }
            countriesComboBox.DataSource = countriesList;
        }
       

        private void countriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Plan.country = countriesComboBox.Text;
        }
    }
}
