using System;
public class PromptGenerator
{
   public static string[] prompt = {
        "What did you dream about last night?",
        "How did you make someone smile today?",
        "What could you do better today?",
        "How did you rely on the spirit today?",
        "How are you feeling about school?",
    };
    public List<string> _prompt = new List<string>(prompt);

    public PromptGenerator()
    {
        
    }
    public void Display()
    {
        var random = new Random();
        int index = random.Next(_prompt.Count);
        string PromptGenerator = _prompt[index];
        Console.WriteLine($"\n{_prompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompt.Count);
        string PromptGenerator = _prompt[index];

        return PromptGenerator;
    }
}