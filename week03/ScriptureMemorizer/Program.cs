using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture(new Reference("John", 3, 16, 16), new List<Word> {
            new Word("For"),
            new Word("God"),
            new Word("so"),
            new Word("loved"),
            new Word("the"),
            new Word("world"),
            new Word("that"),
            new Word("he"),
            new Word("gave"),
            new Word("his"),
            new Word("only"),
            new Word("Son,"),
            new Word("that"),
            new Word("whoever"),
            new Word("believes"),
            new Word("in"),
            new Word("him"),
            new Word("should"),
            new Word("not"),
            new Word("perish"),
            new Word("but"),
            new Word("have"),
            new Word("eternal"),
            new Word("life.")
        });

        string input = "";
        do{
        Console.WriteLine(scripture1.GetDisplayText());
        if(scripture1.IsCompletelyHidden()){
            Console.WriteLine("All the scripture is hidden!");
            break;
        }
        Console.WriteLine("Press enter to continue or type 'quit' to exit.");
        input = Console.ReadLine();

        scripture1.HideRandomWord(4);
        Console.Clear();

        }while(input != "quit");
    }
}