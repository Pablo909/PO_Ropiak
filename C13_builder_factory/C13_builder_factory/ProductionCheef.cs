using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_builder_factory
{
    public class ProductionCheef
    {
        readonly IBuilder Builder;

        public Car BuildCar(IBuilder builder)
        {
            builder.AddEngine();
            builder.AddSeats();
            builder.AddWheels();
            builder.AddEquipment();

            return builder.GetCar();
        }
    }
}
