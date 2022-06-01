namespace  Story;

public class Story {
    public static void Main()
    {
        // Console Settings
        Console.CursorVisible = false;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Title = "Story";
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
        Console.WriteLine("Before we begin may I have your name? i.e: Ace");
        var name = Console.ReadLine();
        switch (name)
        {
            case "":
                Console.WriteLine("Hmm, I see in that case you shall be known as 'Ace'...");
                name = "Ace";
                break;
        }
        // Location
        Console.WriteLine("Next, what location do you want to begin in? i.e: City");
        var location = Console.ReadLine();
        switch (location)
        {
            case "":
                Console.WriteLine("In that case you shall start off in the 'forest'...");
                location = "forest";
                break;
        }
        // Species
        Console.WriteLine("Now, what species are you? i.e: 'Unknown'");
        var species = Console.ReadLine();
        switch (species)
        {
            case "":
                Console.WriteLine("Well then let's go with 'Unknown'...");
                species = "Unknown";
                break;
        }
        System.Threading.Thread.Sleep(5000);
        Console.ResetColor();
        Console.Clear();
        // Prologue
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Chapter: 0 - Prologue");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("There once lived a great race called {0}...", species);
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("Though one dark day a great war broke out...");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("The war caused a mass extinction of the {0}...", species);
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("Many centuries pass and new species emerged but soon...they started a war...");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("This is where our journey begins a world in chaos fighting for power what shall you do...");
        System.Threading.Thread.Sleep(5000);
        Console.Clear();
        Console.ResetColor();
        // The Void
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Some where inside a {0}, we find a {1} scavenging through rubble...", location, species);
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("That {0} is called {1} and they are the last {0} left...", species, name);
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("{0} finds a old book it has some unknown symbols on the cover...", name);
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("{0} seems oddly happy?...", name);
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("{0} opens the book...", name);
        System.Threading.Thread.Sleep(5000);
        Console.WriteLine("Nothing...theres nothing there its all blank...");
        System.Threading.Thread.Sleep(5000);
        Console.WriteLine("{0} now unhappy and throws the book but then...", name);
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("A dark beam strikes down at {0}...", name);
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("Theres nothing plants, weeds anything that was alive are all dead in a 1KM radius...");
        System.Threading.Thread.Sleep(5000);
        Console.WriteLine("The place where {0} was standing now is but a hole one that never ends...", name);
        System.Threading.Thread.Sleep(7000);
    }
}
