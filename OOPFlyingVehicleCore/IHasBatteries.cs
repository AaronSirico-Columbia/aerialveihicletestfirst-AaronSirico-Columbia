using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFlyingVehicleCore
{
    internal interface IHasBatteries
    {

        bool HasBatteries { get; set; }

        bool IsCharged { get; set; }

        int ChargeLeft { get; set; }


        public int ReturnCharge()
        {
            return ChargeLeft;
        }
    }
}
