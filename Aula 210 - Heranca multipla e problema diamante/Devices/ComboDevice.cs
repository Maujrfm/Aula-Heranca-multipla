using System;

namespace Aula_210___Heranca_multipla_e_problema_diamante.Devices
{
    class ComboDevice:Device,IScanner,IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print "+document); ;
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing " + document); ;
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
