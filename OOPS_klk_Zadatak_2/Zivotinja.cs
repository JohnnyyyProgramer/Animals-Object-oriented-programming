using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_klk_Zadatak_2
{
    internal abstract class Zivotinja : IComparable<Zivotinja>
    {
        public string Naziv { get; set; }
        public string boja { get; set; }
        public double tezina { get; set; }

        public int CompareTo(Zivotinja other)
        {
            return tezina.CompareTo(other.tezina);
        }

        public override string ToString()
        {
            return $"Naziv : {Naziv} tezina: {tezina} ";
        }

        public virtual void IspustiZvuk()
        {
            Console.WriteLine("Nepoznati zvuk");
            
        }
    }

}
