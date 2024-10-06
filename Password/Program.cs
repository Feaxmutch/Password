namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attemps = 3;
            string password = "123word";
            string message = "Пончик";

            for (int i = attemps ; i > 0; i--)
            {
                Console.Clear();

                Console.WriteLine($"Осталось {i} попыток");
                Console.Write("Введите пароль: ");
                string userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine(message);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine($"Неверный пароль.");
                    Console.ReadKey();
                }
            }
        }
    }
}
