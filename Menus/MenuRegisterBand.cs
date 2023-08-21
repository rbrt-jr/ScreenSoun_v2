using ScreenSoundV2.Models;

namespace ScreenSoundV2.Menus;

internal class MenuRegisterBand : Menu
{
    public override void Run(Dictionary<string, Band> registeredBand)
    {
        base.Run(registeredBand);
        DisplayTitleOfOption("Registro de bandas");
        Console.Write("Nome: ");
        string bandName = Console.ReadLine()!;
        Band band = new(bandName);
        registeredBand.Add(bandName, band);
        Console.WriteLine($"A banda {bandName} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        
    }
}
