using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gusev_ITMO_Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string userFolder;
            do
            {
                Console.Write("Введите название и путь к выбранной папке: ");
                userFolder = Console.ReadLine();
                if (!Directory.Exists(userFolder))
                {
                    Console.WriteLine("Введенной папки не существует или ее название введено неправильно.");
                }
            } while (!Directory.Exists(userFolder));

            Console.WriteLine("Список папок в папке \"{0}\":", userFolder);
            string[] directories = Directory.GetDirectories(userFolder);
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }

            Console.WriteLine("Список файлов в папке \"{0}\":", userFolder);
            string[] files = Directory.GetFiles(userFolder);
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }

            Console.ReadKey();
        }

    }
}
