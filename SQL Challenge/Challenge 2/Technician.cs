using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenge.Challenge_2
{
    public class Technician
    {
        public Guid TechnicianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal CustomerRating { get; set; }
        public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
