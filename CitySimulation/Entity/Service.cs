﻿using System;
using System.Collections.Generic;
using System.Text;
using CitySimulation.Tools;

namespace CitySimulation.Entity
{
    public class Service : Facility, IWorkplace
    {
        public Service(string name) : base(name)
        {
        }

        public TimeRange WorkTime { get; set; }
        public int WorkersCount { get; set; }
    }
}
