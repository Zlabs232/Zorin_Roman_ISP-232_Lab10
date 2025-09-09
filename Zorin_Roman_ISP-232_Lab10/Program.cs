namespace Zorin_Roman_ISP_232_Lab10
{
    internal class Program
    {
        delegate void MessageHandler(string message);
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

            var products = new[]
            {
            new {Name = "Молоко", Price = 59.99, Category = "Продукты"},
            new {Name = "Ноутбук", Price = 59.99, Category = "Электроника"},
            new {Name = "Щётка для зубов", Price = 59.99, Category = "Гигиена"},
            };

            foreach(var product in products)
            {
                Console.WriteLine($"{product.Name} ({product.Category}) - {product.Price} Руб.");
            }

            MessageHandler handler = delegate (string message)
            {
                Console.WriteLine($"{message}");
            };
            handler("Hello,World!");

            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            Button button = new Button();
            button.OnClick += () => Console.WriteLine("Кнопка нажата!");
            button.Click();

        }
    }
    public class Button
    {
        public event Action OnClick;
        public void Click()
        {
            OnClick?.Invoke();
        }
    }
}
