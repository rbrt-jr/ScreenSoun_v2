using ScreenSoundV2.Models;

namespace ScreenSoundV2.Menus;

internal class ShowDetails : Menu
{
   
    public override void Run(Dictionary<string, Band> registeredBand)
    {
        base.Run(registeredBand);
        DisplayTitleOfOption("Exibindo a média de pontos da banda");
        Console.Write("Digite o nome da banda que pretende saber a média: ");
        string bandName = Console.ReadLine()!;
        if (registeredBand.ContainsKey(bandName))
        {
            Band band = registeredBand[bandName];
            Console.WriteLine($"A pontuação média é de {band.AverageOfGrades}");
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

