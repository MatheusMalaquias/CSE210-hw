public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")

{

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you made a difference in someone's life.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What did you learn from this experience?");

    }
    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("Consider the following prompt: ");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();
        DisplayQuestion();

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion(List<string> questions) 
    {
        Random random = new Random();
        int index = random.Next(questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---\n");

    }
    public void DisplayQuestion()
    {
        int duration = _duration;
        List<string> questions = _questions;

        do
        {
            string question = GetRandomQuestion(questions); 
            Console.Write(question);                 
            ShowSpinner(9); 
            Console.Write("\n\n");
            questions.Remove(question);
            duration -= 10;
        } while (duration > 0 && questions.Count > 0);
    }

}