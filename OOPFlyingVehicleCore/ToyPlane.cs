using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public class ToyPlane : Airplane
    {
        bool isWoundUP
        {
            get;
            
        }

        public ToyPlane()
        {
            this.MaxAltitude = 50;
            this.Engine = new ToyEngine();
        }

        public override void StartEngine()
        {
            throw new NotImplementedException();
        }

        public override string TakeOff()
        {
            throw new NotImplementedException();
        }

        public void WindUp()
        {
            while (((ToyEngine)Engine).IsFullyWound == false)
            {
                this.Wind();
            }
        }

        public void Wind()
        {
            ((ToyEngine)Engine).Wind();
        }

        public void UnWind()
        {
            throw new NotImplementedException();
        }

        public void UnWindCompletely()
        {
            throw new NotImplementedException();
        }

        protected string getWindUpString()
        {
            string woundUp = "It's not wound up.";
            if(isWoundUP) woundUp = woundUp.Replace("not ", "");
            return woundUp;
        }

        public override string About()
        {
            return base.About() + "\n" + this.getWindUpString();
        }
    }
}
