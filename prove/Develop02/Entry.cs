using System;
public class Entry
{
    public string _entryNumber;
    public string _prompt;
    public string _date;
    public string _Entry;

    public string _File;


    public Entry()
    {

    }

    public void Display()
    {
        Console.WriteLine($"\n#: {_entryNumber}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_Entry}");
    }
}
