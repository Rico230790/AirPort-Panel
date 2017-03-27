using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightInfo.Models
{
   class FlightIn
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public FlightType Type { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string Airline { get; set; }
        public string Terminal { get; set; }
        public string Gate { get; set; }
        public FlightStatus Status { get; set; }
    }
}
