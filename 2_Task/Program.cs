namespace _2_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            List<int> evenD = digits.FindAll(n => n % 2 == 0);

            List<int> res = digits.FindAll(n => n % 3 == 0);

            Console.WriteLine("Чётные числа: " + string.Join(", ", evenD));
            Console.WriteLine();

            Console.WriteLine("Числа, кратные 3: " + string.Join(", ", res));
        }
    }
}
