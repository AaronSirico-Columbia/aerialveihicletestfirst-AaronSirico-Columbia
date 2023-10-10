using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFlyingVehicleCore
{
    internal class RemoteControlPlane : IHasBatteries
    {
        public bool HasBatteries { get; set; }
        public bool IsCharged { get; set; }
        public int ChargeLeft { get; set; }

        public int ReturnCharge()
        {
            return ChargeLeft;
        }
    }
}
