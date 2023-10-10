using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public class ToyPlane : Airplane
    {
        public bool isWoundUp { get; set; }


        public ToyPlane(IEngine engine) : base(engine)
        {
            isWoundUp = false;
            this.MaxAltitude = 50;
        }

        public string About()
        {
            return "ToyPlane's engine will not start unless it is woundup. ToyPlanes MaxAltitude is 50 ft";
        }

        public string getWindUpString()
        {
            if (Engine.IsStarted == true)
                return "have string";
            else
                return "do not have string";
        }

        public void WindUp()
        {
            getEngineStartedString();
        }

        public void StartEngine()
        {
            IsStarted = true;
        }

        public string TakeOff()
        {
            if (Engine.IsStarted == true)
                return "OOPFlyingVehicle.Airplane is flying";
            else
                return "OOPFlyingVehicle.Airplane can't fly it's engine is not started.";
        }

        public void UnWind()
        {
            IsStarted = false;
        }

        public void UnWindCompletely()
        {
            IsStarted = false;
        }

        public void Wind()
        {
            IsStarted = true;
        }

    }
}
