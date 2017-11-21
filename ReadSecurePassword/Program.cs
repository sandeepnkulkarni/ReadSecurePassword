using System;
using System.Text;

namespace ReadSecurePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            string password = GetUserPassword();

            Console.WriteLine("You entered following: ");
            Console.WriteLine("Username: {0}", username);
            Console.WriteLine("Password: {0}", password);
        }

        private static string GetUserPassword()
        {
            StringBuilder password = new StringBuilder();
            Console.Write("Enter your password: ");

            ConsoleKeyInfo nextKey = Console.ReadKey(true);
            while (nextKey.Key != ConsoleKey.Enter)
            {
                if (nextKey.Key == ConsoleKey.Backspace)
                {
                    if (password.Length > 0)
                    {
                        password.Remove(password.Length - 1, 1);
                        // Erase the last * as well
                        Console.Write(nextKey.KeyChar);
                        Console.Write(" ");
                        Console.Write(nextKey.KeyChar);
                    }
                }
                else
                {
                    password.Append(nextKey.KeyChar);
                    Console.Write("*");
                }
                nextKey = Console.ReadKey(true);
            }
            Console.WriteLine();

            return password.ToString();
        }
    }
}
