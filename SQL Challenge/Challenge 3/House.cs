﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenge.Challenge_3
{
    class House
    {
        public Guid HouseId { get; set; }
        public decimal NumberOfBedrooms { get; set; }
        public decimal NumberOfBaths { get; set; }
        public decimal EstimatedValue { get; set; }

    }
}
