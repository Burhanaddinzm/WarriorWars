using WarriorWars.Enum;

namespace WarriorWars.Models.Equipment
{
    class Armor
    {
        private const int GOOD_GUY_ARMOR = 5;
        private const int BAD_GUY_ARMOR = 5;

        private int _armorPoints;
        //Only get property.
        public int ArmorPoints
        {
            get
            {
                return _armorPoints;
            }
        }
        //Armor class's constructor, assings the armorPoints to the respective Factions
        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    _armorPoints = GOOD_GUY_ARMOR;
                    break;
                case Faction.BadGuy:
                    _armorPoints = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}