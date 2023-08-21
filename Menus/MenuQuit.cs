using ScreenSoundV2.Models;

namespace ScreenSoundV2.Menus;

internal class MenuQuit : Menu
{
    public override void Run(Dictionary<string, Band> registeredBand)
    {
        Console.WriteLine("Adeus! :)");
    }
}
