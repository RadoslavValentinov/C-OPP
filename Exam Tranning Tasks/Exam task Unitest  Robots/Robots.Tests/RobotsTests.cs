using NUnit.Framework;

namespace Robots.Tests
{
    using System;

    public class RobotsTests
    {

        [Test]
        public void CapasityShouldSetValue()
        {
            RobotManager robots = new RobotManager(12);
            Assert.AreEqual(12, robots.Capacity);
        }

        [Test]
        public void CapasityShouldthrowExeptionMessage()
        {
            Assert.That(() => new RobotManager(-12), Throws.ArgumentException, "Invalid capacity!");
        }

        [Test]
        public void TestCountShouldSetCorectlySetCount()
        {
            Robot robo = new Robot("Radi", 90);
            Robot robo2 = new Robot("Paco", 90);
            Robot robo3 = new Robot("Kiro", 90);
            RobotManager robot = new RobotManager(90);

            robot.Add(robo);
            robot.Add(robo2);
            robot.Add(robo3);

            Assert.AreEqual(3, robot.Count);
        }

        [Test]
        public void AddMethodNameTheUnique()
        {
            Robot robo1 = new Robot("Radi", 90);
            RobotManager robo = new RobotManager(90);
            robo.Add(robo1);

            Assert.That(() => robo.Add(robo1), Throws.InvalidOperationException);

        }

        [Test]
        public void AddMethodNamecapasytyAreEqualCount()
        {
            Robot robo1 = new Robot("Radi", 90);
            Robot robo2 = new Robot("Paco", 90);
            Robot robo3 = new Robot("Kiro", 90);
            RobotManager robo = new RobotManager(2);
            robo.Add(robo1);
            robo.Add(robo2);

            Assert.That(() => robo.Add(robo3), Throws.InvalidOperationException);
        }

        [Test]
        public void MethodRemoveShouldThrowExeptionNameEqualsNull()
        {
            Robot robo1 = new Robot("Radi", 90);
            Robot robo2 = new Robot("Paco", 90);
            RobotManager robo = new RobotManager(2);
            robo.Add(robo1);
            robo.Add(robo2);
            string name = "Kiro";

            Assert.That(() => robo.Remove(name), Throws.InvalidOperationException);
        }

        [Test]
        public void MethodRemoveShouldRemoveOfList()
        {
            Robot robo1 = new Robot("Radi", 90);
            Robot robo2 = new Robot("Paco", 90);
            RobotManager robo = new RobotManager(2);
            robo.Add(robo1);
            robo.Add(robo2);
            string name = "Paco";

            robo.Remove(name);
            Assert.AreEqual(1, robo.Count);

        }

        [Test]
        public void TestMethodWorkThrowExeptionOfNull()
        {
            Robot robo = new Robot(null, 100);
            RobotManager robot = new RobotManager(1);
            string name = null;

            Assert.That(() => robot.Work(name, "work", 20), Throws.InvalidOperationException);
        }

        [Test]
        public void TestMethodWorkThrowExeptionOfBatteryLowAreEqualsBatUsages()
        {
            Robot robo = new Robot("Radi", 18);
            RobotManager robot = new RobotManager(1);
            robot.Add(robo);
            string name = "Radi";

            Assert.That(() => robot.Work(name, "work", 20), Throws.InvalidOperationException);
        }

        [Test]
        public void TestMethodWorkSetValueOfBateryCorectly()
        {
            Robot robo = new Robot("Radi", 18);
            RobotManager robot = new RobotManager(1);
            robot.Add(robo);
            string name = "Radi";
            string work = "work";

            robot.Work(name, work, 8);
            Assert.AreEqual(10, robo.Battery);
        }

        [Test]
        public void MetodChargeThrowExeptionOfNullValue()
        {
            Robot robot = null;
            RobotManager robo = new RobotManager(2);
            string name = "Radi";

            Assert.That(() => robo.Charge(name), Throws.InvalidOperationException);
        }

        [Test]
        public void MetodChargeBaterryOfRobotForMaximum()
        {
            Robot robot = new Robot("Radi", 80);
            RobotManager robo = new RobotManager(1);
            robo.Add(robot);
            robo.Work("Radi","Work",40);
            robo.Charge("Radi");

            Assert.AreEqual(80,robot.Battery);
        }
    }
}
