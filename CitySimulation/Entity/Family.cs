﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CitySimulation.Entity
{
    public class Family
    {
        public Person Male;
        public Person Female;
        public List<Person> Children = new List<Person>(0);
        public List<Person> Elderly = new List<Person>(0);
        public static Family Unite(Person male, Person female)
        {
            if (male.Family != null || female.Family != null)
                throw new Exception("Person already have family");

            var family = new Family()
            {
                Male = male,
                Female = female
            };

            male.Family = family;
            female.Family = family;
            return family;
        }

        public void AddChild(Person child)
        {
            if (child.Family != null)
                throw new Exception("Person already have family");

            Children.Add(child);
            child.Family = this;
        }

        public void AddElderly(Person person)
        {
            if (person.Family != null)
                throw new Exception("Person already have family");

            Elderly.Add(person);
            person.Family = this;
        }

        public static Family Solo(Person person)
        {
            if (person.Family != null)
                throw new Exception("Person already have family");

            var family = person.Gender == Gender.Male ? new Family {Male = person} : new Family{ Female = person};

            person.Family = family;
            return family;
        }
    }
}
