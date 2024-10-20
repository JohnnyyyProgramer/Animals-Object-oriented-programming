using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_klk_Zadatak_2
{
    internal class Ptica: Zivotinja
    {
        public bool MozeDaLeti { get; set; }

        public override void IspustiZvuk()
        {
            Console.WriteLine("Piju-piju");
        }
    }
}
