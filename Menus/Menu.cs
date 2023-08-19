using ScreenSoundV2.Models;

namespace ScreenSoundV2.Menus;

internal class Menu
{
    public virtual void Run(Dictionary<string, Band> registeredBand)
    {
        Console.Clear();
    }
    public void DisplayTitleOfOption(string titulo)
    {
        int qtdLetras = titulo.Length;
        string asteristicos = string.Empty.PadLeft(qtdLetras, '*');
        Console.WriteLine(asteristicos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteristicos + "\n\n");
    }

}
