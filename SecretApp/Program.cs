using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace SecretAppa
{
    internal class Program
{
    static string[] userNamesList = { "Pelle", "Stina", "Ali" };
    static string[] userPasswordsList = { "1234", "12345", "12346"};

    static void Main(string[] args)
    {
        Console.WriteLine("Välkommen");


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
                else if (choice == 5)
                {
                  DeleteUser();
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
            string[] tempNamesList = new string[userNamesList.Length + 1];
            string[] tempPasswordList = new string[userPasswordsList.Length + 1];

            Console.Write("Skriv namnet på den du vill du lägga till: ");
            string name = Console.ReadLine();
            Console.Write ("Valj ett lösenord: ");
            string password = Console.ReadLine();
            

            int i = 0;
            while (i < userNamesList.Length)
            {
                tempNamesList[i] = userNamesList[i];
                i++;
            }

            tempNamesList[tempNamesList.Length - 1] = name;

            userNamesList = tempNamesList;

            int j = 0;
            while (j < userPasswordsList.Length)
            {
                tempPasswordList[j] = userPasswordsList[j];
                j++;
            }

            tempPasswordList[tempPasswordList.Length - 1] = password;

            userPasswordsList = tempPasswordList;

            foreach(var post  in userNamesList)
            {
                Console.WriteLine(post);
            }
            
            foreach (var post in userPasswordsList)
            {
                Console.WriteLine(post);
            }
            

    }

    static void ShowUsers()
    {
        int i = 0;
        while (i < userNamesList.Length)
        {
            Console.WriteLine(userNamesList[i].ToUpper() + " " .userPasswordsList[i]);
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
            while (i < userNamesList.Length)
            {
                if (userNamesList[i] == name)
                {
                    if (userPasswordsList[i] == password)
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

            if(Array.IndexOf(userNamesList, name) == -1)
            {
                Console.WriteLine("inget sådant användarnamn hittades");
            }
            Menu();

    }


    static void ChangePassword()
    {
        Console.WriteLine("Hello from ChangePassword()");
    }

    static void DeleteUser()
        {
            string[] tempNameList = new string[userNamesList.Length - 1];
            string[] tempPasswordList = new string[userPasswordsList.Length - 1];


            Console.Write("Skriv namnet på den du vill ta bort: ");
            string name = Console.ReadLine();

            int hit = Array.IndexOf(userNamesList, name);

            if (hit == -1)
            {
                Console.WriteLine("namnet finns inte i listan.");
                return;
            }

            int i = 0;
            int j = 0;

            while( i < userNamesList.Length)
            {
                if (hit == i)
                {
                    i++;
                    continue;
                }
               tempNameList[j] = userNamesList[i];
                i++;
                j++;
            }
            userNamesList = tempNameList;

        }
   


        static void Menu()
        {
            Console.WriteLine("" +
                "1. Logga in\r\n" +
                "2. Lägg till användare\r\n" +
                "3. Ändra lösenord\r\n" +
                "4. Vissa användar Lista\r\n" +
                "5. Ta bort namn ur listan\r\n" +
                "9. Visa menyn\r\n" +
                "0. Avsluta\n");

        }

        private static void MethodWithDictionary()
        {
            Dictionary<string, string> userList = new Dictionary<string, string>();

            userList.Add("Pelle", "1234");
            userList.Add("Stina", "12345");
            userList.Add("Ali", "123456");
            userList.Add("Bob", "1234567");
            userList.Add("Melissa", "1234678");

            userList.Remove("Bob");

            foreach (var rad in userList)
            {
                Console.WriteLine(rad.Key + " " + rad.Value);
            }
        }

        static void EndApplication()
    {
        Console.WriteLine("Hello from EndApplication()");
    }
}
}
