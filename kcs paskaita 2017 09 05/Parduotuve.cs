using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kcs_paskaita_2017_09_05
{
    class Parduotuve
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Telefonas> Telefonai { get; private set; }

        public Parduotuve()
        {
            
        }

        public Parduotuve(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Telefonai = new List<Telefonas>(); // kad nenulūžtų pridedant telefoną
            GeneruotiTelefonus();
        }

        public Parduotuve(string pavadinimas, string adresas, List<Telefonas> telefonai)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Telefonai = telefonai;
        }

        public void GeneruotiTelefonus()
        {
            Console.WriteLine("Kiek telefonų parduotuvė turi?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            string[] gamintojai = { "Nokia", "Google Nexus", "Apple", "Samsung" };
            string[] modeliai = { "modelis1", "modelis2", "modelis3", "modelis4", "modelis5", "modelis6" };

            Random atsitiktinis = new Random();

            // galima būtų daryti atskirus masyvus atskiriems gamintojams

            // tada koks gamintojas būtų parinktas iš to modelių
            // masyvo ir imtų modelius, o ne kaip dabar iš bendro
            
            for (int i = 0; i < kiek; i++)
            {
                var gamintojas = gamintojai[atsitiktinis.Next(gamintojai.Length)];
                var modelis = modeliai[atsitiktinis.Next(modeliai.Length)];
                var metai = atsitiktinis.Next(2000, 2018);
                var kamera = atsitiktinis.Next(0, 12);

                // generuojant modelį būtų galima su switch tikrinti gautą
                // gamintoją ir taip imti iš atitinkamo modelių masyvo modelį

                // dar variantas: naudoti jagged/multidimensional array

                var telefonas = new Telefonas(gamintojas, metai, modelis, kamera);

                Telefonai.Add(telefonas);
            }
        }

        /* pasirašyti šiuos metodus:
         * išvedimas (išveda pačios parduotuvės duomenis ir visus turimus telefonus
         * randa seniausią telefoną
         * randa naujausią telefoną
         * randa vidutinį telefonų amžių
         * randa geriausios kameros telefoną ir grąžina visus duomenis apie šį telefoną
         */

        public void Isvedimas()
        {
            Console.WriteLine("Parduotuvė {0} randasi adresu: {1}", Pavadinimas, Adresas);
            Console.WriteLine();
            Console.WriteLine("Joje galima rasti šiuos telefonus:");
            Console.WriteLine();

            foreach (var telefonas in Telefonai)
            {
                telefonas.Isvedimas();
            }

            Console.WriteLine();
        }

        public Telefonas SeniausiasTelefonas()
        {
            var seniausias = Telefonai[0];

            foreach (var telefonas in Telefonai)
            {
                if (telefonas.Metai < seniausias.Metai)
                {
                    seniausias = telefonas;
                }
            }

            return seniausias;
        }

        public Telefonas NaujausiasTelefonas()
        {
            var naujausias = Telefonai[0];

            foreach (var telefonas in Telefonai)
            {
                if (telefonas.Metai > naujausias.Metai)
                {
                    naujausias = telefonas;
                }
            }

            return naujausias;
        }

        /*
         1. laikinas kintamasis sumai saugoti, lygus 0
         2. einam per sąrašą
         2.1. kiekvieno telefono metus pridėti prie sumos
         3. sumą dalinam iš visų telefonų kiekio, taip gaunam vidurkį
         4. grąžinam vidurkį
         */

        public double TelefonuAmziausVidurkis()
        {
            var suma = 0;

            foreach (var telefonas in Telefonai)
            {
                suma += telefonas.Metai;
            }

            return (double) suma / Telefonai.Count;
        }

        public Telefonas GeriausiaKamera()
        {
            var geriausias = Telefonai[0];

            foreach (var telefonas in Telefonai)
            {
                if (telefonas.Kamera > geriausias.Kamera)
                {
                    geriausias = telefonas;
                }
            }

            return geriausias;
        }
    }
}
