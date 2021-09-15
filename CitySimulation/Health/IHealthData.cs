﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CitySimulation.Health
{
    public interface IHealthData
    {
        HealthStatus HealthStatus { get; set; }
        bool Infected { get; }
        void Process();
        bool TryInfect();
    }

    public enum HealthStatus
    {
        Susceptible,
        InfectedIncubation,
        InfectedSpread,
        Recovered,
        Dead
    }
}
