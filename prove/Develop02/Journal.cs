using System;
using System.Text.Json;
using System.Text.Json.Serialization;
public class Journal
{
        public List<Entry> _Entries = new List<Entry>();

        private string _userFileName;


        public Journal()
        {
            
        }


        public void Display()
        {
            Console.WriteLine("Entries:");



            foreach (Entry entry in _Entries)
            {
                entry.Display();
            }
            Console.WriteLine("End");
        
        }
    public void CreateJournalFile()
    {
        Console.Write("Whate is your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if(!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($"{_userFileName} has been created!");
            Console.Write("Your entries has been created!");
            SaveJournalFile(_userFileName);
        }
        else
        {
            Console.Write($"{_userFileName} already exists.");
            Console.Write("The journal entries have been added.");
            AppendJournalFile(_userFileName);
        }
    }
    public void SaveJournalFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (Entry entry in _Entries)
            {
                outputFile.WriteLine($"{entry._entryNumber}; {entry._date}");
            }
        }
    }
    public void AppendJournalFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
        {
            foreach (Entry entry in _Entries)
            {
                outputFile.WriteLine($"{entry._entryNumber}; {entry._date}");
            }
        }
        
    }
    public void LoadJournalFile()
    {
        Console.Write("What is your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                Entry entry = new Entry();

                entry._entryNumber = entries[0];
                entry._date = entries[1];
                entry._prompt = entries[2];
                entry._Entry = entries[3];

                _Entries.Add(entry);
            }
        }   
    }
    public void CreateJSON(string userInput)
    {
        string fileName = userInput + ".json";
        List<JsonItem> _data = new List<JsonItem>();

        foreach (Entry entry in _Entries)
        {
            _data.Add(new JsonItem()
            {
                ID = entry._entryNumber,
                Date = entry._date,
                Prompt = entry._prompt,
                Entry = entry._Entry
            });
        }

        string json = JsonSerializer.Serialize(_data);
        File.WriteAllText(fileName, json);

    }
}
