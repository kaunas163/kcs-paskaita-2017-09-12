using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kcs_paskaita_2017_09_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var telefonas = new Telefonas("Nokia", 2000, "3310", 0);
            telefonas.Isvedimas();
            telefonas.AtnaujintiKamera();

            Console.WriteLine(telefonas.Kamera);*/
            //telefonas.Kamera = 5; // neveikia nes private set

            var parduotuve = new Parduotuve("Maxima", "Savanoriai");
            parduotuve.Isvedimas();

            var seniausias = parduotuve.SeniausiasTelefonas();
            Console.WriteLine("Seniausias telefonas");
            seniausias.Isvedimas();

            Console.WriteLine("Naujausias telefonas");
            parduotuve.NaujausiasTelefonas().Isvedimas(); // telefonas.Isvedimas()

            Console.WriteLine("Telefonu amziu vidurkis");
            Console.WriteLine(parduotuve.TelefonuAmziausVidurkis());

            var geriausia_kamera = parduotuve.GeriausiaKamera();
            Console.WriteLine("Telefonas su geriausia kamera");
            geriausia_kamera.Isvedimas();
        }
    }
}
