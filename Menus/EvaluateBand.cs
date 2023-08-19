using ScreenSoundV2.Models;

namespace ScreenSoundV2.Menus;

internal class EvaluateBand : Menu
{
    public override void Run(Dictionary<string, Band> registeredBand)
    {      
        base.Run(registeredBand);   
        DisplayTitleOfOption("Avaliar Banda");
        Console.Write("Digite a banda que pretende avaliar: ");
        string bandName = Console.ReadLine()!;
        if (registeredBand.ContainsKey(bandName))
        {
            Band band = registeredBand[bandName];
            Console.Write($"Qual a nota que a banda {bandName} merece: ");
            Grade value = Grade.Parse(Console.ReadLine()!);
            band.AddGrade(value);
            Console.WriteLine($"\nA nota {value.Value} foi registrada com sucesso para a banda {bandName}");
            Thread.Sleep(4000);
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
