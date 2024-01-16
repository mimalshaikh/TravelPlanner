using CMPE361_FinalProject_A00723_A00217_A00755.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE361_FinalProject_A00723_A00217_A00755
{
    public partial class ticketForm : Form
    {
        DBManager dbManager;
        Tickets[] Tickets;
        public ticketForm()
        {
            InitializeComponent();
            dbManager = new DBManager();
            
        }

        private void ticketForm_Load(object sender, EventArgs e)
        {
            countryLabel.Text = "(off to( "+ Plan.country +" ))";
            flightLabel.Text = "Book your flight from: " + getCountry(Plan.user.country) + " to ("+ Plan.country +"):";

            getAirLineTickets(Plan.user.country);
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
            countrySlectionForm country = new countrySlectionForm();
            country.Show();
            this.Hide();
        }

        private void ticketsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                getTicketDetails(ticketsListBox.SelectedIndex - 2);
                DepartingFlightsLabel.Visible = true;
                DepartingPanel.Visible= true;
                ReturningPanel.Visible= true;
                ReturningFlightsLabel.Visible = true;


            }
            catch (Exception ex) {
                MessageBox.Show("Choose airline");
            }

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            hotelpreferencesForm hotelP = new hotelpreferencesForm();
            hotelP.Show();
            this.Hide();
        }

        //============== DataBase ===========================================
        private int getCountryID(string country)
        {
            int countryID = 0;
            string query = "SELECT id FROM country WHERE CountryName=@country";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@country",country),
            };
            DataTable county =dbManager.ExecuteQuery(query, sqlParameters);

            foreach (DataRow row in county.Rows)
            {
                countryID = Convert.ToInt32(row["id"].ToString());
            }
            return countryID;
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


        private void getAirLineTickets(string departureCountry)
        {
            string query = "SELECT * FROM Tickets WHERE departureCountry=@departureCountry";
           
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@departureCountry", departureCountry),
            };
            DataTable tickets = dbManager.ExecuteQuery(query, sqlParameters);

            
            ticketsListBox.Items.Add("\t#\tAirline\t\tFrom date\t\tTo date");
           
            ticketsListBox.Items.Add("================================================================================\n");
            
            if (tickets.Rows.Count==0)
            {
                ticketsListBox.Items.Add("-----------------------------No Record --------------------------------------");
            }
            else
            {
                Tickets = new Tickets[tickets.Rows.Count];

                for (int i = 0; i < tickets.Rows.Count; i++)
                {
                    Tickets[i]= new Tickets();
                    Tickets[i].Id = tickets.Rows[i]["id"].ToString();
                    Tickets[i].Airline = tickets.Rows[i]["airline"].ToString();
                    Tickets[i].DepartureDate = tickets.Rows[i]["departureDate"].ToString();
                    Tickets[i].DepartureDate = tickets.Rows[i]["departureDate"].ToString();
                    Tickets[i].ArrivalDate = tickets.Rows[i]["arrivalDate"].ToString();
                    Tickets[i].DepartureTime = tickets.Rows[i]["departureTime"].ToString();
                    Tickets[i].ArrivalTime = tickets.Rows[i]["arrivalTime"].ToString();
                    Tickets[i].DepartureAirport = tickets.Rows[i]["departureAirport"].ToString();
                    Tickets[i].ArrivalAirport = tickets.Rows[i]["arrivalAirport"].ToString();
                    Tickets[i].StopAirport = tickets.Rows[i]["stopAirport"].ToString();
                    Tickets[i].DepartureCountry = tickets.Rows[i]["departureCountry"].ToString();
                    Tickets[i].ArrivalCountry = tickets.Rows[i]["arrivalCountry"].ToString();
                    Tickets[i].Direct =Convert.ToBoolean(tickets.Rows[i]["direct"].ToString());
                    Tickets[i].ReturnDate = tickets.Rows[i]["returnDate"].ToString();
                    Tickets[i].ReturnTime = tickets.Rows[i]["returnTime"].ToString();
                    Tickets[i].Flighttime = tickets.Rows[i]["flighttime"].ToString();
                    Tickets[i].DeparturePrice = tickets.Rows[i]["departurePrice"].ToString();
                    Tickets[i].ReturnPrice = tickets.Rows[i]["returnPrice"].ToString();

                   
                    ticketsListBox.Items.Add("\t" + Tickets[i].Id + "\t"+ Tickets[i].Airline + "\t\t" + Tickets[i].DepartureDate + "\t\t"+ Tickets[i].ArrivalDate);
                    ticketsListBox.Items.Add("--------------------------------------------------------------------------------\n\n");
                }
            }   
        }

        private void getTicketDetails(int ticketIndex)
        {
            Plan.tickets = Tickets[ticketIndex];

           DepartureDateLabel.Text = Tickets[ticketIndex].DepartureDate;
            ReturnDateLabel.Text = Tickets[ticketIndex].ReturnDate;
            AIRLINELabel.Text = Tickets[ticketIndex].Airline;
            ReturnAIRLINELabel.Text = Tickets[ticketIndex].Airline; 

            FROMLabel.Text = getAirport(Tickets[ticketIndex].DepartureAirport).code  ;
            ToLabel.Text = getAirport(Tickets[ticketIndex].ArrivalAirport).code;
            FlightPriceLabel.Text = Tickets[ticketIndex].DeparturePrice+" BHD";
            departureTimeLabel.Text = Tickets[ticketIndex].DepartureTime;
            arriveTimeLabel.Text = Tickets[ticketIndex].ArrivalTime;
            flightTimeLabel.Text     = Tickets[ticketIndex].Flighttime;

            ReturnFromLabel.Text = getAirport(Tickets[ticketIndex].ArrivalAirport).code;
            ReturnToLabel.Text= getAirport(Tickets[ticketIndex].DepartureAirport).code;
            returnFlightPriceLabel.Text= Tickets[ticketIndex].ReturnPrice+" BHD"; ;
            STOPLabel.Text = Tickets[ticketIndex].Direct  ? "Direct" : getAirport(Tickets[ticketIndex].StopAirport).code;
            returnSTOPLabel.Text = Tickets[ticketIndex].Direct ? "Direct" : getAirport(Tickets[ticketIndex].StopAirport).code;
            returnTimeLabel.Text= Tickets[ticketIndex].ReturnTime;
            returnToTimeLabel.Text = Tickets[ticketIndex].DepartureTime;
            returnFlightTimeLabel.Text = Tickets[ticketIndex].Flighttime;

        }


        private AirPort getAirport(string airportIndex)
        {
            
            string query = "SELECT * FROM Airport WHERE id=@airportID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@airportID",airportIndex),
            };
            DataTable airPortTable = dbManager.ExecuteQuery(query,sqlParameters);

            AirPort airport = new AirPort();
            foreach (DataRow row in airPortTable.Rows)
            {
                airport.Id = row["id"].ToString();
                airport.Name = row["title"].ToString();
                airport.code = row["airportCode"].ToString();
            }

            return airport;
        }
        private void detailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
