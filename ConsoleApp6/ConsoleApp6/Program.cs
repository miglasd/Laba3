using System;
using System.IO;
using System.Threading.Tasks;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторна робота №3 Варiант 5");
            string path = File.ReadAllText( @"C:\Users\Dimon4ik\source\repos\ConsoleApp6\app.txt");
            string[] massText = path.Split(" ");
            foreach (var s in massText)
            {
                if (s.Substring(0, 1) == "s") Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
