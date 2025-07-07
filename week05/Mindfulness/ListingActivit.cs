
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("What are some things you like about yourself?");
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Write("\n \n");
        List<string> userList = GetListFromUser();
        Console.WriteLine($"You listed {userList.Count} items.");

        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"\n{ _prompts[index]} \n");

    }
public List<string> GetListFromUser()
{
    List<string> userList = new List<string>();
    int duration = _duration;

    Stopwatch timer = Stopwatch.StartNew();

    while (timer.Elapsed.TotalSeconds < duration)
    {
        if (Console.KeyAvailable)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                userList.Add(input);
            }
        }
    }

    return userList;
}

}