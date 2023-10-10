using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public class Helicopter : AerialVehicle, IHasEngine
    {

        public bool HasEngine { get; set; }
        public Helicopter()
        {
            this.MaxAltitude = 8000;
        }
        public void StopEngine()
        {
            Engine.Stop();
        }
    }
}
