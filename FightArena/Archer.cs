namespace FightArena
{
    internal class Archer : IUnit
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public Archer(string name)
        {
            Name = name;
            Health = 100;
        }

        public void Attack(IUnit target)
        {
            Console.WriteLine($"{Name} стреляет в {target.Name}");
        }
    }
}
