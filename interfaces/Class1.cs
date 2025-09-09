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
}
