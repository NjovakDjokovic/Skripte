using EloBuddy.SDK;

namespace Katarina.Modes
{
    public abstract class ModeBase
    {
        // Change the spell type to whatever type you used in the SpellManager
        // here to have full features of that spells, if you don't need that,
        // just change it to Spell.SpellBase, this way it's dynamic with still
        // the most needed functions
        protected Spell.SpellBase Q
        {
            get { return SpellManager.Q; }
        }
        protected Spell.SpellBase W
        {
            get { return SpellManager.W; }
        }
        protected Spell.SpellBase E
        {
            get { return SpellManager.E; }
        }
        protected Spell.SpellBase R
        {
            get { return SpellManager.R; }
        }

        public abstract bool ShouldBeExecuted();

        public abstract void Execute();
    }
}
