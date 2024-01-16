using CMPE361_FinalProject_A00723_A00217_A00755.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE361_FinalProject_A00723_A00217_A00755
{
    public partial class finalItineraryForm : Form
    {
        DBManager dbManager;
        public finalItineraryForm()
        {
            InitializeComponent();
            dbManager = new DBManager();
        }

        private void finalItineraryForm_Load(object sender, EventArgs e)
        {
            
            userLabel.Text = "Ms/Mrs. " + Plan.user.FName + " " + Plan.user.LName;
            TripLabel.Text =  "Trip to " + getCountry(Plan.tickets.ArrivalCountry) + ", on "+ Plan.tickets.Airline;
            depFromTime.Text = Plan.tickets.DepartureTime;
            depToTime.Text = Plan.tickets.ArrivalTime;
            depDate.Text= Plan.tickets.DepartureDate;

            retuDate.Text = Plan.tickets.ReturnDate;
            retuFromTime.Text= Plan.tickets.DepartureDate;
            retuToTime.Text = Plan.tickets.ReturnTime;

            hotelLabel.Text = Plan.hotel.Title;
            checkInLabel.Text = Plan.HotelcheckIn;
            CheckoutLabel.Text = Plan.HotelcheckOut;
            /*
             * Ms/Mrs. (fName) (lName)
             * 
Trip to (country), on (Airline)
Tickets details: 
from (time) to (time) on (date)
from (time) to (time) on (date)
Staying at:
(Hotel name), from (date) to (date)
Remember to:
(notes list)

             * */
        }

        private String getCountry(string countryID)
        {
            string countryName = "";
            string query = "SELECT CountryName FROM country WHERE id=@countryID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@countryID",countryID),
            };
            DataTable county = dbManager.ExecuteQuery(query, sqlParameters);

            foreach (DataRow row in county.Rows)
            {
                countryID = row["CountryName"].ToString();
            }
            return countryID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard  = new Dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
