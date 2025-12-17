using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flykten_från_fängelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool haveDoorkey = false;
            bool haveDeskkey = false;
            bool escaped = false;

            Console.WriteLine("du vaknar upp i ett rum du inte känner till du ställer dig upp och kollar runt i rummet.");
            Console.WriteLine("När du kollar dig runt så ser du en säng, dörr och ett fönster, en hylla, en bänk och en stor matta på golvet.");
            Console.WriteLine("vad vill du göra nu?");
            Console.WriteLine("1) kolla under sängen");
            Console.WriteLine("2) öppna dörren");
            Console.WriteLine("3) kika ut ur fönstret");
            Console.WriteLine("4) gå till bänken.");
            Console.WriteLine("5) kolla under mattan");



            while (true)
            {

                string val = Console.ReadLine();

                if (val == "1")
                {
                    Console.WriteLine("Du kollar under sängen");
                    Console.WriteLine("Du hittar en IKEA blå haj");
                }
                else if (val == "2" && haveDoorkey == false)
                {
                    Console.WriteLine("Du har inte en nyckel");
                }
                else if (val == "2" && haveDoorkey == true)
                {
                    Console.WriteLine("Du öppnar dörren och går ut");

                }
                else if (val == "3")
                {
                    Console.WriteLine("Du ser bara skog så långt du kan se");
                }
                else if (val == "4")
                {

                    Console.WriteLine("När du kommer fram till bänken ser du att det finns en låst låda");
                    Console.WriteLine("ja/nej) vill du öppna lådan");

                }
                else if (val == "5")
                {
                    Console.WriteLine("Du kollar under mattan och hittar en nyckel");
                    haveDeskkey = true;
                }

                if (val == "ja" && haveDeskkey == true || val == "Ja" && haveDeskkey == true)
                {
                    Console.WriteLine("du öppnar lådan och hittar en nyckel");
                    haveDoorkey = true;
                }
                else if (val == "ja" && haveDeskkey == false || val == "Ja" && haveDeskkey == false)
                {
                    Console.WriteLine("Du har inte nyckeln till lådan");
                }

                if (val == "nej" || val == "Nej")
                {
                    Console.WriteLine("Du går och kollar andra ställen istället");
                }
            }

        }


    }
    
}
