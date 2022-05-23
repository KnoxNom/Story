namespace  Story;

public class Story {
    public static void Main()
    {
        // Console Settings
        Console.CursorVisible = false;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Title = "Story";
        Console.SetWindowSize(80, 25);
        Console.SetBufferSize(80, 25);
        // The Beginning
        Console.WriteLine("This is a story that no one remembers...");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("But today, you shall fill the void and create a new one...");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("I'm the Narrator, and I will guide you on this journey...");
        System.Threading.Thread.Sleep(3000);
        Console.ResetColor();
        Console.Clear();
        // The Introduction
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        // Name
        Console.WriteLine("Before we begin may I have your name? i.e: Writer");
        string name = Console.ReadLine();
        switch (name)
        {
            case "":
                Console.WriteLine("Hmm, I see in that case you shall be known as 'Writer'...");
                name = "Writer";
                break;
        }
        // Location
        Console.WriteLine("Next, what location do you want to begin in? i.e: City");
        string location = Console.ReadLine();
        switch (location)
        {
            case "":
                Console.WriteLine("In that case you shall start off in the 'forest'...");
                location = "forest";
                break;
        }
        // Species
        Console.WriteLine("Now, what species are you? i.e: 'Unknown'");
        string species = Console.ReadLine();
        switch (species)
        {
            case "":
                Console.WriteLine("Well then let's go with 'Unknown'...");
                species = "Unknown";
                break;
        }
        System.Threading.Thread.Sleep(3000);
        Console.ResetColor();
        Console.Clear();
        // Prologue
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Once long a time ago, there was the {0} which ruled over the world though on a unfaithful day where the world went dark a great war broke out killing all of the {0} and only leaving behind remains of their creations...", species);
        System.Threading.Thread.Sleep(7000);
        Console.WriteLine("And that is where our story begins...");
        System.Threading.Thread.Sleep(3000);
    }
}