using System;
using NUnit.Framework;
[TestFixture]
public class HeroRepositoryTests
{
    [Test]
    public void TestIcollectionInicilisation()
    {
        HeroRepository hero = new HeroRepository();

        Assert.NotNull(hero.Heroes);
    }

    [Test]
    public void TestMethodCreateRhrowexceptionHeroIsNull()
    {
        HeroRepository heroes = new HeroRepository();
        Hero hero = null;

        Assert.Throws<ArgumentNullException>(() => heroes.Create(hero), "Hero is null");
    }

    [Test]
    public void TestmethodcreateIfHeroExist()
    {
        Hero hero = new Hero("Radi",2);
        HeroRepository repo = new HeroRepository();

        repo.Create(hero);
        Assert.Throws<InvalidOperationException>(() => repo.Create(hero), $"Hero with name {hero.Name} already exists");
    }

    [Test]
    public void TestMethodCreateAddHeroCorectly()
    {
        Hero hero = new Hero("radi",12);
        HeroRepository heroes = new HeroRepository();

        var curent = heroes.Create(hero);

        Assert.AreEqual($"Successfully added hero {hero.Name} with level {hero.Level}",curent);
    }
    [TestCase(null,12)]
    [TestCase("",12)]
    public void TestMethodRemovehrowException(string name,int level)
    {
        Hero hero = new Hero(name,level);
        HeroRepository heroes = new HeroRepository();

        Assert.Throws<ArgumentNullException>(() => heroes.Remove(hero.Name), "Name cannot be null");
    }
  
    [Test]
    public void TestMethodReturnTruetoRemove()
    {
        Hero hero = new Hero("Radi", 12);
        HeroRepository heroes = new HeroRepository();
        heroes.Create(hero);

        Assert.AreEqual(heroes.Remove("Radi"),true);
    }

    [Test]
    public void TestMethodGetHeroWithHighestLevelReturCorectly()
    {
        Hero hero = new Hero("Radi", 12);
        Hero hero2 = new Hero("Gosho", 13);
        Hero hero3 = new Hero("Ico", 20);
        HeroRepository heroes = new HeroRepository();
        heroes.Create(hero);
        heroes.Create(hero2);
        heroes.Create(hero3);

        var result = heroes.GetHeroWithHighestLevel();

        Assert.AreEqual(result.Name,"Ico");
        Assert.AreEqual(result.Level,20);
    }

    [Test]
    public void TestmethodgetHero()
    {
        Hero hero = new Hero("Radi", 12);
        Hero hero2 = new Hero("Gosho", 13);
        Hero hero3 = new Hero("Ico", 20);
        HeroRepository heroes = new HeroRepository();
        heroes.Create(hero);
        heroes.Create(hero2);
        heroes.Create(hero3);
        var getHero = heroes.GetHero("Ico");

        Assert.AreEqual(getHero.Name,"Ico");
        Assert.AreEqual(getHero.Level,20);
    }
}