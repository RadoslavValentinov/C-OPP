using System;
using NUnit.Framework;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        [Test]
        public void TestClassSmartPhoneSetValueCorectly()
        {
            Smartphone phone = new Smartphone("Nokia",100);

            Assert.AreEqual(phone.ModelName,"Nokia");
            Assert.AreEqual(phone.MaximumBatteryCharge,100);
            Assert.AreEqual(phone.CurrentBateryCharge,100);
        }

        [Test]
        public void TestClassShopConstructor()
        {
            Shop shop = new Shop(10);

            Assert.AreEqual(shop.Capacity,10);
            Assert.AreEqual(shop.Count,0);
        }

        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(-11)]
        public void TestPropertyCapasityThrowException(int capasity)
        {
            Assert.Throws<ArgumentException>(() => new Shop(capasity), "Invalid capacity.");
        }

        [Test]
        public void TestMethodAddPhoneSetInCollectionCorectly()
        {
            Shop shop = new Shop(10);
            Smartphone phone = new Smartphone("Nokia", 100);
            shop.Add(phone);

            Assert.AreEqual(1,shop.Count);
        }

        [Test]
        public void TestMethodAddPhoneThrowException()
        {
            Shop shop = new Shop(10);
            Smartphone phone = new Smartphone("Nokia", 100);
            shop.Add(phone);

            Assert.Throws<InvalidOperationException>(()=>shop.Add(phone), $"The phone model {phone.ModelName} already exist.");
        }

        [Test]
        public void TestMethodAddPhoneThrowExceptionOfCapasity()
        {
            Shop shop = new Shop(1);
            Smartphone phone = new Smartphone("Nokia", 100);
            Smartphone phone2 = new Smartphone("LG", 100);
            shop.Add(phone);

            Assert.Throws<InvalidOperationException>(() => shop.Add(phone2), "The shop is full.");
        }

        [Test]
        public void TestMethodRemovePhoneThrowException()
        {
            Shop shop = new Shop(3);
            Smartphone phone = new Smartphone("Nokia", 100);
            Smartphone phone2 = new Smartphone("LG", 100);
            shop.Add(phone);
            shop.Add(phone2);
            string name = "Huawei";

            Assert.Throws<InvalidOperationException>(() =>shop.Remove(name) , $"The phone model {name} doesn't exist.");
        }

        [Test]
        public void TestMethodRemovePhoneOfCollection()
        {
            Shop shop = new Shop(3);
            Smartphone phone = new Smartphone("Nokia", 100);
            Smartphone phone2 = new Smartphone("LG", 100);
            shop.Add(phone);
            shop.Add(phone2);
            Assert.AreEqual(2,shop.Count);
            shop.Remove("LG");
            Assert.AreEqual(1,shop.Count);
        }
        [Test]
        public void TestMethodTestPhoneThrowExceptionThePhoneNotFoundInCollection()
        {
            Shop shop = new Shop(3);

            Assert.Throws<InvalidOperationException>(() => shop.TestPhone("Nokia", 20)
                , $"The phone model {"Nokia"} doesn't exist.");
        }

        [Test]
        public void TestMethodTestPhoneThrowExceptionBatteryIsLowOfUsage()
        {
            Shop shop = new Shop(3);
            Smartphone phone = new Smartphone("Nokia", 20);
            shop.Add(phone);

            Assert.Throws<InvalidOperationException>(() => shop.TestPhone("Nokia", 30)
               , $"The phone model {phone.ModelName} is low on batery.");
        }

        [Test]
        public void TestMethodTestPhoneCorectlyDecreaseBattery()
        {
            Shop shop = new Shop(3);
            Smartphone phone = new Smartphone("Nokia", 100);
            shop.Add(phone);
            shop.TestPhone("Nokia",20);

            Assert.AreEqual(phone.CurrentBateryCharge,80);
        }

        [Test]
        public void TestMethodChargePhoneIsNull()
        {
            Shop shop = new Shop(3);

            Assert.Throws<InvalidOperationException>(() => shop.ChargePhone("Nokia"), $"The phone model {"Nokia"} doesn't exist.");
        }
        [Test]
        public void TestMethodChargePhoneCorectlyWork()
        {
            Shop shop = new Shop(3);
            Smartphone phone = new Smartphone("Nokia", 100);
            shop.Add(phone);
            shop.TestPhone("Nokia",50);

            Assert.AreEqual(phone.CurrentBateryCharge,50);
            shop.ChargePhone("Nokia");
            Assert.AreEqual(phone.CurrentBateryCharge,100);
        }
    }
}