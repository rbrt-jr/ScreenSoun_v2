using ScreenSoundV2.Models;

namespace ScreenSoundV2.Menus;

internal class QuitMenu : Menu
{
    public override void Run(Dictionary<string, Band> registeredBand)
    {
        Console.WriteLine("Adeus! :)");
    }
}
