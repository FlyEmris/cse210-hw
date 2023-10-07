using System;
using System.IO;

namespace learning02;

class Menu
{
    static void Main(string[] args)
    {
        {
            Journal journal = new Journal();
            PromptGenerator pg = new PromptGenerator();
            Console.WriteLine("1.  Write");
            Console.WriteLine("2.  Display");
            Console.WriteLine("3.  Load");
            Console.WriteLine("4.  Save");
            Console.WriteLine("5.  Quit");
            Console.WriteLine("What would you like to do?");
            string read = Console.ReadLine();
            int reading = int.Parse(read);

            
        
            while(reading != 5)
            {
                switch (reading)
                {
                    case 1:
                        string entryId = GetEntryId();
                        string dateInfo = GetDateTime();
                        string prompt = pg.GetPrompt();

                        Entry entry = new Entry();
                        entry._entryNumber = entryId;
                        entry._date = dateInfo;
                        entry._prompt = prompt;

                        Console.Write($"{prompt}");
                        Console.Write(">>> ");
                        string userEntry = Console.ReadLine();
                        entry._Entry = userEntry;

                        journal._Entries.Add(entry);

                        break;
                    case 2:
                        journal.Display();
                        break;
                    case 3:
                        journal.LoadJournalFile();
                        break;
                    case 4:
                        journal.CreateJournalFile();
                        AddJournalEntry();
                        break;
                    case 5:
                        Console.WriteLine("Have a good Day!");
                        break;
                    default:
                        Console.WriteLine($"Sorry that is a incorrect option!");
                        break;
                }
                read = Console.ReadLine();
                reading = int.Parse(read);
            }
            Console.WriteLine("Have a good day!");
            Console.ReadLine();  

        }

    }
    static string GetDateTime()
    {
        DateTime now = DateTime.Now;
        string theCurrentTime = now.ToString("F");

        return theCurrentTime;
    }
    static void AddJournalEntry()
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }
    static string GetEntryId()
    {
        Guid entryuuid = Guid.NewGuid();
        string entryuuidAsString = entryuuid.ToString();

        return entryuuidAsString;
    }


}

    