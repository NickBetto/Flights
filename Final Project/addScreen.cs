using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace Final_Project
{
    public partial class addScreen : UserControl
    {
        public addScreen()
        {
            InitializeComponent();
            printFlights();
        }

        public void printFlights()
        {
            //display all flight onto the screen
            flight1Time.Text = "";
            flight1Destination.Text = "";
            flight1fnumber.Text = "";
            flight1Gate.Text = "";
            flight1Status.Text = "";

            foreach (flight f in editScreen.foundFlights)
            {
                for (int i = 0; i < f.time.Length; i++)
                {
                    flight1Time.Text += f.time.Substring(i, 1) + "";
                }
                for (int i = 0; i < f.destination.Length; i++)
                {
                    flight1Destination.Text += f.destination.Substring(i, 1) + "";
                }
                for (int i = 0; i < f.flightNumber.Length; i++)
                {
                    flight1fnumber.Text += f.flightNumber.Substring(i, 1) + "";
                }
                for (int i = 0; i < f.gate.Length; i++)
                {
                    flight1Gate.Text += f.gate.Substring(i, 1) + "";
                }
                for (int i = 0; i < f.status.Length; i++)
                {
                    flight1Status.Text += f.status.Substring(i, 1) + "";
                }
                flight1Time.Text += "\n";
                flight1Destination.Text += "\n";
                flight1fnumber.Text += "\n";
                flight1Status.Text += "\n";
                flight1Gate.Text += "\n";
            }
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            //clear foundflights list
            editScreen.foundFlights.Clear();
            //go to home screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            mainScreen ms = new mainScreen();
            f.Controls.Add(ms);
            ms.Focus();
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            //take all information and put it into an objects
            string time = timeAddInput.Text;
            string destination = addDestinationInput.Text;
            string flightNumber = addFNumberInput.Text;
            string gate = addGateInput.Text;
            string status = addStatusInput.Text;

            //add to lists
            flight fs = new flight(time, destination, flightNumber, gate, status);
            managerScreen.flights.Add(fs);
            editScreen.foundFlights.Add(fs);

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
            //add to textfile
            File.WriteAllLines("flights.txt", tempList);
            printFlights();
        }
    }
}
