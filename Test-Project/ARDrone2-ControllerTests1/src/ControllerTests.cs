using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATeam_DroneController.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AR.Drone.Client;

namespace ATeam_DroneController.src.Tests
{
    
    [TestClass()]
    public class ControllerTests
    {
        [TestMethod()]
        public void ControllerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsConnected()
        {
            Assert.IsTrue(ctrl.IsDroneConnected);
        }

        [TestMethod()]
        public void LandTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TakeOffTest()
        {
            Assert.Fail();
        }
    }
}