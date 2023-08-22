using OpenAI_API;
using ScreenSoundV2.Models;
using System.Data;

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
        if (registeredBand.ContainsKey(bandName)) 
        {
            Console.WriteLine("Esta banda já foi registrada anteriormente!");
           
        }
        else
        {
            registeredBand.Add(bandName, band);

            var client = new OpenAIAPI("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");

            var chat = client.Chat.CreateConversation();

            chat.AppendSystemMessage($"Resuma em apenas um paragrafo informal a banda {bandName}");

            string answer = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
            band.Resume = answer;

            Console.WriteLine($"A banda {bandName} foi registrada com sucesso!");            

        }
        Thread.Sleep(2000);
        Console.Clear();

    }
}
