using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE361_FinalProject_A00723_A00217_A00755.classes
{
    public class Plan
    {
        public static User user { set; get; }
        public static string country { set; get; }
        public static Tickets tickets { set; get; }
        public static Hotel[] hotels { set; get; }
        public static Hotel hotel { set; get; }
        public static string HotelcheckIn, HotelcheckOut;

    }
}
