using OOPFlyingVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFlyingVehicleCore
{
    internal interface IHasEngine 
    {

        bool HasEngine { get; set; }

        public void StopEngine()
        {
            
        }

    }
}
