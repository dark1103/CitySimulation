﻿using System;
using System.Collections.Generic;
using System.Text;
using CitySimulation.Entities;

namespace CitySimulation.Navigation
{
    public class Link
    {
        public Facility From;
        public Facility To;
        public double Length;
        public double Time;
        public bool Unconnected;
        public Link(Facility from, Facility to, double length)
        {
            From = from;
            To = to;
            Length = length;
            Time = length + 1;
        }

        public Link(Facility from, Facility to, double length, double time)
        {
            From = from;
            To = to;
            Length = length;
            Time = time;
        }

        public override string ToString()
        {
            return " -> " + To.ToLogString();
        }
    }
}
