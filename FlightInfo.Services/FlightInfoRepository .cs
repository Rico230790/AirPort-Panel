using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightInfo.Contracts;
using FlightInfo.Models;

namespace FlightInfo.Services
{
     class FlightInfoRepository : IFlightInfoRepository
    {
        static List<FlightIn> Storage = new List<FlightIn>();

        public void Add(FlightIn flihtInfo)
        {

        }
    }
}
