using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public class Engine : IEngine
    {
        protected bool isStarted;

        public bool IsStarted { get => this.isStarted; protected set => this.isStarted = value; }


        public Engine()
        {
           this.isStarted = false;
        }

        public virtual void Start()
        {
            isStarted = true;
        }

        public virtual void Stop()
        {
            isStarted = false;
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
