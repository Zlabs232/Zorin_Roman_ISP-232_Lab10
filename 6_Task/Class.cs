namespace _6_Task
{
    public class Teacher : IPerson
    {
        public string Name {get;set;}
        public string department {get;set;}

        public void GetDescription()
        {
            Console.WriteLine($"Преподаватель: {Name}. Кафедра: {department}.");
        }
    }
    public class Student : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetDescription()
        {
            Console.WriteLine($"Студент: {Name}. Возраст студента: {Age}.");
        }
    }
}
