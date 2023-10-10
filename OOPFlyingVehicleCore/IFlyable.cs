using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFlyingVehicleCore
{
    public interface IFlyable
    {
        int CurrentAltitude { get; set; }
        IEngine Engine { get; set; }

        
    }
}
