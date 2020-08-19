using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class ThingOfDefaults
    {
        public int Population;
        public DateTime When;
        public string name;
        public List<Person> People;

        //set constructor with defaults
        public ThingOfDefaults()
        {
            Population = default;
            When = default;
            name = default;
            People = default;

        }
    }
}