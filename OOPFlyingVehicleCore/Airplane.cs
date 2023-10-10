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

        public Airplane(IEngine engine) : base(engine)
        {
            this.MaxAltitude = 41000;
            this.CurrentAltitude = 0;
        }

        public void StopEngine()
        {
            Engine.Stop();
        }

        public string about()
        {
            return $"This OOPFlyingVehicle.Airplane has a max altitude of {MaxAltitude} ft.\r\nIt's current altitude is {CurrentAltitude} ft.\r\nOOPFlyingVehicle.Engine is {Engine}.";
        }


    }
}
