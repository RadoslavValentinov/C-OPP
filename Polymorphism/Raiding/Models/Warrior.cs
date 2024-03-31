using Raiding.Global;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        { }

        public override int Power => GlobalConstants.PaladinAndWarriorPower;

        public override string CastAbility()
        {
            return string.Format(GlobalConstants.StringOverrideRodueWarrior, GetType().Name, Name, Power);
        }
    }
}
