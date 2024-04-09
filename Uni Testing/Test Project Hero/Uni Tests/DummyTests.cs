using System;
using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void TestDeadDummy()// testIsDead
    {
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(1, 10);

        axe.Attack(dummy);

        Assert.AreEqual(dummy.IsDead(),true);
    }
    [Test]
    public void TestLostHeathCorectly()//dummy lost heath
    {
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(10, 10);

        axe.Attack(dummy);

        Assert.AreEqual(dummy.Health,0);
    }

    [Test]
    public void TestDeadDummyCanGiveXP()
    {
        Hero hero = new Hero("Radi");
        Dummy dummy = new Dummy(10,10);

        hero.Attack(dummy);

        Assert.AreEqual(hero.Experience,10);
    }
    [Test]
    public void TestNotDeadDummyNotGiveXP()
    {
        Hero hero = new Hero("Radi");
        Dummy dummy = new Dummy(20, 10);

        hero.Attack(dummy);

        Assert.AreEqual(hero.Experience,0);
    }
}
