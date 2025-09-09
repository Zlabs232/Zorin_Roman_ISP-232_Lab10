using System.Linq;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5,2,9,4,7,3,8,23,45,12,34,98,67,56,99};
            List<int> evenNumbers = new List<int>();
            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                    evenNumbers.Add(num);
            }
            List<int> multiplied = new List<int>();
            foreach(var num in evenNumbers)
            {
                multiplied.Add(num * 10);
            }

            multiplied.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine("Результат(Без LINQ): ");
            foreach(var num in multiplied)
            {
                Console.WriteLine(num);
            }

            var result = numbers
            .Where(n => n % 2 == 0)
            .Select(n => n * 10)
            .OrderByDescending(n => n);

            Console.WriteLine("Результат (С LINQ)");
            foreach (var numb in result)
                Console.WriteLine(numb);
        }
    }
}
