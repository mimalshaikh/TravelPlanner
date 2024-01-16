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
    public partial class notesForm : Form
    {
        DBManager dbManager;
        public notesForm()
        {
            InitializeComponent();
            dbManager = new DBManager();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            notesListBox.Items.Add(notesTextBox.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            notesListBox.Items.Clear();
        }


        private void goButton_Click(object sender, EventArgs e)
        {
            if (SavePlanInToDatabase())
            {
                MessageBox.Show("Your trip plan created!");
                finalItineraryForm itinerary = new finalItineraryForm();
                itinerary.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error while creating your trip plan, please try again");
            }
        }

        private void notesForm_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            hotelForm form9 = new hotelForm();
            form9.Show();
            this.Hide();
        }

        private void notesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void notesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool SavePlanInToDatabase()
        {

            string query = "INSERT INTO [info] (usersID,CountryID,TicketsID,HotelsID,checkInTime,checkOutTime) VALUES (@usersID,@CountryID,@TicketsID,@HotelsID,@checkInTime,@checkOutTime)";



            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@usersID", Plan.user.id),
                new SqlParameter("@CountryID",getCountryID(Plan.country)),
                new SqlParameter("@TicketsID",Plan.tickets.Id),
                new SqlParameter("@HotelsID",Plan.hotels[0].Id),
                new SqlParameter("@checkInTime",Plan.HotelcheckIn),
                new SqlParameter("@checkOutTime",Plan.HotelcheckOut),

            };

            int isPlanCreated = dbManager.ExecuteNonQuery(query, parameters);

            if (isPlanCreated == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int getCountryID(string country)
        {
            int countryID = 0;
            string query = "SELECT id FROM country WHERE CountryName=@country";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@country",country),
            };
            DataTable county = dbManager.ExecuteQuery(query, sqlParameters);

            foreach (DataRow row in county.Rows)
            {
                countryID = Convert.ToInt32(row["id"].ToString());
            }
            return countryID;
        }

    }
}
