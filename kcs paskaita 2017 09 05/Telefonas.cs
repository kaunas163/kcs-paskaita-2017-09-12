using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kcs_paskaita_2017_09_05
{
    class Telefonas
    {
        //public string pavadinimas; // attribute
        //public string pa { get; private set; } // property

        public string Gamintojas { get; private set; }
        public int Metai { get; private set; }
        public string Modelis { get; private set; }
        public double Kamera { get; private set; } // mp

        public Telefonas()
        {
            
        }
        
        // pasirašom pilną konstruktorių
        public Telefonas(string gamintojas, int metai, string modelis, double kamera)
        {
            Gamintojas = gamintojas;
            Metai = metai;
            Modelis = modelis;
            Kamera = kamera;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Telefonas: {0} {1} isleistas {2} metais, turi {3} mp kamera", Gamintojas, Modelis, Metai, Kamera);
            Console.WriteLine();
        }

        public void AtnaujintiKamera()
        {
            Console.WriteLine("Dabartine kamera {0} mp", Kamera);
            Console.WriteLine("Nauja reiksme?");
            Kamera = Convert.ToInt32(Console.ReadLine());
        }
    }
}
