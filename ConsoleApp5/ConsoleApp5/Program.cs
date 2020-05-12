using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] textMass;
            int count=0;
            Console.WriteLine("Лабораторна робота №3 Варiант 5");
            Console.WriteLine("Введiть текст:");
            string text = Console.ReadLine();
            textMass = text.Split(' ');
            
        foreach(var s in textMass)
            {
                if (s.Substring(0,1)=="а" || s.Substring(0, 1) == "о" || s.Substring(0, 1) == "у" || s.Substring(0, 1) == "і" || s.Substring(0, 1) == "е" || s.Substring(0, 1) == "и" || s.Substring(0, 1) == "А" || s.Substring(0, 1) == "О" || s.Substring(0, 1) == "У" || s.Substring(0, 1) == "І" || s.Substring(0, 1) == "Е" || s.Substring(0, 1) == "И")
                count++;
            }
            Console.WriteLine("Слiв починаючих з голосной - "+count);
            Console.ReadLine();
        }
    }
}
