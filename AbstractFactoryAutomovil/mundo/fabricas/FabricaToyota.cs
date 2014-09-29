using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;
using AbstractFactoryAutomovil.mundo.clases;

namespace AbstractFactoryAutomovil.mundo.fabricas
{
    class FabricaToyota : IFabricaDePartes
    {
        public IAuto crearAuto()
        {
            return new AutoToyota();
        }

        public IMotor crearMotor()
        {
            return new MotorToyota();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaToyota();
        }
    }
}