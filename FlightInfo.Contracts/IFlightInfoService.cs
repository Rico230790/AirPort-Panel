using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightInfo.Contracts
{
  public interface IFlightInfoService
    {
        void StartService();
        void ProcessCommand(int command);
        void AddFlight();
        void UpdateFlight();
        void SearchByNumber(string flightNumber);
        void SearchByTime(DateTime time);
        void SearchByCity(string city);
        void SearchByNearest();
    }
}
