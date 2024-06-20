using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class editScreen : UserControl
    {
        public static List<flight> foundFlights;
        public editScreen()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //go to add screen and find all flight going to the destination
            if(destinationInput.Text.Length > 0)
            {
                findStuff();
                if(foundFlights.Count > 0)
                {
                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                    addScreen ads = new addScreen();
                    f.Controls.Add(ads);
                    ads.Focus();
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            //go to remove screen and find all flight going to the destination
                findStuff();
                if(foundFlights.Count > 0)
                {
                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                    removeScreen rs = new removeScreen();
                    f.Controls.Add(rs);
                    rs.Focus();
                }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //go to EditFlight screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            EditFlight efs = new EditFlight();
            f.Controls.Add(efs);
            efs.Focus();
        }

        public void findStuff()
        {
            //find all flights with the required destination
            string tempDestination = destinationInput.Text;

            foundFlights = managerScreen.flights.FindAll(x => x.destination == tempDestination);

            if (tempDestination == "")
            {
                fillLabel.Text = "You must enter a Destination";
            }

        }
    } 
}
