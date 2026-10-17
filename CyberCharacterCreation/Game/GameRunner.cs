using CyberCharacterCreation.Characters;
using CyberCharacterCreation.Decorators;
using CyberCharacterCreation.Factories;
using CyberCharacterCreation.Game;
using CyberCharacterCreation.Inventory;

namespace CyberCharacterCreation.Game;

public class GameRunner
{
    private readonly GameState _world = GameState.Instance;

    public void Run()
    {
        Console.WriteLine("===== Well Come to Neo‑City---Cyber Character Creation! =====");
        Console.WriteLine("Here, you can build the most terrifying army—----and make your enemies tremble!!!");
        Console.WriteLine($"Neo‑City simulation started {_world.NeoCityStartTime:HH:mm} | Threat Level {_world.ThreatLevel}");


        Console.Write("\nEnter operative name: ");
        string name = Console.ReadLine()?.Trim() ?? "Rookie";


        Console.WriteLine("\nChoose race: 1 = Human 2 = Synth");
        string raceSel = Console.ReadLine()?.Trim();
        string race = raceSel == "2" ? "synth" : "human";


        Character player = CharacterFactory.CreateCharacter(race, name);
        var invFacade = new InventoryFacade(player.Inventory);


        invFacade.QuickAdd("Stim‑Injector", "Emergency combat stimulant");


        Console.WriteLine("\nChoose operative class: 1 = Mercenary 2 = NetRunner");
        string classSel = Console.ReadLine()?.Trim();
        if (classSel == "1")
        {
            player = new MercenaryDecorator(player);
        } else if (classSel == "2")
        {
            player = new NetRunnerDecorator(player);
        }


        invFacade.QuickAdd(classSel == "1" ? "Heavy Sidearm" : "Neural‑Jack", "Starting operative gear");
        player.PrintDetails();

        Console.WriteLine("\n$$$ Operative Gear $$$");
        invFacade.PrintAllItems();

        Console.WriteLine("\n!!! Operative in action !!!");
        player.Speak();
        player.Act();

        Console.WriteLine("\nCreation finished.");
    }
}

