using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightInfo.Models;

namespace FlightInfo.Contracts
{
  public interface IConsoleService
    {
        void ShowMenuCommands();
        int GetCommand();
        void ShowFlightInfo(FlightIn flightInfo);
        FlightIn ReadFlightInfo();
        void ShowAirportPanel(IEnumerable<FlightIn> flightInfos);
        void ShowAirportPanelMessage(AirportPanelMessage message);
    }
}
