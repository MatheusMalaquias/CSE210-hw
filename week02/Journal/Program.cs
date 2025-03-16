using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public override string ToString()
    {
        return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n";
    }
}

public class Prompt
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What did I accomplish today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Entries.Add(new Entry(prompt, response, date));
    }

    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in Entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in Entries)
                {
                    writer.WriteLine($"{entry._date} | {entry._prompt}|{entry._response}");
                }
            }
            Console.WriteLine($"Journal successfully saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to file: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"The file {filename} does not exist.");
                return;
            }

            Entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entries.Add(new Entry(parts[1], parts[2], parts[0]));
                    }
                }
            }
            Console.WriteLine("Journal successfully loaded from file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file: {ex.Message}");
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt promptGenerator = new Prompt();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program!!");
            Console.WriteLine("Please select one of the following choice");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a New Entry
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"{randomPrompt}");
                    string response = Console.ReadLine();
                    journal.AddEntry(randomPrompt, response);
                    break;

                case "2":
                    // Display Journal Entries
                    journal.DisplayEntries();
                    Console.ReadKey();
                    break;

                case "3":
                    // Save Journal to File
                    Console.Write("Enter the filename to save the journal (e.g., journal.txt): ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.ReadKey();
                    break;

                case "4":
                    // Load Journal from File
                    Console.Write("Enter the filename to load the journal from (e.g., journal.txt): ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.ReadKey();
                    break;

                case "5":
                    // Exit
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}