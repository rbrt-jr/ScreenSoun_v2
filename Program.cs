// Screen Sound

using ScreenSoundV2.Menus;
using ScreenSoundV2.Models;
using OpenAI_API;



string msgDeBoasVindas = "Boas vindas ao Screen Sound!";

Band ira = new ("Ira!");
ira.AddGrade(new Grade(10));
ira.AddGrade(new Grade(8));
ira.AddGrade(new Grade(6));
ira.AddAlbum(new Album("Envelheço na cidade"));


Dictionary<int, Menu> options = new();
options.Add(1, new MenuRegisterBand());
options.Add(2,new MenuRegisterAlbum());
options.Add(3, new MenuDisplayRegisteredBands());
options.Add(4,new MenuEvaluateBand());
options.Add(5, new MenuShowDetails());
options.Add(6, new MenuEvaluateAlbum());
options.Add(-1,new MenuQuit());

Band teenageFanClub = new("Teenage Fan Club");
Dictionary<string, Band> registeredBand = new();
registeredBand.Add(ira.Name, ira);
registeredBand.Add(teenageFanClub.Name, teenageFanClub);

void DisplayLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(msgDeBoasVindas + "\n");
}
void ShowMenuOfOptions()
{
    DisplayLogo();
    Console.WriteLine("Digite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para registrar um album à banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas.");
    Console.WriteLine("Digite 4 para avaliar uma banda.");
    Console.WriteLine("Digite 5 para exibir detalhes de uma banda.");
    Console.WriteLine("Digite 6 para avaliar um álbum.");
    Console.WriteLine("Digite -1 para sair.");
    Console.Write("\nQual é a sua opção? ");

    string chosenOption = Console.ReadLine()!;
    int numericalOption = int.Parse(chosenOption!);

    if (options.ContainsKey(numericalOption))
    {
        Menu displayTheMenu = options[numericalOption];
        displayTheMenu.Run(registeredBand);
        if (numericalOption > 0) ShowMenuOfOptions();
    }
    else
    {
        Console.WriteLine("Opção invalida!");
        Thread.Sleep(3000);
        Console.Clear();
        ShowMenuOfOptions();
    }
   
    
}

ShowMenuOfOptions();

