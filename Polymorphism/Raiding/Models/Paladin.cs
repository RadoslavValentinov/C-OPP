using Raiding.Global;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name) : base(name)
        { }

        public override int Power => GlobalConstants.PaladinAndWarriorPower;

        public override string CastAbility()
        {
            return string.Format(GlobalConstants.StringOverrideDruidPaladin, GetType().Name, Name, Power);
        }
    }
}
