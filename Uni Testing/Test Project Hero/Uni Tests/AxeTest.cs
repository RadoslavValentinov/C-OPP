using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTest
    {
        [Test]
        public void TestAxeAttackDurability()
        {
            Axe axe = new Axe(10,10);
            Dummy dummy = new Dummy(10,10);

            axe.Attack(dummy);

            Assert.AreEqual(axe.DurabilityPoints,9);
        }

    }
}
