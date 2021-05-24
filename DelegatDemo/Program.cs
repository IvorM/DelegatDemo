using System;

namespace DelegatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegatDemoClass delegatDemoClass = new DelegatDemoClass();
            Console.WriteLine("Unesite broj:");
            var unsesniBroj = int.Parse(Console.ReadLine());
            if (unsesniBroj==(int)EnumDemo.NaCekanju)
            {
                Console.WriteLine("Unesen je broj 0");
            }
        }
    }
}
