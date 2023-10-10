using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPFlyingVehicle;
using OOPFlyingVehicleCore;
using Unity;

namespace UnitTestFlyingVehicle
{
    [TestClass]
    public class InjectTests
    {
        IUnityContainer unityContainer;
        public InjectTests() 
        {

            unityContainer = new UnityContainer();
            UnityBootstrap.RegisterTypes(unityContainer);

        }

        [TestMethod]
        public void UnityEngineAirplane()
        {
            //Arrange
            IFlyable A;
            //Act
            A = unityContainer.Resolve<Airplane>();
            //Assert
            Assert.IsInstanceOfType(A.Engine, typeof(Engine));
        }

        [TestMethod]
        public void UnityEngineHelicopter()
        {
            //Arrange
            IFlyable H;
            //Act
            H = unityContainer.Resolve<Helicopter>();
            //Assert
            Assert.IsInstanceOfType(H.Engine, typeof(Engine));
        }

        public void UnityEngineDrone()
        {
            //Arrange
            IFlyable D;
            //Act
            D = unityContainer.Resolve<Drone>();
            //Assert
            Assert.IsInstanceOfType(D.Engine, typeof(Engine));
        }

        [TestMethod]
        public void TestDefaultEngineAirplane()
        {
            //Arrange
            IFlyable A;
            //Act
            A = new Airplane(new Engine());
            //Assert
            Assert.IsInstanceOfType(A.Engine, typeof(Engine));
        }

        [TestMethod]
        public void TestDefaultEngineHelicopter()
        {
            //Arrange
            IFlyable H;
            //Act
            H = new Helicopter(new Engine());
            //Assert
            Assert.IsInstanceOfType(H.Engine, typeof(Engine));
        }
    }
}