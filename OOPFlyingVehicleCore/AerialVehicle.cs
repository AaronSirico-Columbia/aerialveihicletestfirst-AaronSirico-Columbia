using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public class AerialVehicle
    {
        public Engine Engine { get; protected set; }
        public bool IsFlying { get; protected set; }
        public int MaxAltitude { get; protected set; }
        public int CurrentAltitude { get; protected set; }

        public AerialVehicle()
        {
            this.Engine = new Engine();
        }

        public virtual void StartEngine()
        {
            throw new NotImplementedException();
        }

        public virtual void StopEngine()
        {
            throw new NotImplementedException();
        }

        public void FlyUp()
        {
            throw new NotImplementedException();
        }

        public void FlyUp(int HowManyFeet)
        {
            //If HowMany feet is nagtive trow invaid operation exception
            if (HowManyFeet < 0) throw new InvalidOperationException("Can't FlyUp a negative amount");
            
            throw new NotImplementedException();
        }

        public void FlyDown()
        {
            throw new NotImplementedException();
        }

        public void FlyDown(int HowManyFeet)
        {
            if (HowManyFeet < -1000) throw new InvalidOperationException("Some Exception Message");
            throw new NotImplementedException();
        }
        public virtual string TakeOff()
        {
            if (Engine.IsStarted)
            {

                return string.Empty;
            }
            return string.Empty;
        }

        /// <summary>
        /// Returns a string that describes if an engine is started
        /// </summary>
        /// <returns></returns>
        protected string getEngineStartedString()
        {
            return this.Engine.About();
        }

        public virtual string About()
        {
            string about = string.Format("This {0} has a max altitude of {1} ft. \nIt's current altitude is {2} ft. \n{3}", 
                this.ToString(), this.MaxAltitude.ToString(), this.CurrentAltitude, this.getEngineStartedString());
            return about;
        }
    }
}
