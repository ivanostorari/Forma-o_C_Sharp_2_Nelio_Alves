using CursoNelioAula2100.Device;
using CursoNelioAula2100.Devices;
using System;

namespace CursoNelioAula2100.Devices
{
    class Scanner : Device, IScanner
    {

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}