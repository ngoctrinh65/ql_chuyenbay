using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAirport1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_for_flights ojbSearch_for_lights = new Search_for_flights();
            ojbSearch_for_lights.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Booking_confirmation ojbBooking_confirmation = new Booking_confirmation();
            ojbBooking_confirmation.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Billing_confirmation ojbBilling_confirmation = new Billing_confirmation();
            ojbBilling_confirmation.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Purchase_amenities purchase_Amenities = new Purchase_amenities();
            purchase_Amenities.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Booking_report booking_Report = new Booking_report();
            booking_Report.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Amenities_report amenities_Report = new Amenities_report();
            amenities_Report.ShowDialog();
        }
    }
}
