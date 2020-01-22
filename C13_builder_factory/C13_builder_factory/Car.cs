using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_builder_factory
{
    public abstract class Car
    {
        protected string Name;
        protected string Model;
        readonly string VIN;
        public string Wheels;
        public string Seats;
        public string Engine;
        public List<string> Equipment;
        public EngineFactory engineFactory = new EngineFactory();
    }
}
