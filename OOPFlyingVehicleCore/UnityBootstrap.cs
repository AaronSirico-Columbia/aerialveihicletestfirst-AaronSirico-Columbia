using OOPFlyingVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace OOPFlyingVehicleCore
{
    public class UnityBootstrap
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IFlyable, Airplane>();
            container.RegisterType<AerialVehicle, Airplane>();
            container.RegisterType<IEngine, Engine>();

            container.RegisterType<Airplane>(new InjectionConstructor(new Engine()));
            container.RegisterType<Helicopter>(new InjectionConstructor(new Engine()));
            container.RegisterType<Drone>(new InjectionConstructor(new Engine()));


        }
    }
}
