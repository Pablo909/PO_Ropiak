using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_builder_factory
{
    public interface IEngine
    {
        string GetDescription();
    }

    public class Diesel136HP : IEngine
    {
        public string GetDescription()
        {
            return "Klasyczny Diesel 136 Koni";
        }
    }

    public class Diesel190HP : IEngine
    {
        public string GetDescription()
        {
            return "Diesel do wersji A4 i A6 automat";
        }
    }

    public class BiTurbo240HP : IEngine
    {
        public string GetDescription()
        {
            return "Benzynowa rakieta!";
        }
    }
    public class EngineFactory : IEngineFactory
    {
        private readonly Dictionary<string, IEngine> engines = new Dictionary<string, IEngine>()
    {
        { "diesel standard", new Diesel136HP() },
        { "diesel automat", new Diesel190HP() },
        { "benzyna biturbo", new BiTurbo240HP() }
    };

        public IEngine MakeEngine(string name)
        {
            IEngine engine;
            this.engines.TryGetValue(name, out engine);
            return engine;
        }
    }

}
