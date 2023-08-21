using ScreenSoundV2.Models;

namespace ScreenSoundV2.Menus;

internal class MenuShowDetails : Menu
{
   
    public override void Run(Dictionary<string, Band> registeredBand)
    {
        base.Run(registeredBand);
        DisplayTitleOfOption("Exibindo a média de pontos da banda");
        Console.Write("Digite o nome da banda que pretende saber detalhes: ");
        string bandName = Console.ReadLine()!;
        if (registeredBand.ContainsKey(bandName))
        {
            Band band = registeredBand[bandName];
            Console.WriteLine($"\nA pontuação média é de {band.AverageOfGrades}");
            Console.WriteLine("\nDiscografia:");
            foreach (Album a in band.Albums)
            {
                Console.WriteLine($"{a.Name} --> {a.AverageOfGrades}\n");
            }
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

