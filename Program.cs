namespace  Story;

public class Story {
    public static void Main()
    {
        // Console Settings
        Console.CursorVisible = false;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Title = "Story";
        Console.SetWindowSize(80,25);
        Console.SetBufferSize(80,25);
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
        Console.WriteLine("Chapter: 0 - Prologue");
        System.Threding.Thread.Sleep(2000);
        Console.WriteLine("There once lived a great race called {0}...", species);
        System.Threding.Thread.Sleep(2000);
        Console.WirteLine("Though one dark day a great war broke out...");
        System.Threding.Thread.Sleep(2000);
        Console.WriteLine("The war caused a mass extinction of the {0}...", species);
        System.Threding.Thread.Sleep(2000);
        Console.WriteLine("Many centuries pass and new species emerged but soon...they started a war...");
        System.Threding.Thread.Sleep(2000);
        Console.WriteLine("This is where our journey begins a world in chaos fighting for power what shall you do...");
        System.Threading.Thread.Sleep(5000);
        Console.Clear();
    }
}
