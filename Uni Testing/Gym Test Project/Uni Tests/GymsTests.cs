using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Gyms.Tests
{
    public class GymsTests
    {
        [Test]
        public void TestAllPropertySetValueCorectly()
        {
            Gym gym = new Gym("Radi", 12);

            Assert.AreEqual(gym.Name, "Radi");
            Assert.AreEqual(gym.Capacity, 12);
        }

        [TestCase(null)]
        [TestCase("")]
        public void TestPropertyNameShouldException(string name)
        {
            Assert.Throws<ArgumentNullException>(() => new Gym(name, 2), $"{name} Invalid gym name.");
        }

        [TestCase("Radi", -1)]
        [TestCase("Radi", -15)]
        [TestCase("Radi", -100)]
        public void TestAllPropertyCapasityShouldThrowException(string name, int cap)
        {
            Assert.Throws<ArgumentException>(() => new Gym(name, cap), "Invalid gym capacity.");
        }

        [Test]
        public void TestCountPropertySetValue()
        {
            Athlete athlete = new Athlete("Radko");
            Gym gym = new Gym("Radi", 12);

            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete);

            Assert.AreEqual(3, gym.Count);
        }

        [Test]
        public void TestMethodAddAthleteThrowException()
        {
            Athlete athlete = new Athlete("Radko");
            Gym gym = new Gym("Radi", 1);

            gym.AddAthlete(athlete);

            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(athlete), "The gym is full.");
        }

        [Test]
        public void TestMethodRemoveAthleteThrowException()
        {
            Gym gym = new Gym("Radi", 6);

            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete("Gosho"),
                $"The athlete {"Gosho"} doesn't exist.");
        }

        [Test]
        public void TestMethodRemoveAthleteworkCorectly()
        {
            Athlete athlete = new Athlete("Gosho");
            Athlete athlete2 = new Athlete("Radi");
            Gym gym = new Gym("Radi", 6);

            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete2);
            Assert.AreEqual(gym.Count,2);

            gym.RemoveAthlete("Gosho");

            Assert.AreEqual(gym.Count,1);
        }

        [Test]
        public void TestMetthodReport()
        {
            Athlete athlete = new Athlete("Gosho");
            Athlete athlete2 = new Athlete("Radi");
            Gym gym = new Gym("Radi", 6);

            gym.AddAthlete(athlete);
            string rep = gym.Report();
            Assert.AreEqual(rep, $"Active athletes at {"Radi"}: {"Gosho"}");
        }

        [Test]
        public void TestMethodInjureAthleteThrowException()
        {
            Gym gym = new Gym("Radi", 12);
            Assert.Throws<InvalidOperationException>(() => gym.InjureAthlete("Gosho"), $"The athlete {"Gosho"} doesn't exist.");
        }

        [Test]
        public void TestMethodInjureAthleteSetAthleteTrue()
        {
            Athlete athlete = new Athlete("Radi");
            Athlete athlete2 = new Athlete("Gosho");
            Gym gym = new Gym("Radi", 12);
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete2);
            gym.InjureAthlete("Gosho");
            string vas = gym.Report();
            Assert.AreEqual(vas, $"Active athletes at {"Radi"}: {"Radi"}");
        }
        [Test]
        public void TestMethodInjureAthleteSetAthleteTrueCuretAthlet()
        {
            Athlete athlete = new Athlete("Radi");
            Athlete athlete2 = new Athlete("Gosho");
            Gym gym = new Gym("Radi", 12);
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete2);
            gym.InjureAthlete("Gosho");
            string vas = gym.Report();
            Assert.AreEqual(vas, $"Active athletes at {"Radi"}: {"Radi"}");
            Assert.AreEqual(athlete2.IsInjured,true);
        }

        [Test]
        public void TestAthlet()
        {
            Athlete athlete = new Athlete("Radi");

            Assert.AreEqual(athlete.FullName,"Radi");
            Assert.AreEqual(athlete.IsInjured,false);
        }

        [Test]
        public void TestMethodInjureAthleteSetAthleteTrueCurent()
        {
            Athlete athlete = new Athlete("Radi");
            Athlete athlete2 = new Athlete("Gosho");
            Gym gym = new Gym("Radi", 12);
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete2);
            gym.InjureAthlete("Gosho");

            Assert.AreEqual(athlete2.IsInjured, true);
            Assert.AreEqual(athlete.IsInjured, false);
        }
    }
}
