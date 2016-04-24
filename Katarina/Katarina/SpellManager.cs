using EloBuddy;
using EloBuddy.SDK;

namespace Katarina
{
    public static class SpellManager
    {
        // You will need to edit the types of spells you have for each champ as they
        // don't have the same type for each champ, for example Xerath Q is chargeable,
        // right now it's  set to Active.
        public static Spell.Targeted Q { get; private set; }
        public static Spell.Active W { get; private set; }
        public static Spell.Targeted E { get; private set; }
        public static Spell.Active R { get; private set; }

        static SpellManager()
        {
            // Initialize spells
            Q = new Spell.Targeted(SpellSlot.Q, /*Spell range*/ 675);
            W = new Spell.Active(SpellSlot.W, /*Spell range*/ 400);
            E = new Spell.Targeted(SpellSlot.E, /*Spell range*/ 700);
            R = new Spell.Active(SpellSlot.R, /*Spell range*/ 550);

            // TODO: Uncomment the other spells to initialize them
            //W = new Spell.Chargeable(SpellSlot.W);
            //E = new Spell.Skillshot(SpellSlot.E);
            //R = new Spell.Targeted(SpellSlot.R);
        }

        public static void Initialize()
        {
            // Let the static initializer do the job, this way we avoid multiple init calls aswell
        }
    }
}
