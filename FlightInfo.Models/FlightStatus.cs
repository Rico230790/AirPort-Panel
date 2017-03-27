﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightInfo.Models
{
   public enum FlightStatus
    {
        Checkin,
        GateClosed,
        Arrived,
        Departured,
        Unknown,
        Canceled,
        Expected,
        Dellayed,
        InFlight
    }
}
