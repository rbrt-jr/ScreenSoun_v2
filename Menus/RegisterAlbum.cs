using ScreenSoundV2.Models;

namespace ScreenSoundV2.Menus;

internal class RegisterAlbum : Menu
{
    public override void Run(Dictionary<string, Band> registeredBand)
    {
        base.Run(registeredBand);
        Console.Write("Primeiro insira o nome da banda pretendida: ");
        string bandName = Console.ReadLine()!;
        if (registeredBand.ContainsKey(bandName))
        {
            Band band = registeredBand[bandName];
            Console.Write("Agora insira o nome do album: ");
            string albumTitle = Console.ReadLine()!;
            band.AddAlbum(new Album(albumTitle));
            Console.WriteLine($"O album {albumTitle} foi registrado com sucesso!");
            Console.WriteLine($"Total de albuns registrados até agora: {Album.CounterOfAlbuns}");
            Thread.Sleep(3000);
            Console.Clear();            
        }
        else
        {
            Console.WriteLine($"A banda {bandName} não foi encontrada");
            Console.Write("Digite uma tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Console.Clear();           
        }
    }
}
