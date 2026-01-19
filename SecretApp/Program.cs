namespace SecretApp
{
    internal class Program
{
    static string[] userNames = { "Pelle", "Stina", "Ali" };
    static string[] userPasswords = { "1234", "12345", "12346" };

        static void Main(string[] args)
        {
            Console.WriteLine("Hej");
            Thread.Sleep(3000);
            bool runProgram = true;
            while (runProgram)
            {
                Console.WriteLine("Välj 0 eller 1");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("Du valde 1");
                    }
                    else if (choice == 0)
                    {
                        runProgram = false;
                    }
                }
                else
                {
                    Console.WriteLine("Välj i menyn");
                    {
                        Console.WriteLine("Hej då");
                        Thread.Sleep(3000);
                    }
                }
            }
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
            i++;
        }
    }

    static void LoggIn()
    {
        Console.WriteLine("Helo from LoggIn");
    }


    static void ChangePassword()
    {
        Console.WriteLine("Hello from ChangePassword()");
    }

    static void EndApplication()
    {
        Console.WriteLine("Hello from EndApplication()");
    }
}
}
