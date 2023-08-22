using ScreenSoundV2.Models;

namespace ScreenSoundV2.Menus;

internal class MenuShowDetails : Menu
{
   
    public override void Run(Dictionary<string, Band> registeredBand)
    {
        base.Run(registeredBand);
        DisplayTitleOfOption("Exibindo a média de pontos da banda");
        Console.Write("\nDigite o nome da banda que pretende saber detalhes: ");
        string bandName = Console.ReadLine()!;
        if (registeredBand.ContainsKey(bandName))
        {
            Band band = registeredBand[bandName];
            Console.WriteLine(band.Resume);
            Console.WriteLine($"A pontuação média até o momento é de {band.AverageOfGrades}");
            Console.WriteLine("\nDiscografia:");
            if (band.Albums.Count() == 0)
            {
                Console.WriteLine("\nSem dados registrados ainda.");
               
            }
            else
            {
                foreach (Album a in band.Albums)
                {
                    Console.WriteLine($"{a.Name} --> {a.AverageOfGrades}\n");
                }
                
            }
            
        }
        else
        {
            Console.WriteLine($"A banda {bandName} não foi encontrada");
           
        }
        Console.Write("\n\nDigite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
    }
}

