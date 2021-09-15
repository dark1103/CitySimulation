﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using CitySimulation.Control;
using CitySimulation.Health;
using CitySimulation.Tools;
using CitySimulation.Ver2.Entity;
using CitySimulation.Ver2.Entity.Behaviour;

namespace CitySimulation.Ver2.Control
{
    /// <summary>
    /// Модуль отвечает за вывод и запись информации
    /// </summary>
    public class KeyValuesWriteModule : Module
    {
        public string Filename;
        private AsyncWriter asyncWriter;

        private Dictionary<string, object> dataToLog = new Dictionary<string, object>();

        private List<int> timeHistory = new List<int>();
        private Dictionary<string, List<float>> history = new Dictionary<string, List<float>>();

        private List<string> keys;

        private int nextLogTime = -1;
        public int LogDeltaTime = 24 * 60;
        public int LogOffset = 8 * 60;
        public bool PrintConsole;


        private List<string> locationTypes;
        private List<string> incomeItems;
        public override void Setup(Controller controller)
        {
            base.Setup(controller);
            nextLogTime = LogOffset;
            if (!(controller is ControllerSimple))
            {
                throw new Exception("ControllerSimple expected");
            }

            locationTypes = controller.City.Facilities.Values.Cast<FacilityConfigurable>().Select(x=>x.Type).Distinct().ToList();
            incomeItems = controller.City.Persons.Select(x=>x.Behaviour).Cast<ConfigurableBehaviour>().SelectMany(x=>x.Money.Keys).Distinct().ToList();
            keys = new List<string>();

            keys.AddRange(new string[]
            {
                "Time",
                "Average contacts count per day",
                "Infected count",
                "Uninfected count",
            });

            foreach (string type in locationTypes)
            {
                keys.Add("Count of people in " + type);
            }

            foreach (string type in locationTypes)
            {
                keys.Add("Average stay time in " + type);
            }

            foreach (string incomeItem in incomeItems)
            {
                keys.Add(incomeItem);
            }

            foreach (string healthStatus in Enum.GetNames(typeof(HealthStatus)))
            {
                keys.Add("HealthStatus - " + healthStatus);
            }

            foreach (var key in keys)
            {
                history.Add(key, new List<float>());
            }

            if (Filename != null)
            {
                asyncWriter = new AsyncWriter(Filename, false);
                asyncWriter.AddLine(String.Join(';', keys));
            }
        }

        public override void PreProcess()
        {
            int totalMinutes = Controller.Context.CurrentTime.TotalMinutes;

            if (nextLogTime < totalMinutes)
            {
                dataToLog.Clear();

                LogAll();

                nextLogTime += LogDeltaTime;
            }
        }

        private void LogAll()
        {
            LogTime(Controller.Context.CurrentTime);

            Dictionary<string, int> personsInLocations = Controller.City.Persons.GroupBy(x => ((FacilityConfigurable)x.Location)?.Type).Where(x => x.Key != null).ToDictionary(x => x.Key, x => x.Count());
            foreach (var type in locationTypes)
            {
                Log("Count of people in " + type, personsInLocations.GetValueOrDefault(type, 0));
            }

            double avg = Controller.City.Persons.Average(x => ((ConfigurableBehaviour)x.Behaviour).GetDayContactsCount());
            int infected = Controller.City.Persons.Count(x => x.HealthData.HealthStatus == HealthStatus.InfectedIncubation && x.HealthData.HealthStatus == HealthStatus.InfectedSpread);
            int nonInfected = Controller.City.Persons.Count(x => x.HealthData.HealthStatus == HealthStatus.Susceptible && x.HealthData.HealthStatus == HealthStatus.Recovered);


            Log("Average contacts count per day", (float)avg);
            Log("Infected count", infected);
            Log("Uninfected count", nonInfected);

            Dictionary<HealthStatus, int> healthStatuses = Controller.City.Persons.GroupBy(x => x.HealthData.HealthStatus).ToDictionary(x => x.Key, x => x.Count());

            foreach (HealthStatus healthStatus in Enum.GetValues(typeof(HealthStatus)))
            {
                Log("HealthStatus - " + healthStatus, healthStatuses.GetValueOrDefault(healthStatus, 0));
            }

            Dictionary<string, float> minutesInLocations = Controller.City.Persons.Select(x => ((ConfigurableBehaviour)x.Behaviour).minutesInLocation).SelectMany(d => d) // Flatten the list of dictionaries
                .GroupBy(kvp => kvp.Key, kvp => kvp.Value) // Group the products
                .ToDictionary(g => g.Key, g => g.Average());

            foreach (string type in locationTypes)
            {
                Log("Average stay time in " + type, minutesInLocations.GetValueOrDefault(type, 0));
            }


            Dictionary<string, long> incomeDictionary = Controller.City.Persons.Select(x => x.Behaviour).Cast<ConfigurableBehaviour>()
                .SelectMany(x => x.Money)
                .GroupBy(x => x.Key, x => x.Value)
                .ToDictionary(x=>x.Key, x=>x.Sum());
            
            foreach (var income in incomeDictionary)
            {
                Log(income.Key, income.Value);
            }

            FlushLog();
        }

        private void LogTime(CityTime time)
        {
            dataToLog.Add("Time", time.ToString());

            timeHistory.Add(time.TotalMinutes);
        }

        private void Log(string name, string data)
        {
            dataToLog.Add(name, data);
        }

        private void Log(string name, float data)
        {
            dataToLog.Add(name, data);
            history[name].Add(data);
        }

        private void FlushLog()
        {
            if (PrintConsole)
            {
                Debug.WriteLine("");
                Console.WriteLine();
                foreach (var (name, data) in dataToLog)
                {
                    Debug.WriteLine(name + ": " + data);
                    Console.WriteLine(name + ": " + data);
                }
            }

            if (asyncWriter != null)
            {
                List<string> data = new List<string>();
                foreach (var key in keys)
                {
                    data.Add(dataToLog.GetValueOrDefault(key, "")?.ToString());
                }

                asyncWriter.AddLine(string.Join(';', data));
            }



            dataToLog.Clear();
        }

        public override void Finish()
        {
            asyncWriter?.Close();
        }

        public (List<int>, Dictionary<string, List<float>>) GetHistory()
        {
            return (timeHistory, history.Where(x=>x.Value.Count > 0).ToDictionary(x=>x.Key, x=>x.Value));
        }
    }
}
