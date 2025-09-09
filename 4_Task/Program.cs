namespace _4_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Волгоград", "Киров", "Питер", "Дубай", "АбуДаби", "Краснодар", "Красноярск"};

            var CSWK = list.Where(city => city.StartsWith("К"));
            Console.WriteLine("Города на 'К': " + string.Join(", ", CSWK));

            var SBL = list.OrderBy(city => city.Length);
            Console.WriteLine("Length: " + string.Join(", ", SBL));

            var LC = list.Where(city => city.Length > 6);
            Console.WriteLine("> 6: " + string.Join(", ", LC));
        }
    }
}
