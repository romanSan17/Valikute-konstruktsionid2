using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valikute_konstruktsionid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] nimed = new string[5] { "Anna", "Inna", "Oksana", "Pavel", "Karl" };
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine(nimed[i]);
            }




            for (int i = 0; i < 7; i++)
            {
                Random random = new Random();
                int paev_nr = random.Next(-4, 30);
                string paeva_nimetus = Funktsioonid.Paevad(paev_nr);
                Console.WriteLine(paeva_nimetus);
            }



            try
            {
                Console.WriteLine("Mis on sinu pikkus?");
                double pikkus = Double.Parse(Console.ReadLine());
                string vastus = Funktsioonid.Pikkuse_analuus(pikkus);
                Console.WriteLine("Sinu pikkus on {0}, sa oled {1}", pikkus, vastus);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.Write("1 mis on sinu nimi? ");
            string a = (Console.ReadLine());
            Console.Write("2 mis on sinu nimi? ");
            string b = (Console.ReadLine());
            Console.WriteLine("te olete minu naabrid", a, "ja", b);

            int c = int.Parse(Console.ReadLine());
            Console.Write("kui pikk oled sa? ");
            if (vastus < 160)
            {
                Console.WriteLine("sa oled lühike");
            }
            if ()
            {
                Console.WriteLine("sa oled lühike");

            }
        }
}