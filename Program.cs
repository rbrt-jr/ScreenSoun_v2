// Screen Sound
using ScreenSoundV2.Models;


string msgDeBoasVindas = "Boas vindas ao Screen Sound!";

Band ira = new ("Ira!");
ira.AddGrade(new Grade(10));
ira.AddGrade(new Grade(8));
ira.AddGrade(new Grade(6));

Band teenageFanClub = new("Teenage Fan Club");
/*teenageFanClub.AddGrade(new Grade(9)); 
teenageFanClub.AddGrade(new Grade(8));
teenageFanClub.AddGrade(new Grade(10));*/

Dictionary<string, Band> registeredBand = new();
registeredBand.Add(ira.Name, ira);
registeredBand.Add(teenageFanClub.Name, teenageFanClub);


void ExibirLogo()
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
void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para mostrar a média de avaliação de uma banda.");
    Console.WriteLine("Digite 5 para registrar o album à banda.");
    Console.WriteLine("Digite -1 para sair.");
    Console.Write("\nQual é a sua opção? ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida!);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda(); 
            break;
        case 2: MostrarBandasRegistradas(); 
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMediaDaBanda(); 
            break;
        case 5:
            RegisterAlbum();
            break;
        case -1: Console.WriteLine("Adeus! :)");
            break;
        default: Console.WriteLine("Opção invalida!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Nome: ");
    string bandName= Console.ReadLine()!;
    Band band = new(bandName);
    registeredBand.Add(bandName, band);
    Console.WriteLine($"A banda {bandName} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void RegisterAlbum()
{
    Console.Clear();
    Console.Write("Primeiro insira o nome da banda pretendida: ");
    string bandName = Console.ReadLine()!;
    if (registeredBand.ContainsKey(bandName))
    {
        Band band = registeredBand[bandName];
        Console.Write("Agora insira o nome do album: ");
        string albumTitle = Console.ReadLine()!;
        band.AddAlbum(new Album(albumTitle));
     
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"A banda {bandName} não foi encontrada");
        Console.Write("Digite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }


}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    foreach(string banda in registeredBand.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nCarregue em qualquer tecla para voltar ao menu inicial: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int qtdLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(qtdLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n\n");
}

void AvaliarUmaBanda()
{
    // digitar o nome da banda para ser avaliada
    // se a banda existir, adicionar nota ao dicionário
    // senão, voltar ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
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
        ExibirOpcoesMenu();
    } else
    {
        Console.WriteLine($"A banda {bandName} não foi encontrada");
        Console.Write("Digite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }

}

void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo a média de pontos da banda");
    Console.Write("Digite o nome da banda que pretende saber a média: ");
    string bandName = Console.ReadLine()!;
    if (registeredBand.ContainsKey(bandName))
    {
        Band band = registeredBand[bandName];
        Console.WriteLine("A pontuação é de ", band.AverageOfGrades);
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

ExibirOpcoesMenu();