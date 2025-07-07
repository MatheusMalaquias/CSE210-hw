public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    public void Run() {
        DisplayStartingMessage();
        int duration = _duration;
        do {
            Console.Write($"Breathe in... ");
            ShowCountdown(4);
            Console.Write($"\n");
            Console.Write("Now, Breathe out... ");
            ShowCountdown(6);
            Console.Write($"\n \n");
            
            duration -= 10;
        } while (duration > 0);
        
        DisplayEndingMessage();
    }
}