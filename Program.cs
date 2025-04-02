using System;
using MyLibrary;

class Program
{
    static void Main()
    {
        var resourceManager = new ResourceManager();

        resourceManager.ShowResources();

        resourceManager.SaveCatImage("cat_output.png");

        Console.WriteLine("Работа завершена. Проверьте файл cat_output.png.");
    }
}
