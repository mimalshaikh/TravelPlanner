using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE361_FinalProject_A00723_A00217_A00755.classes
{
    public class Tickets
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Airline { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public string StopAirport { get; set; }
        public string DepartureCountry { get; set; }
        public string ArrivalCountry { get; set; }
        public bool Direct { get; set; }
        public string ReturnDate { get; set; }
        public string ReturnTime { get; set; }
        public string Flighttime { get; set; }
        public string DeparturePrice { get; set; }
        public string ReturnPrice { get; set; }

       
    }
}
