using System.Collections.Concurrent;

namespace AlgoPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User( "fafa2","Александр",true),
                new User("sfgijuh33","Виктор",true),
                new User("arsen4ik","Арсен",false),
                new User("dembel1666","Дмитрий",true)
            };
            foreach (User user in users)
            {
                Console.WriteLine($"Привет, {user.Name}");
                if (!user.IsPremium)
                {
                    user.ShowAds();
                }
            }
            Greetings();
            massArray();
            CheckAge();
        }
        static public void Greetings()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            string greetings = $"Привет, {name}";
            Console.WriteLine(greetings);
        }
        static public void massArray()
        {
            Console.WriteLine("Сколько элементов будет в массиве");
            int arrayCount = int.Parse(Console.ReadLine());
            int[] array = new int[arrayCount];
            for (int i = 0; i < arrayCount; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in array)
                Console.WriteLine(i);
        }
        static void CheckAge()
        {
            Console.WriteLine("Введите свой возраст");
            int age = int.Parse(Console.ReadLine());
            if (age > 13)
            {
                Console.WriteLine("Вы успешно зарегистрированы!");
            }
            else
            {
                Console.WriteLine("Пользователи младше 14 лет не могут быть зарегестрированы");
            }
        } 
    }
}
