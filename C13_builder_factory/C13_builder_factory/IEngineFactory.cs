using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_builder_factory
{
    public interface IEngineFactory
    {
        IEngine MakeEngine(string name);
    }
}
