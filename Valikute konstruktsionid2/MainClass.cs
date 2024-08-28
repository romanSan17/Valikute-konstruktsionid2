using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valikute_konstruktsionid2
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] nimed = new string[5] { "Anna", "Inna", "Oksana", "Pavel", "Karl" };
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine(nimed[i]);
            }
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }
            //3.V
            int n = 0;
            while (n < nimed.Length)
            {
                Console.WriteLine();
                n++;
            }
            //4.V
            do
            {
                Console.WriteLine(nimed[n-1]);
                n--;
            } while (n < 0);
        }
    }
}
