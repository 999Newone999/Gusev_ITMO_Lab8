using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gusev_ITMO_Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Lab8_2.txt";
            double sum=0;

            Random rnd = new Random();

            if (File.Exists(fileName))
            {
                File.Create(fileName);
            }
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                for (int i = 0; i < 10; i++)
			        {
                        sw.WriteLine(rnd.NextDouble());
			        }
            }
            using (StreamReader sr = new StreamReader(fileName))
            {
                for (int j = 0; j < 10; j++)
                {
                    sum=sum+ Convert.ToDouble(sr.ReadLine());
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
