using System.ComponentModel.Design;
using System.Net.Http.Json;

namespace SecretApp1
{
    internal class Program
    {

        static string[] userNames = { "Pelle", "Stina", "Ali" };
        static string[] userPasswords = { "1234", "abcd", "qwerty" };

        static void Main(string[] args)
        {
        }
        static void AddUser()
        {
            Console.WriteLine("Hello from AddUser");
        }

        static void ChangePassword()
        {
            Console.WriteLine("Hello from ChangePassword");
        }

        static void ShowUsers()
        {
            int i = 0;
            while (i < userNames.Length)
            {
                Console.WriteLine(userNames[i].ToUpper());
            }

        }

        static void EndApplication()
        {
            Console.WriteLine("Hello from EndApplication");
        }
    }
}