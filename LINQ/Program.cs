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

            //2 Пример
            List<string> names = new List<string> { "Анна", "Иван", "Мария", "Пётр" };
            List<string> longNames = new List<string>();
            foreach(var name in names)
            {
                if(name.Length > 4)
                    longNames.Add(name);
            }
            foreach(var name in longNames)
            {
                Console.WriteLine(name);
            }

            var linqLongNames = names.Where(name => name.Length > 4);

            foreach(var name in linqLongNames)
            {
                Console.WriteLine(name);
            }

            //3 Пример
            List<int> nums = new List<int> { 10, 5, 20, 3 };

            int min = nums[0];
            foreach(var num in nums)
            {
                if (num < min)
                    min = num;
            }

            Console.WriteLine($"\nМинимимальное число (Без LINQ): {min}");

            int linqMin = nums.Min();
            Console.WriteLine($"\nМинимимальное число (C LINQ): {min}");


            //4 Пример

            List<int> numbers2 = new List<int> { 1, 2, 3, 4 };

            List<int> squares = new List<int>();
            foreach (var num in numbers2)
            {
                squares.Add(num * num);
            }

            Console.WriteLine("Квадраты чисел (без LINQ):");
            Console.WriteLine(string.Join(", ", squares));

            var linqSquares = numbers2.Select(n => n * n);
            Console.WriteLine("Квадраты чисел (C LINQ):");
            Console.WriteLine(string.Join(", ", linqSquares));

            //5 Пример

            List<Student> students = new()
        {
            new Student { Name = "Андрей", Score = 90 },
            new Student { Name = "Вика", Score = 78 },
            new Student { Name = "Денис", Score = 84 },
            new Student { Name = "Лена", Score = 95 },
            new Student { Name = "Олег", Score = 65 }
        };

            List<Student> goodStudents = new List<Student>();
            int total = 0;

            foreach(var s in students)
            {
                total += s.Score;
                if(s.Score > 80)
                    goodStudents.Add(s);
            }

            goodStudents.Sort((a, b) => a.Name.CompareTo(b.Name));
            Console.WriteLine("Студенты с баллом выше 80: ");
            foreach(var s in goodStudents)
            {
                Console.WriteLine($"{s.Name} - {s.Score}");
            }
            Console.WriteLine($"Средний балл: {(double)total / students.Count:F1}");

            var linqGoodStudents = students
                .Where(s => s.Score > 80)
                .OrderBy(s => s.Name);

            var avg = students.Average(s => s.Score);

            Console.WriteLine("Студенты с баллом > 80: ");
            foreach(var s in linqGoodStudents)
                Console.WriteLine($"{s.Name} - {s.Score}");

            Console.WriteLine($"Средний балл: {avg:F1}");
            

        }
    }
    class Student
    {
        public string Name;
        public int Score;
    }
}
