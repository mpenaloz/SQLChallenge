﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenge
{
    class FlightManagement
    {
        public int FlightId { get; set; }
        public DateTime DepartureTime {get;set;}
        public DateTime EstimatedArrivalTime { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public int Capacity { get; set; }
        public string AirlineName { get; set; }


    }
}
