using Raiding.Global;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) : base(name)
        { }

        public override int Power => GlobalConstants.RogueAndDruidPower;

        public override string CastAbility()
        {
            return string.Format(GlobalConstants.StringOverrideRodueWarrior, GetType().Name, Name, Power);
        }
    }
}