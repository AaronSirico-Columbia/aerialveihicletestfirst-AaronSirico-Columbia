using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public abstract class AerialVehicle : Engine, IFlyable
    {
        
        public bool IsFlying { get; set; }

        public int MaxAltitude { get; set; }

        protected int currentAltitude;
        protected IEngine engine;

        public int CurrentAltitude { get => currentAltitude; set => currentAltitude = value; }
        public IEngine Engine { get => engine; set => engine = value; }


        AerialVehicle ae;

        public AerialVehicle(IEngine engine)
        {
            
            this.Engine = engine;
            this.isStarted = false;
            this.currentAltitude = 0;
            this.IsFlying = false;
            this.MaxAltitude = 41000;
            

        }

        public string About()
        {
            return $"This {this.ToString()} has a max altitude of 41000 ft. \nIt's current altitude is 0 ft. \n{this.Engine.ToString()} is not started.";
        }

        public string TakeOff()
        {
            if (Engine.IsStarted == true)
            {
                CurrentAltitude = 41000;
                return "OOPFlyingVehicle.Airplane is flying";
            }
            else
                return "OOPFlyingVehicle.Airplane can't fly it's engine is not started.";

        }

        public void StartEngine()
        {
            if(Engine == null)
            {
                throw new ArgumentNullException(nameof(Engine));
            }
            IsStarted = true;
            getEngineStartedString();
            Engine.Start();
        }

        public void FlyDown()
        {
            if (0 <= MaxAltitude)
                CurrentAltitude = CurrentAltitude - 0;
            else
                CurrentAltitude = MaxAltitude;
        }

        public void FlyDown(int HowManyFeet)
        {
            try
            {
                if (HowManyFeet <= MaxAltitude)
                    CurrentAltitude = CurrentAltitude - HowManyFeet;
                else
                    CurrentAltitude = MaxAltitude;
            }
            catch (InvalidOperationException ex)
            {
                throw;
            }
            if (HowManyFeet < 0) throw new InvalidOperationException("Can't FlyDown a negative amount");
            
            
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
