namespace FightArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arena arena = new Arena();
            arena.AddUnit(new Warrior("Рагнар"));
            arena.AddUnit(new Archer("Гендальф"));
            arena.AddUnit(new Mage("Водолаз"));
            arena.StartBattle();

        }
    }
}
