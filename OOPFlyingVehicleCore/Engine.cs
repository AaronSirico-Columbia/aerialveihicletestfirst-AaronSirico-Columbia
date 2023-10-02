using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public class Engine
    {
        public bool IsStarted;

        public Engine()
        {
            
        }

        public virtual void Start()
        {
            
        }

        public virtual void Stop()
        {
            
        }

        public virtual string About()
        {
            string engineString = this.ToString() + " is not started.";
            if (this.IsStarted)
            {
                engineString = engineString.Replace("not ", "");
            }
            return engineString;
        }
    }
}
