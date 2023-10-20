using WarriorWars.Enum;
using WarriorWars.Models;
class Program
{
    //Creates new object off of Random class.
    static Random rng = new Random();
    static void Main()
    {
        //Creating objects form Warrior class.
        Warrior goodGuy = new Warrior("Bob", Faction.GoodGuy);
        Warrior badGuy = new Warrior("Joe", Faction.BadGuy);
        //If both objects are "alive" continues the attack on the chosen enemy based off of rng.
        while (goodGuy.IsAlive && badGuy.IsAlive)
        {
            if (rng.Next(0, 10) < 5)
            {
                goodGuy.Attack(badGuy);
            }
            else
            {
                badGuy.Attack(goodGuy);
            }
            Thread.Sleep(100);
        }

    }
}