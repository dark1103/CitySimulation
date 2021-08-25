﻿using System;
using System.Collections.Generic;
using System.Text;
using CitySimulation.Control;
using CitySimulation.Entities;

namespace CitySimulation.Health
{
    public class HealthDataSimple : IHealthData
    {
        public Person person;

        private HealthStatus healthStatus;

        public HealthStatus HealthStatus
        {
            get => healthStatus;
            set
            {
                healthStatus = value;
                if (value == HealthStatus.InfectedSpread)
                {
                    Infected = true;
                }
            }
        }

        public bool Infected { get; private set; }

        private int currentDay = -1;

        public HealthDataSimple(Person person)
        {
            this.person = person;
        }

        public void Process()
        {
            if (HealthStatus == HealthStatus.InfectedIncubation && person.Context.CurrentTime.Day != currentDay)
            {
                HealthStatus = HealthStatus.InfectedSpread;
                currentDay = -1;
            }
        }

        public bool TryInfect()
        {
            HealthStatus = HealthStatus.InfectedIncubation;
            currentDay = person.Context?.CurrentTime.Day ?? -1;
            return true;
        }
    }
}
