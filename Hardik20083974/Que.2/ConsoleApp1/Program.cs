#nullable disable
using System;


class MainClass
{
    static FileType[] extension = new FileType[200];
    static int count = 0;

    public static void Main(string[] args)
    {
        DefaultExtention();

        while (true)
        {
            Console.WriteLine("\n=== File Type Menu ===");
            Console.WriteLine("1.Show All Types");
            Console.WriteLine("2. Show One Type");
            Console.WriteLine("3. Add Type");
            Console.WriteLine("4. Update Type");
            Console.WriteLine("5. Delete Type");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Choose Option: ");

            string opt = Console.ReadLine();

            switch (opt)
            {
                case "0":
                    return;

                case "1":
                    ShowAll();
                    break;

                case "2":
                    Search();
                    break;

                case "3":
                    AddType();
                    break;

                case "4":
                    UpdateType();
                    break;

                case "5":
                    DeleteType();
                    break;

                default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }
    }

    static void DefaultExtention()
    {
        Add(".mp4", "Video File");
        Add(".avi", "Video File");
        Add(".mov", "Video File");
        Add(".mkv", "Video File");
        Add(".webm", "Video File");

        Add(".mp3", "Audio File");
        Add(".wav", "Audio File");
        Add(".flac", "Audio File");

        Add(".jpg", "Image File");
        Add(".jpeg", "Image File");
        Add(".png", "Image File");
        Add(".gif", "Image File");

        Add(".pdf", "PDF Document");
        Add(".docx", "Word Document");
        Add(".xlsx", "Excel Worksheet");
        Add(".pptx", "PowerPoint Presentation");
        Add(".txt", "Text File");

        Add(".zip", "Compressed File");
        Add(".rar", "Compressed File");
        Add(".7z", "Compressed File");  
    }

    static void Add(string ext, string desc)
    {
        FileType ft = new FileType();
        ft.Extension = ext;
        ft.Description = desc;

        extension[count] = ft;
        count++;
    }

    static void ShowAll()
    {
        Console.WriteLine("\nSupported File Types:");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{extension[i].Extension} - {extension[i].Description}");
        }
    }
    static void Search()
    {
        Console.Write("Enter Type:");
        string ext = Console.ReadLine();
        
        if(ext !="" && ext[0] != '.')
            ext = "." + ext;

        for (int i = 0; i < count; i++)
        {
            if (extension[i].Extension == ext)
            {
                extension[i].ShowType();
                return;
            }
        }

        Console.WriteLine("Type Not Found...");
    }

    static void AddType()
    {
        Console.Write("New Type: ");
        string ext = Console.ReadLine();

        if (ext !=""&& ext[0] !='.')
            ext = "." + ext;

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Add(ext, desc);
        Console.WriteLine("Type Added Sucessfully!");
    }

    static void UpdateType()
    {
        Console.Write("Enter Type to Edit:");
        string ext = Console.ReadLine();

        if (ext !="" && ext[0] !='.')
            ext = "." + ext;
        
        for(int i= 0; i < count; i++)
        {
            if (extension[i].Extension == ext)
            {
                Console.WriteLine("New Description: ");
                string updated = Console.ReadLine();

                if (updated !="")
                    extension[i].Description = updated;

                    Console.WriteLine("Type Updated!");
                    return;
            }
        }
        Console.WriteLine("Type Not Found.");
    }

    static void DeleteType()
    {
        Console.Write("Enter Type to Delete: ");
        string ext = Console.ReadLine();

        if (ext !=""&& ext[0] != '.')
            ext = "." + ext;

        for (int i = 0; i < count; i++)
        {
            if (extension[i].Extension == ext)
            {
                for (int j = i; j < count - 1; j++)
                {
                    extension[j] = extension[j + 1];
                }

                count--;
                Console.WriteLine("Type Deleted.");
                return;
            }
        }

        Console.WriteLine("Type Not Found....");
    }
}


// cd C:\Users\hardu\OneDrive\Desktop\Hardik20083974\Que.2\ConsoleApp1 
//dotnet run