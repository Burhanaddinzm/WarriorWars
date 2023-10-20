using WarriorWars.Enum;
using WarriorWars.Models.Equipment;

namespace WarriorWars.Models
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 20;
        private const int BAD_GUY_STARTING_HEALTH = 20;

        private readonly Faction FACTION;

        private int _health;
        private string _name;
        private bool _isAlive;

        private Weapon _weapon;
        private Armor _armor;
        //Only get property meaning can't set a vaule outside this class's constructor.
        public bool IsAlive
        {
            get
            {
                return _isAlive;
            }
        }
        //Constructor takes the name and faction of the warrior and assigns their weapon, armor and health.
        public Warrior(string name, Faction faction)
        {
            this._name = name;
            this.FACTION = faction;
            _isAlive = true;
            switch (faction)
            {
                case Faction.GoodGuy:
                    _weapon = new Weapon(faction);
                    _armor = new Armor(faction);
                    _health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    _weapon = new Weapon(faction);
                    _armor = new Armor(faction);
                    _health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }
        //Assigns weapon damage to the set value, substracts damage/enemy_armor from enemy_health.
        public void Attack(Warrior enemy)
        {
            int damage = _weapon.Damage / enemy._armor.ArmorPoints;

            enemy._health -= damage;
            //Checks if enemy health drops below 0 and sets enemy's isAlive value to false.Uses Tools class to write and change
            //color of the written text.
            if (enemy._health < 0)
            {
                enemy._isAlive = false;
                Tools.ColorFullWriteLine($"{enemy._name} is dead!",ConsoleColor.Red);
                Tools.ColorFullWriteLine($"{_name} is victorious!", ConsoleColor.Green);
            }
            //If enemy is still alive after the attack displays the stats of the enemy.
            else
            {
                Console.WriteLine($"{_name} attacked {enemy._name}.{damage} damage was inflicted to {enemy._name}, remaining health of {enemy._name} is {enemy._health}");

            }
        }
    }
}
