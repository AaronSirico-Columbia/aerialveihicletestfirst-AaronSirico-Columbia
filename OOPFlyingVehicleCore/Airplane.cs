using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public class Airplane : AerialVehicle, IHasEngine 
    {

        public bool HasEngine { get; set; }

        public Airplane()
        {
            this.MaxAltitude = 41000;
            this.CurrentAltitude= 0;
            
        }

        public void StopEngine()
        {
            Engine.Stop();
        }


    }
}
