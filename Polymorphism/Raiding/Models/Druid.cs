using Raiding.Global;

namespace Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name) : base(name)
        { }

        public override int Power => GlobalConstants.RogueAndDruidPower;
        
        public override string CastAbility()
        {
            return string.Format(GlobalConstants.StringOverrideDruidPaladin, GetType().Name, Name, Power);
        }
    }
}
