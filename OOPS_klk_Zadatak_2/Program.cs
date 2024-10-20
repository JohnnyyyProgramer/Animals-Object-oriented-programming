using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_klk_Zadatak_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Zivotinja> zivotinje = new List<Zivotinja>();
            Zivotinja Pas1 = new Pas()
            {
                Naziv = "Dzeki",
                boja = "Crna",
                tezina = 20.45,
                RasaPsa = Rasa.Labrador
            };
            Zivotinja Ptica = new Ptica()
            {
                Naziv = "kiki",
                boja = "zuta",
                tezina= 1,
                MozeDaLeti = true
            };

            Zivotinja Ptica2 = new Ptica()
            {

                Naziv = "Mile",
                boja = "Crna i bela",
                tezina = 3,
                MozeDaLeti = false
            };
            zivotinje.Add(Pas1);
            zivotinje.Add(Ptica2);
            zivotinje.Add(Ptica);
            zivotinje.Sort();
            foreach (Zivotinja zivotinja in zivotinje)
            {
                Console.WriteLine(zivotinja);
            }
        }
        

    }
}
