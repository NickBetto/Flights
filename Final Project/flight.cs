using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class flight
    {
        public string time;
        public string destination;
        public string flightNumber;
        public string gate;
        public string status;

        public flight(string _time, string _destination, string _flightNumber, string _gate, string _status)
        {
            time = _time;
            destination = _destination;
            flightNumber = _flightNumber;
            gate = _gate;
            status = _status;
        }
    }
}
