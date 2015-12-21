using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PakkeLegConsole
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Terningslag();

            Terningslag();

            Terningslag();

            Terningslag();

            Terningslag();

            Terningslag();

            Console.ReadLine();
        }

        static void Terningslag()
        {
            Console.WriteLine("Tryk på en enter");
            Console.ReadLine();
            int tal = rnd.Next(1, 7);
            Console.WriteLine(tal);
            if (tal == 6)
            {
                Console.WriteLine("PAKKE TIL DIG!!");
            }
            else
            {
                Console.WriteLine("næste persons tur");
            }
 
        }
    }
}
