using ScreenSoundV2.Models;
namespace ScreenSoundV2.Menus;

internal class MenuEvaluateAlbum : Menu
{
    public override void Run(Dictionary<string, Band> registeredBand)
    {
        base.Run(registeredBand);
        DisplayTitleOfOption("Avaliar Album");
        Console.Write("Digite a banda que pretende avaliar: ");
        string bandName = Console.ReadLine()!;
        
        if (registeredBand.ContainsKey(bandName))
        {
            Band band = registeredBand[bandName];
            Console.Write("Agora insira o nome do album: ");
            string albumTitle = Console.ReadLine()!;           
            if (band.Albums.Any(a => a.Name.Equals(albumTitle)))
            {
                Album album = band.Albums.First(a => a.Name.Equals(albumTitle));
                Console.Write($"Qual a nota que o álbum {albumTitle} da banda {bandName} merece: ");
                Grade value = Grade.Parse(Console.ReadLine()!);
                
                album.AddGrade(value);
                Console.WriteLine($"\nA nota {value.Value} foi registrada com sucesso para o álbum {albumTitle}");
                Thread.Sleep(4000);
                Console.Clear();
            } else
            {
                Console.WriteLine($"O álbum {albumTitle} não foi encontrada");
                Console.Write("Digite uma tecla para voltar ao menu principal: ");
                Console.ReadKey();
                Console.Clear();
            }           
            
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

