using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv04
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringtestovaciText = "Toto je retezec predstavovany nekolika radky,\n"
                +"ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                + "posledni veta!";

            string stringtestovaciTextInficated = "Toto je retezec predstavovany nekolika radky,\n"
                + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                + "koronavirus posledni veta!";

            StringStatistics a = new StringStatistics(stringtestovaciText);
            StringStatistics b = new StringStatistics(stringtestovaciTextInficated);

            test(a);
            Console.WriteLine("------------------------------------------------");
            test(b);
            Console.ReadLine();
        }

        public static void test(StringStatistics a) {

            Console.WriteLine("Pocet slov: {0}", a.SumWord);
            Console.WriteLine("Pocet radku: {0}", a.SumRows);
            Console.WriteLine("Pocet vet: {0}", a.SumSentence);
            Console.WriteLine("Nejdelší slova: {0}", a.LongestWord);
            Console.WriteLine("Nejkratsi slova: {0}", a.ShortestWord);
            Console.WriteLine("Slova podle abecedy: {0}", a.AlfabetWord);
            if (a.Inficeted)
            {
                Console.WriteLine("POZOR VETA JE INFIKOVANA!!!!!!!!");
            }
            
        }
    }
}
