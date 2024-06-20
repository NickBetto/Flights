using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class account
    {
        public string username;
        public string password;
        public List<flight> personalFlights = new List<flight>();

        public account(string _username, string _password)
        {
            username = _username;
            password = _password;
        }
    }
}
