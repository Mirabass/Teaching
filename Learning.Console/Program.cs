using Logic;
using System;

namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "Mirek";
            //double number = 15;
            //number += 5; // number = number + 5;
            //number++;
            //bool prsi = true;
            //prsi &= false; // prsi = prsi && true;

            //Console.WriteLine("Number: " + number + " mm");
            //Console.WriteLine($"Number: {number} mm");


            //Console.WriteLine(@"ZpĚtné lmítko: \");
            //Console.WriteLine("NĚco a \n toto je  na dalším Řádku");
            //Console.WriteLine("Hello World!");
            //// Vytvořím instanci (objekt) třídy FileProcessor s názvem fileProcessor
            //FileProcessor fileProcessor = new FileProcessor(); // new FileProcessor() .. konstruktor
            //fileProcessor.Path = @"C:\Users\miroslav.vaculka\source\repos\Learning.Console\Learning.Console\files\file1.txt";
            //fileProcessor.LoadFile();

            Processor processor = new();
            processor.Run();



            Console.ReadLine();
        }
    }
}
