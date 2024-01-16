using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE361_FinalProject_A00723_A00217_A00755.classes
{
    public class Country
    {
        public string Id { get; set; }
        public string CountryName { get; set; }
        public Tickets[] ticketsList { get; set; }
        public Hotel[] hotels { get; set; }
    }
}
