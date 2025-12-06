#nullable disable
using System;

class Program
{
    static ContactBook[] contacts = new ContactBook[100];
    static int count = 0;

    static void Main()
    {
        for (int i = 0; i < 20; i++)
        {
            ContactBook cb = new ContactBook();
            cb.FirstName = "person" + (i + 1);
            cb.LastName = "LastName" + (i + 1);
            cb.Company = "Company" + (i + 1);
            cb.Mobile = (100000000 + i).ToString();
            cb.Email = "person" + (i + 1) + "@gmail.com";
            cb.BirthDate = "1990-01-01";   
            contacts[count] = cb;
            count++;
        }

        while (true)
        {
            Console.WriteLine("\n--- Contact Book Menu ---");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Show All Contacts");
            Console.WriteLine("3. Show Contact Details");
            Console.WriteLine("4. Update Contact");
            Console.WriteLine("5. Delete Contact");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter option:");

            string select = Console.ReadLine();

            switch (select)
            {
                case "0": return;
                case "1": AddContact(); break;
                case "2": ShowAll(); break;
                case "3": ShowOne(); break;
                case "4": UpdateContact(); break;
                case "5": DeleteContact(); break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void AddContact()
    {
        ContactBook cb = new ContactBook();

        Console.Write("First Name: ");
        cb.FirstName = Console.ReadLine();

        Console.Write("Last Name: ");
        cb.LastName = Console.ReadLine();

        Console.Write("Company: ");
        cb.Company = Console.ReadLine();

        string Mob;
        while (true)
        {
            Console.Write("Mobile (9 digits, cannot start with 0): ");
            Mob = Console.ReadLine();

            if (Mob.Length == 9 &&
                Mob[0] != '0' &&
                long.TryParse(Mob, out _))
            {
                break;
            }
            Console.WriteLine("Invalid mobile number.");
        }

        cb.Mobile = Mob;

        Console.Write("Email:");
        cb.Email = Console.ReadLine();

        Console.Write("Birthdate: ");
        cb.BirthDate = Console.ReadLine(); 

        contacts[count] = cb;
        count++;

        Console.WriteLine("Contact Added!");
    }

    static void ShowAll()
    {
        Console.WriteLine("\n--- All Contacts ---");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(contacts[i].FirstName + " " +
                              contacts[i].LastName + " - " +
                              contacts[i].Mobile);
        }
    }

    static void ShowOne()
    {
        Console.Write("Enter Mobile Number: ");
        string mob = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].Mobile == mob)
            {
                contacts[i].Show("Contact Details"); 
                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }

    static void UpdateContact()
    {
        Console.Write("Enter Mobile Number to Update: ");
        string mob = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].Mobile == mob)
            {
                Console.Write("New First Name (Enter to skip): ");
                string fn = Console.ReadLine();
                if (fn != "") contacts[i].FirstName = fn;

                Console.Write("New Last Name (Enter to skip): ");
                string ln = Console.ReadLine();
                if (ln != "") contacts[i].LastName = ln;

                Console.Write("New Company (Enter to skip): ");
                string comp = Console.ReadLine();
                if (comp != "") contacts[i].Company = comp;

                Console.Write("New Email (Enter to skip): ");
                string Email = Console.ReadLine();
                if (Email != "") contacts[i].Email = Email;

                Console.Write("New Birthdate (Enter to skip): ");
                string bd = Console.ReadLine();
                if (bd != "") contacts[i].BirthDate = bd;

                Console.WriteLine("Contact Updated!");
                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }

    static void DeleteContact()
    {
        Console.Write("Enter Mobile Number to Delete: ");
        string Mob = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].Mobile == Mob)
            {
                for (int j = i; j < count - 1; j++)
                {
                    contacts[j] = contacts[j + 1];
                }

                count--;
                Console.WriteLine("Contact Deleted");
                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }
}




// cd C:\Users\hardu\OneDrive\Desktop\Hardik20083974\Que.1 
// dotnet run
