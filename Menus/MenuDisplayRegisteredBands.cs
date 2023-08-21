using ScreenSoundV2.Models;

namespace ScreenSoundV2.Menus
{
    internal class MenuDisplayRegisteredBands : Menu
    {
        public override void Run(Dictionary<string, Band> registeredBand)
        {
            base.Run(registeredBand);
            DisplayTitleOfOption("Exibindo todas as bandas registradas");
            foreach (string banda in registeredBand.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }
            Console.WriteLine("\nCarregue em qualquer tecla para voltar ao menu inicial: ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
