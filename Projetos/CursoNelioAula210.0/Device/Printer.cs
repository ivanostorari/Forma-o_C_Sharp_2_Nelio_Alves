using CursoNelioAula2100.Devices;
using System;

namespace CursoNelioAula2100.Devices
{
    class Printer : Device, IPrinter
    {

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}