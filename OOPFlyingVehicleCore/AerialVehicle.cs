using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public abstract class AerialVehicle : IFlyable
    {
        public int CurrentAltitude { get; set; }

        public Engine Engine { get; set; }

        public bool IsFlying { get; set; }

        public int MaxAltitude { get; set; }



        public AerialVehicle()
        {
            this.Engine = new Engine();
            IsFlying = false;
            this.CurrentAltitude = 0;

        }

        public string About()
        {
            return $"This OOPFlyingVehicle.Airplane has a max altitude of 41000 ft.\nIt's current altitude is {CurrentAltitude} ft.\nOOPFlyingVehicle.Engine is {getEngineStartedString()}.";
        }

        public string TakeOff()
        {
            if (Engine.IsStarted == true)
                return "OOPFlyingVehicle.Airplane is flying";
            else
                return "OOPFlyingVehicle.Airplane can't fly it's engine is not started.";

        }

        public void StartEngine()
        {
            Engine.IsStarted = true;
            getEngineStartedString();
        }

        public void FlyDown()
        {
            throw new NotImplementedException();
        }

        public void FlyDown(int HowManyFeet)
        {
            if (HowManyFeet <= 41000)
                CurrentAltitude = 0;
            else
                CurrentAltitude = 41000;

            if (HowManyFeet < -1000) throw new InvalidOperationException("Can't FlyDown a negative amount");
           
        }

        public void FlyUp()
        {
            CurrentAltitude = 1000;
            if (CurrentAltitude >= 0)
            {
                IsFlying = true;
            }
        }

        public void FlyUp(int HowManyFeet)
        {
            if (HowManyFeet <= 41000)
                CurrentAltitude = HowManyFeet + CurrentAltitude;
            else
                CurrentAltitude = 1000;
            //If HowMany feet is nagtive trow invaid operation exception
            if (HowManyFeet < 0) throw new InvalidOperationException("Can't FlyUp a negative amount");

       
        }

        public string getEngineStartedString()
        {
            if (Engine.IsStarted == true)
                return "started";
            else
                return "not started";
        }
    }
}
