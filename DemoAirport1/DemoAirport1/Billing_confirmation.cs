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
    public partial class Billing_confirmation : Form
    {
        public decimal TotalCost { get; set; }
        public Billing_confirmation()
        {
            InitializeComponent();
        }
        private void Billing_confirmation_Load(object sender, EventArgs e)
        {
            tbtotal.Text = TotalCost.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtotal_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
