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
    public partial class managerScreen : UserControl
    {
        int code = 6389;
        public static List<flight> flights = new List<flight>();
        List<string> tempInfo = new List<string>();
        public managerScreen()
        {
            InitializeComponent();
            tempInfo.Clear();
            //read the entire textfile and put it into obects
            tempInfo = File.ReadAllLines("flights.txt").ToList();

            for (int i = 0; i < tempInfo.Count; i += 5)
            {
                string time = tempInfo[i];
                string destination = tempInfo[i + 1];
                string flightNumber = tempInfo[i + 2];
                string gate = tempInfo[i + 3];
                string status = tempInfo[i + 4];

                //put objects in list
                flight fs = new flight(time, destination, flightNumber, gate, status);
                flights.Add(fs);
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            //if code is correct go to edit screen
            if(codeInput.Text == $"{code}")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                editScreen es = new editScreen();
                f.Controls.Add(es);
                es.Focus();
            }
        }
    }
}
