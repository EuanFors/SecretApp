namespace SecretApp
{
    internal class Program
{
    static string[] userNames = { "Pelle", "Stina", "Ali" };
    static string[] userPasswords = { "1234", "12345", "12346" };

    static void Main(string[] args)
    {
        Console.WriteLine("Hej");

        Menu();

        bool runRrogram = true;
        while (runRrogram)
        {
            

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 1)
                {
                    LoggIn();
                }
                else if (choice == 2)
                {
                    AddUser();
                }
                else if (choice == 3)
                {
                    ChangePassword();
                }
                else if (choice == 4)
                {
                    ShowUsers();
                }

                else if (choice == 9)
                {
                    Menu();
                }
                    else if (choice == 0)
                {
                    runRrogram = false;
                }
            }

            else
            {
                Console.WriteLine("Välj i menyn");
            }
        }
        Console.WriteLine("Hej då");
        Thread.Sleep(3000);
    }

    static void AddUser()
    {
        Console.WriteLine("Hello from AddUser()");
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
        Console.WriteLine("Inloggning");
        Console.WriteLine("Namn: ");
        string name = Console.ReadLine();
        Console.Write("lösenord: ");
        String password = Console.ReadLine();

            int i = 0;
            while (i < userNames.Length)
            {
                if (userNames[i] == name)
                {
                    if (userPasswords[i] == password)
                    {
                        Console.WriteLine("Välkommen " + name);
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Felaktigt lösenord");
                    }
                }
                i++;
            }

            if(Array.IndexOf(userNames, name) == -1)
            {
                Console.WriteLine("inget sådant användarnamn hittades");
            }
            Menu();

    }


    static void ChangePassword()
    {
        Console.WriteLine("Hello from ChangePassword()");
    }

    static void Menu()
        {
            Console.WriteLine("" +
                "1. Logga in\r\n" +
                "2. Lägg till användare\r\n" +
                "3. Ändra lösenord\r\n" +
                "4. Vissa användar Lista\r\n" +
                "9. Visa menyn\r\n" +
                "0. Avsluta\n");

        }

        static void EndApplication()
    {
        Console.WriteLine("Hello from EndApplication()");
    }
}
}
