using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valikute_konstruktsionid2
{
    public class Funktsioonid
    {
        //public static string Pikkuse_analuus(double, pikkus)
        //{
        //    string analuus;
        //    if (pikkus < 1.6)
        //    {
        //        analuus = "Lühika kasvu inimine";
        //    }
        //    else if (pikkus < 1.8)
        //    {
        //        analuus = "keskmine kasvu inimine";
        //    }
        //    else
        //    {
        //        analuus = "Lühika kasvu inimine";
        //    }
        //    return analuus;
        //}

        public static string Paevad(int nr)
        {
            string paev;
            switch (nr)
            {
                case 1: paev = "esmaspäev"; break;
                case 2: paev = "Teisipäev"; break;
                case 3: paev = "Kolmapäev"; break;
                case 4: paev = "Neljapäev"; break;
                case 5: paev = "Reede"; break;
                case 6: paev = "Laupäev"; break;
                case 7: paev = "Pühapäev"; break;
                default:
                    paev = "Ei saa määrata";
                    break;
            }
        }
    }
}