using Logic;
using System;

namespace Learning.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double Number = 15;
            //Number +=5; //zvětším +5
            //Number++; // zvětším +1
            //Console.WriteLine("Number: " + Number + " mm");
            //Console.WriteLine($"Number: {Number} mm");
            //bool    prsi = false;
            //prsi &= true;
            //string pozdrav = "Ahoj";

            //Console.WriteLine("Hello World!");
            //FileProcessor fileProcessor = new FileProcessor();      //vytvořím instanci (objekt) třídy file processor s názvem file processor
            //fileProcessor.Path = @"C:\Users\tomas.novak\source\repos\Learning\Learning.UI\files\text.txt";
            //fileProcessor.LoadFile();

            Processor processor = new Processor();
            processor.Run();

            Console.ReadLine();
            //komentář
        }
    }
}
