namespace Zorin_Roman_ISP_232_Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var monster = new
            {
                Name = "dragon",
                Damage = 50,
                IsBoss = true,
                Description = "Древний огнедышаший змей"
            };

            Console.WriteLine(monster.Description);
        }
    }
}
