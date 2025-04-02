using System;
using System.Drawing;
using System.IO;
using MyLibrary.Properties;

namespace MyLibrary
{
    public class ResourceManager
    {
        public void ShowResources()
        {
            Console.WriteLine("Сообщение из ресурсов: " + Resources.HelloWorld);
        }

        public void SaveCatImage(string filePath)
        {
            if (Resources.cat != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Resources.cat.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    File.WriteAllBytes(filePath, ms.ToArray());
                    Console.WriteLine($"Кот сохранен в {filePath}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: изображение кота не найдено!");
            }
        }
    }
}
