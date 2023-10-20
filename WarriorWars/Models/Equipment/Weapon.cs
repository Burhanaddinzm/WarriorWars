using WarriorWars.Enum;

namespace WarriorWars.Models.Equipment
{
    class Weapon
    {
        private const int GOOD_GUY_DAMAGE = 5;
        private const int BAD_GUY_DAMAGE = 5;

        private int _damage;
        //Only get property.
        public int Damage
        {
            get
            {
                return _damage;
            }

        }
        //Weapon class's constructor, assings the damage to the respective Factions.
        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    _damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.BadGuy:
                    _damage = BAD_GUY_DAMAGE;
                    break;
                default:
                    break;
            }
        }
    }
}
