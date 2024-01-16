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
    public partial class Dashboard : Form
    {
        DBManager dbManager;
        public Dashboard()
        {
            InitializeComponent();
            dbManager =     new DBManager();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Welcome, " + Plan.user.FName.Substring(0, 1).ToUpper() + Plan.user.FName.Substring(1).ToLower();
            loadUserData();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
           loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Close();
        }

        private void createPlanButton_Click(object sender, EventArgs e)
        {
            countrySlectionForm country = new countrySlectionForm();
            country.Show();
            this.Hide();
        }


        private void loadUserData()
        {
            string query = "SELECT TOP (1000) info.[id], Country.CountryName as 'arrival Country', " +
                "Tickets.airline,Tickets.arrivalDate, Airport.airportCode,Airport.title as 'arrival Airport' " +
                ",Hotels.Title ,[checkInTime]  ,[checkOutTime]" +
                " FROM [dataBase-updated].[dbo].[info] " +
                "inner join Country on Country.id= info.CountryID " +
                "inner join Tickets on Tickets.id = info.TicketsID " +
                "inner join Airport on Airport.id = Tickets.arrivalAirport " +
                "inner join Hotels on Hotels.id = info.HotelsID\r\n  where info.usersID=@userID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userID",Plan.user.id),
            };

            DataTable userPlans = dbManager.ExecuteQuery(query, parameters);

            if (userPlans.Rows.Count > 0)
            {
                dataGridView1.DataSource = userPlans;
            }
        }
    }
}
