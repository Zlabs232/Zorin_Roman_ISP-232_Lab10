namespace _3_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPrintable> printables = new List<IPrintable>
            {
                new Book(),
                new Magazine(),
                new Book(),
                new Magazine(),
                new Book()
            };

            foreach (var printable in printables)
            {
                printable.PrintInfo();
            }

        }
    }

    public class Book : IPrintable
    {
        private static Random random = new Random();

        public void PrintInfo()
        {
            Console.WriteLine($"Книге: {random.Next(15, 195)} лет.");
        }
    }

    public class Magazine : IPrintable
    {
        private static Random random = new Random();

        public void PrintInfo()
        {
            Console.WriteLine($"Журналу: {random.Next(1, 30)} лет.");
        }
    }
}
