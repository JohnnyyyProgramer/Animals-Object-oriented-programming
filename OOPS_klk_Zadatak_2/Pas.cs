using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_klk_Zadatak_2
{
    internal class Pas : Zivotinja
    {
        public Rasa RasaPsa { get; set; }

        public override void IspustiZvuk()
        {
            Console.WriteLine("Av-AV");
        }
    }
}
