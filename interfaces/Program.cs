using System.Security.Cryptography.X509Certificates;

namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISoungMaker> soundMakers = new List<ISoungMaker>();
            foreach (var item in soundMakers)
            {
                item.MakeSound();
            }

            Book book = new Book{Name = "Война и мир"};
            Console.WriteLine(book.Name);


        }
    }
}
