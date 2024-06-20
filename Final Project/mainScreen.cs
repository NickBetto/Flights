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
    public partial class mainScreen : UserControl
    {
        List<account> accounts = new List<account>();
        public mainScreen()
        {
            InitializeComponent();
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            //go to manager screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            managerScreen mns = new managerScreen();
            f.Controls.Add(mns);
            mns.Focus();
        }

        //private void doneButton_Click(object sender, EventArgs e)
        //{
        //    if (usernameInput.Text.Length > 0 && passwordInput.Text.Length > 0)
        //    {
        //        string tempUsername = usernameInput.Text;
        //        account user = accounts.Find(x => x.username == tempUsername);
        //        if (user != null)
        //        {
        //            accounts.Add(user);
        //            Form f = this.FindForm();
        //            f.Controls.Remove(this);
        //            mainScreen ms = new mainScreen();
        //            f.Controls.Add(ms);
        //            ms.Focus();
        //        }
        //        else
        //        {

        //        }
        //    }
        //}
    }
}
