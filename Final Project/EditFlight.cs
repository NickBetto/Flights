using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project
{
    public partial class EditFlight : UserControl
    {
        public EditFlight()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //find flight and display its information
            string flightNumberSearch = flightNumberInput.Text;
            flight ff = managerScreen.flights.Find(x => x.flightNumber == flightNumberSearch);
            if (ff != null)
            {
                flightNumberInput.Text = "TRY AGAIN!";
            }
            else
            {
                timeChangeInput.Text = ff.time;
                destinationChangeInput.Text = ff.destination;
                flightNumberInput.Text = ff.flightNumber;
                gateChangeInput.Text = ff.gate;
                statusChangeInput.Text = ff.status;
                timeChangeInput.Enabled = true;
                destinationChangeInput.Enabled = true;
                flightNumberInput.Enabled = true;
                gateChangeInput.Enabled = true;
                statusChangeInput.Enabled = true;
            }
            managerScreen.flights.Remove(ff);
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            //Put all new info into a flight
            string time = timeChangeInput.Text;
            string destination = destinationChangeInput.Text;
            string flightNumber = flightNumberInput.Text;
            string gate = gateChangeInput.Text;
            string status = statusChangeInput.Text;

            flight fs = new flight(time, destination, flightNumber, gate, status);
            managerScreen.flights.Add(fs);

            //Convert the flights list to strings
            List<string> tempList = new List<string>();

            foreach (flight f in managerScreen.flights)
            {
                tempList.Add(f.time);
                tempList.Add(f.destination);
                tempList.Add(f.flightNumber);
                tempList.Add(f.gate);
                tempList.Add(f.status);
            }

            File.WriteAllLines("flights.txt", tempList);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            //clear flight list
            editScreen.foundFlights.Clear();
            //Back to home screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            mainScreen ms = new mainScreen();
            f.Controls.Add(ms);
            ms.Focus();
        }
    }
}
