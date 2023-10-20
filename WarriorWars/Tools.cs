namespace WarriorWars
{
    //static Tools class that makes it easier to write info about the winner and the loser. 
    static class Tools
    {
        public static void ColorFullWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
