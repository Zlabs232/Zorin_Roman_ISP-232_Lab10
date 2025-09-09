namespace interfaces
{
    public interface ISoungMaker
    {
        void MakeSound();

    }
    public class Cat : ISoungMaker
    {
        public void MakeSound()
        {
            Console.WriteLine("МяУ!");
        }
    }
    public class Phone : ISoungMaker
    {
        public void MakeSound()
        {
            Console.WriteLine("Дзынь-дзынь!");
        }
    }

    public interface INamed
    {
        string Name { get; set; }
    }

    public class Book : INamed
    {
        public string Name { get; set; }
    }

    public interface IFlier
    {
        void Fly();
    }
    public interface ISwimmer
    {
        void Swim();
    }

    public class Duck : IFlier, ISwimmer
    {
        public void Fly() => Console.WriteLine("Я летаю");
        public void Swim() => Console.WriteLine("Я плыву");
    }
}
