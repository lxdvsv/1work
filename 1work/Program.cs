namespace work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваши данные:");

            Console.Write("Введите ваше ФИО: ");
            string fullName = Console.ReadLine().Trim();

            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine().Trim());

            Console.Write("Введите ваш рост: ");
            double height = double.Parse(Console.ReadLine().Trim().Replace(',', '.'));

            Console.Write("Введите вашу улицу: ");
            string street = Console.ReadLine().Trim();

            Console.Write("Введите номер дома: ");
            int houseNumber = int.Parse(Console.ReadLine().Trim());

            Console.Write("Введите ваш телефон : ");
            string phone = Console.ReadLine().Trim();

            Console.Write("Введите ваш e-mail: ");
            string email = Console.ReadLine().Trim();

            Console.Write("Введите ваше образование: ");
            string education = Console.ReadLine().Trim();

            Console.Write("Введите ваши хобби: ");
            string hobbies = Console.ReadLine().Trim();

            Console.WriteLine("\nПолученные данные:");
            Console.WriteLine("ФИО: " + fullName);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Рост: " + height);
            Console.WriteLine("Улица: " + street);
            Console.WriteLine("Номер дома: " + houseNumber);
            Console.WriteLine("Телефон: " + phone);
            Console.WriteLine("E-mail: " + email);
            Console.WriteLine("Образование: " + education);
            Console.WriteLine("Хобби: " + hobbies);
            Console.WriteLine("Истинный самурай не ищет победы над врагом, он стремится к победе над собой.");
        }
    }
}