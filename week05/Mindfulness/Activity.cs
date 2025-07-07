public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description) {
        _name = name;
        _description = description;
 
    }
    public void DisplayStartingMessage() {
        Console.WriteLine($"Welcome to the {_name} activity \n");
        Console.WriteLine(_description + "\n");
        Console.WriteLine($"How long, in seconds, would you like for your session?");
        string input = Console.ReadLine();
        int duration = int.Parse(input);
        SetDuration(duration);
        Console.WriteLine($"\n");
        Console.Clear();
        Console.Write($"Get ready... ");
        ShowSpinner(4);
        Console.Write($"\n \n");

    }
    protected void SetDuration(int duration) {
        _duration = duration;
    }
    public void ShowSpinner(int durationSeconds){
         
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        int totalIterations = durationSeconds * 5; 

        for (int i = 0; i < totalIterations; i++)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(200); 
            Console.Write("\b"); 

            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
        Console.Write("\b\b");
    }

    public void DisplayEndingMessage() {
        Console.WriteLine($"Well done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        ShowSpinner(5);
    }

    public void ShowCountdown(int seconds) {

        for (int i = seconds; i > 0; i--) {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}