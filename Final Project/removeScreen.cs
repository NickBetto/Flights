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
    public partial class removeScreen : UserControl
    {
        public removeScreen()
        {
            InitializeComponent();
            #region clearLabels
            flight1Time.Text = "";
            flight1Destination.Text = "";
            flight1fnumber.Text = "";
            flight1Gate.Text = "";
            flight1Status.Text = "";
            #endregion
            printFlights();
        }

        public void printFlights()
        {
            //put all the flight information onto the labels
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

        public void doneButton_Click(object sender, EventArgs e)
        {
            //Delete it from the Display and Lists
            string tempflightNumber = flightNumberInput.Text;

            flight Remove = managerScreen.flights.Find(x => x.flightNumber == tempflightNumber);
            editScreen.foundFlights.Remove(Remove);
            managerScreen.flights.Remove(Remove);
            #region clearLabels
            flight1Time.Text = "";
            flight1Destination.Text = "";
            flight1fnumber.Text = "";
            flight1Gate.Text = "";
            flight1Status.Text = "";
            #endregion

            printFlights();

            //Delete it from all the textfile
            List<string> tempList = new List<string>();

            foreach (flight fs in managerScreen.flights)
            {
                tempList.Add(fs.time);
                tempList.Add(fs.destination);
                tempList.Add(fs.flightNumber);
                tempList.Add(fs.gate);
                tempList.Add(fs.status);
            }

            File.WriteAllLines("flights.txt", tempList);
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
    }
}
