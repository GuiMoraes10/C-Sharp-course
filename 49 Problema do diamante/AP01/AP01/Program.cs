using AP01.Devices;
using System;

namespace AP01
{
    class Program
    {

        // A herança multipla pode gerar o problema do diamante, uma ambiguidade causada pela existência do mesmo metodo em mais de uma superclasse
        // Não é permitida na maioria das linguagens

        static void Main(string[] args)
        {

            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());

        }
    }
}