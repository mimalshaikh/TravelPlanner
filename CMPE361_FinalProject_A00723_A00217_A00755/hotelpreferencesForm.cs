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
    public partial class hotelpreferencesForm : Form
    {
        DBManager dbManager;
        public hotelpreferencesForm()
        {
            InitializeComponent();
            dbManager = new DBManager();
        }

        private void hotelpreferencesForm_Load(object sender, EventArgs e)
        {
            planeTimer.Interval = 50;
            planeTimer.Start();
        }

        private void planeTimer_Tick(object sender, EventArgs e)
        {
            int x = (countryLabel.Location.X + 5) % (planePanel.Width);
            int y = (planePictureBox.Location.X + 5) % (planePanel.Width);


            countryLabel.Location = new Point(x, countryLabel.Location.Y);
            planePictureBox.Location = new Point(y, planePictureBox.Location.Y);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ticketForm ticket = new ticketForm();
            ticket.Show();
            this.Hide();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (getHotel(Plan.tickets.ArrivalCountry) >= 1)
            {
                Plan.hotel = new Hotel();
                Plan.HotelcheckIn = checkInComboBox.SelectedItem.ToString();
                Plan.HotelcheckOut = checkOutComboBox.SelectedItem.ToString();
                hotelForm hotel = new hotelForm();
                hotel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sorry, No Hotel Found");
            }

        }

        private void stepLabel_Click(object sender, EventArgs e)
        {

        }

        private void star1RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private int getHotel(string countryID)
        {
           
            string query = "SELECT * FROM Hotels WHERE countryID=@countryID";
            if (star2RadioButton.Checked)
            {
                query += " AND stars=2";
            }
            else if(star3RadioButton.Checked)
            {
                query += " AND stars=3";
            }
            else if (star4RadioButton.Checked)
            {
                query += " AND stars=4";
            }
            else if (star5RadioButton.Checked)
            {
                query += " AND stars=5";
            }

            if(withBRadioButton.Checked)
            {
                query += " AND breakfast=1";
            }
            else if(noBRadioButton.Checked)
            {
                query += " AND breakfast=0";
            }

            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@countryID",countryID),
            };

            DataTable dt = dbManager.ExecuteQuery(query, sqlParameter);

           
            Hotel[] hotels = new Hotel[dt.Rows.Count];
            for(int i = 0; i<dt.Rows.Count; i++)
            {
                hotels[i]= new Hotel();
                hotels[i].Id = dt.Rows[i]["id"].ToString();
                hotels[i].Title = dt.Rows[i]["Title"].ToString();
                hotels[i].CountryID = dt.Rows[i]["countryID"].ToString();
                hotels[i].stars = dt.Rows[i]["stars"].ToString();
                hotels[i].breakfast = Convert.ToBoolean(dt.Rows[i]["breakfast"].ToString()) ? true: false ;

            }
            Plan.hotels = hotels;

            return dt.Rows.Count;
        }
    }
}
