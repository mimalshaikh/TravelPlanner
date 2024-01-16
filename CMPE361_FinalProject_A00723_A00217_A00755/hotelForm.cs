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
    public partial class hotelForm : Form
    {
        public hotelForm()
        {
            InitializeComponent();
        }

        

        private void bagTimer_Tick(object sender, EventArgs e)
        {
            int x = (bagPictureBox.Location.X + 5) % (bagPanel.Width);
            bagPictureBox.Location = new Point(x, bagPictureBox.Location.Y);
        }

        private void hotelForm_Load(object sender, EventArgs e)
        {
            bagTimer.Interval = 50;
            bagTimer.Start();

            for (int i=0; i<Plan.hotels.Length; i++)
            {
                hotelsListBox.Items.Add(Plan.hotels[i].Title);
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            hotelpreferencesForm hotelP = new hotelpreferencesForm();
            hotelP.Show();
            this.Hide();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            notesForm notes = new notesForm();
            notes.Show();
            this.Hide();
        }

        private void hotelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = hotelsListBox.SelectedItem.ToString();
            
            Plan.hotel = new Hotel();
            Plan.hotel.Title = selectedValue;
        }
    }
    
    
}
