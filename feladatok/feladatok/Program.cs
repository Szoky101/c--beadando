using System;

namespace feladatok
{
    static class Feladatsor
    {
        private static bool IsPrim(long num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        private static double ReadNumberFromConsole(string message)
        {
            while (true)
            {
                Console.Write(message);
                var input = Console.ReadLine();
                try
                {
                    return double.Parse(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Nem sikerült átalakitani a számot");
                }

            }
        }
      
        internal static void F1()
        {
            Console.WriteLine("Hello World");
        }
   
        internal static void F2()
        {
            Console.WriteLine("Ird be a neved ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}!");
        }
        
        internal static void F3()
        {
            double szam = ReadNumberFromConsole("Adj meg egy számot ");
            double ketszeres = szam * 2;
            Console.WriteLine($"A szám kétszerese {ketszeres}");
        }

        internal static void F4()
        {
            double szam1 = ReadNumberFromConsole("Add meg az egyik számot ");
            double szam2 = ReadNumberFromConsole("Add meg a másik számot ");

            Console.WriteLine($"A számok összege: {szam1 + szam2}");
            Console.WriteLine($"A számok különbsége: {szam1 - szam2}");
            Console.WriteLine($"A számok szorzata: {szam1 * szam2}");
            Console.WriteLine($"A számok hányadosa: {Math.Round(szam1 / szam2, 2)}");
        }

        internal static void F5()
        {
            double szam1 = ReadNumberFromConsole("Add meg az egyik számot ");
            double szam2 = ReadNumberFromConsole("Add meg a másik számot ");

            if (szam1 > szam2)
            {
                Console.WriteLine($"A nagyobbik szám: {szam1}");
            }
            else
            {
                Console.WriteLine($"A nagyobbik szám: {szam2}");
            }
        }

        internal static void F6()
        {
            double szam1 = ReadNumberFromConsole("Add meg az egyik számot ");
            double szam2 = ReadNumberFromConsole("Add meg a másik számot ");
            double szam3 = ReadNumberFromConsole("Adj meg egy harmadik számot ");

            if (szam1 < szam2)
            {
                if (szam1 < szam3)
                {
                    Console.WriteLine($"{szam1} a legkisebb szam");
                }
                else
                {
                    Console.WriteLine($"{szam3} a legkisebb szam");
                }
            }
            else if (szam2 < szam3)
            {
                Console.WriteLine($"{szam2} a legkisebb szam");
            }
            else
            {
                Console.WriteLine($"{szam3} a legkisebb szam");
            }
        }

        internal static void F7()
        {
            double szam1 = ReadNumberFromConsole("Add meg az egyik számot ");
            double szam2 = ReadNumberFromConsole("Add meg a másik számot ");
            double szam3 = ReadNumberFromConsole("Adj meg egy harmadik számot ");

            if (szam1 < (szam2 + szam3) && szam2 < (szam1 + szam3) && szam3 < (szam2 + szam1))
            {
                Console.WriteLine("A háromszög szerkeszthető");
            }
            else
            {
                Console.WriteLine("A háromszög nem szerkeszthető");
            }
        }

        internal static void F8()
        {
            double szam1 = ReadNumberFromConsole("Add meg az egyik számot: ");
            double szam2 = ReadNumberFromConsole("Add meg a másik számot: ");

            double mertani_kozep = Math.Sqrt(szam1 * szam2);
            double atlag = (szam1 + szam2) / 2;
            Console.WriteLine($"A szám mértani közepe: {Math.Round(mertani_kozep, 2)}");
            Console.WriteLine($"A szám átlaga: {Math.Round(atlag, 2)}");
        }

        internal static void F9()
        {
            double szam1 = ReadNumberFromConsole("Add meg az egyik együtthatot: ");
            double szam2 = ReadNumberFromConsole("Add meg a másik együtthatot: ");
            double szam3 = ReadNumberFromConsole("Add meg a harmadik együtthatot: ");

            double diszkriminans = (szam2 * szam2) + (-4 * szam1 * szam3);
            if (diszkriminans < 0)
            {
                Console.WriteLine($"Az egyenletnek nincs megoldása mert a D: {diszkriminans}");
            }
            else if (diszkriminans == 0)
            {
                Console.WriteLine($"Az egyenletnek 1 megoldása van mert az értéke 0");
            }
            else
            {
                Console.WriteLine($"Az egyenlet megoldható mert a D: {diszkriminans}");
            }
        }

        internal static void F10()
        {
            double szam1 = ReadNumberFromConsole("Add meg az egyik együtthatot: ");
            double szam2 = ReadNumberFromConsole("Add meg a másik együtthatot: ");
            double szam3 = ReadNumberFromConsole("Add meg a harmadik együtthatot: ");

            double diszkriminans = (szam2 * szam2) + (-4 * szam1 * szam3);
            double disz = Math.Round(Math.Sqrt(diszkriminans));
            Console.WriteLine(disz);
            double egyenlet1 = (-szam2 + disz) / (2 * szam1);
            double egyenlet2 = (-szam2 - disz) / (2 * szam1);

            if (diszkriminans < 0)
            {
                Console.WriteLine($"Az egyenletnek nincs megoldása mert a D: {diszkriminans}");
            }
            else
            {
                Console.WriteLine($"Az egyenlet egyik gyöke {egyenlet1}");
                Console.WriteLine($"Az egyenlet másik gyöke {egyenlet2}");
            }
        }

        internal static void F11()
        {
            double szam1 = ReadNumberFromConsole("Add meg az egyik befogot: ");
            double szam2 = ReadNumberFromConsole("Add meg a másik befogot: ");

            double atfogo = Math.Sqrt((szam1 * szam1) + (szam2 * szam2));

            Console.WriteLine($"Az átfogo ennek a háromszögnek {Math.Round(atfogo, 2)}");
        }

        internal static void F12()
        {
            double szam1 = ReadNumberFromConsole("Add meg az egyik élt: ");
            double szam2 = ReadNumberFromConsole("Add meg a másik élt: ");
            double szam3 = ReadNumberFromConsole("Add meg a harmadik élt: ");

            double felszin = 2 * ((szam1 * szam2) + (szam1 * szam3) + (szam2 * szam3));
            double terfogat = szam1 * szam2 * szam3;

            Console.WriteLine($"A téglatest felszine: {felszin}");
            Console.WriteLine($"A téglatest térfogata: {terfogat}");
        }

        internal static void F13()
        {
            double szam1 = ReadNumberFromConsole("Add meg a kör átméröjét: ");
            double sugar = szam1 / 2;
            double kor_t = Math.Round((sugar * sugar) * Math.PI, 2);
            double kor_k = Math.Round(2 * sugar * Math.PI, 2);

            Console.WriteLine($"A kör területe: {kor_t}");
            Console.WriteLine($"A kör kerülete: {kor_k}");
        }

        internal static void F14()
        {
            var degree = ReadNumberFromConsole("Adj meg egy fokot: ");
            var r = ReadNumberFromConsole("Adj meg egy köriv sugarát: ");
            Console.WriteLine("A köriv kerülete:" + (degree * r * 2 * Math.PI / 360));
            Console.WriteLine("A köriv területe:" + (degree * r * r * Math.PI / 360));
        }

        internal static void F15()
        {
            double szam = ReadNumberFromConsole("Add meg egy számot: ");
            double i = 0;
            while (szam > i)
            {
                Console.Write($"{i} ");
                i++;
            }

        }

        internal static void F16()
        {
            double szam = ReadNumberFromConsole("Add meg egy számot: ");
            double i = 0;
            while (szam > i)
            {
                Console.WriteLine($"{i}");
                i++;
            }
        }

        internal static void F17()
        {
            double szam = ReadNumberFromConsole("Add meg egy számot: ");
            double i = 1;
            while (szam > i)
            {
                if (szam % i == 0)
                {
                    Console.WriteLine(i);
                }

                i++;
            }
        }

        internal static void F18()
        {
            double szam = ReadNumberFromConsole("Add meg egy számot: ");
            double osszeg = 0;
            double i = 1;
            while (szam >= i)
            {
                if (szam % i == 0)
                {
                    osszeg = osszeg + i;
                }
                i++;
            }
            Console.WriteLine($"A {szam} osztoinak összege: {osszeg}");
        }

        internal static void F19()
        {
            double szam = ReadNumberFromConsole("Add meg egy számot: ");
            double osszeg = 0;
            double i = 1;
            Console.Write("Osztok: ");
            while (szam >= i)
            {
                if (szam % i == 0)
                {
                    Console.Write(i + " ");
                    osszeg = osszeg + i;
                }
                i++;
            }

            if ((szam * 2) == osszeg)
            {
                Console.WriteLine("\nEz a szám tökéletes");
            }
            else
            {
                Console.WriteLine("\nEz a szám nem tökéletes");
            }

        }

        internal static void F20F21()
        {
            double szam1 = ReadNumberFromConsole("Add meg a hatványt: ");
            double szam2 = ReadNumberFromConsole("Add meg a kitevöt: ");

            double indulo_eredmeny = (szam1 * szam1);

            if ((szam1 < 0) || (szam2 < 0))
            {
                Console.WriteLine($"Nem lehet mert az egyik szám negativ");
            }
            else
            {
                double i = 1;
                while (szam2 - 1 > i)
                {
                    indulo_eredmeny = indulo_eredmeny * szam1;
                    i++;
                }
                Console.WriteLine(indulo_eredmeny);
            }
        }


        internal static void F22()
        {
            double sum = 0;
            double num = 0;
            while (num < 10)
            {
                num = ReadNumberFromConsole("Adj meg egy számot ");
                sum = num + sum;
            }
            Console.WriteLine("Az eddig megadott számok összege: " + sum);
        }

        internal static void F23()
        {
            double szam = ReadNumberFromConsole("Adj meg egy számot ");

            double eredetiSzam = szam;
            string kk = " ";
            double i = 0;
            while (szam > i)
            {
                if (szam % 2 == 0)
                {
                    kk = kk + "2*";
                    szam = szam / 2;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine($"{eredetiSzam} = {kk}{szam}");
        }

        internal static void F24()
        {
            Console.WriteLine("irj be egy szöveget");
            string eredmeny = Console.ReadLine();
            while (eredmeny != "alma")
            {
                Console.WriteLine("irj be egy szöveget");
                eredmeny = Console.ReadLine();
            }
        }

        internal static void F25()
        {
            double igen = 0;
            double szam = ReadNumberFromConsole("Adj meg egy számot ");
            while (szam >= 3)
            {
                szam = szam - 3;
                igen += 1;

            }
            Console.WriteLine($"{igen} * 3 + {szam}");
        }

        internal static void F26()
        {
            var szam = ReadNumberFromConsole("Adj meg egy számot: ");
            double oszto = 1;
            double osztok_szama = 0;
            while (szam >= oszto)
            {
                if (szam % oszto == 0)
                {
                    osztok_szama++;
                }
                oszto++;
            }

            if (osztok_szama == 2)
            {
                Console.WriteLine("Ez a szám primszám");
            }
            else
            {
                Console.WriteLine("Nem primszám");
            }
        }
        /// <summary>
        /// Egyszerüen nem tudtam megoldani hogy irja ki a primszámokat csak a szám osztoit
        /// </summary>
        internal static void F27()
        {
            var szam = ReadNumberFromConsole("Adj meg egy számot: ");
            double i = 2;
            double j = 2;
            String osztok_szama = "";
            while (szam >= i)
            {
                if (szam % i == 0)
                {
                    if(i % j == 0)
                    {
                        osztok_szama = osztok_szama + i + " ";
                    }

                }
                i++;
                j++;
            }
            Console.WriteLine(osztok_szama);
        }
        /// <summary>
        /// prim oszto ugyanugy megakadtam és nincs ötletem
        /// </summary>
        internal static void F28()
        {
            var szam = ReadNumberFromConsole("Adj meg egy számot: ");
            double i = 2;
            double j = 2;
            String osztok_szama = "";
            while (szam >= i)
            {
                if (szam % i == 0)
                {
                    if (i % j == 0)
                    {
                        osztok_szama = osztok_szama + i + " ";
                        
                        szam = szam - i;
                    }

                }
                i++;
                j++;
            }
            Console.WriteLine(szam);
        }
        /// <summary>
        /// ugy az elozoekhez hasonloan nincs ötletem mert egymásra épül
        /// </summary>
        internal static void F29()
        {

        }

        internal static void F30()
        {
            var egy = ReadNumberFromConsole("Adj meg egy számot: ");
            var ketto = ReadNumberFromConsole("Adj meg egy számot: ");

            while (egy != ketto)
            {
                if (egy > ketto)
                {
                    egy = egy - ketto;
                }
                else
                {
                    ketto = ketto - egy;
                }
            }

            Console.WriteLine(egy);

        }
        internal static void F31()
        {
            double egy = ReadNumberFromConsole("Adj meg egy számot: ");
            double ketto = ReadNumberFromConsole("Adj meg egy számot: ");
            double a = egy;
            double b = ketto;
            while (b != 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            double legkisebb = a;
            double legkisebbszam = (egy * ketto) / legkisebb;
            Console.WriteLine("Legkisebb közös töbszörös: " +  legkisebbszam);

        }
        internal static void F32()
        {
            var szam = ReadNumberFromConsole("Adj meg egy számot: ");
            double i = 1;
            while (i <= 10)
            {
                double eredmeny = i * szam;
                Console.WriteLine(eredmeny);
                i++;

            }

        }

        internal static void F33()
        {
            var szam = ReadNumberFromConsole("Adj meg egy számot: ");
            for (int i = 0; i <= szam; i++)
            {
                for (int j = 0; j <= szam; j++)
                {
                    if (j + i == szam)
                    {
                        Console.WriteLine($"{i} + {j} = {szam}");
                    }
                }
            }
        }
        /// <summary>
        /// Kifogytam az ötletből nem tudom hogy kene megoldani
        /// </summary>
        internal static void F34()
        {
            int i = 10;
            int j = 10;
            while((i < 100) && (j < 100))
            {
                int i_elso = (i / 10);
                int i_masodik = (i % 10);
                int j_elso = (j / 10);
                int j_masodik = (j % 10);

                String s_i = i_elso.ToString();
                String s_i2 = i_masodik.ToString();
                String s_j = j_elso.ToString();
                String s_j2 = j_masodik.ToString();
                int i_v = int.Parse(s_i + s_i2);
                int i_j = int.Parse(s_j + s_j2);

                while(i * j == i_v * i_j)
                {

                }

            }

        }
        /// <summary>
        /// ascii kod vagy mi es ezt hogy
        /// </summary>
        internal static void F35()
        {

        }

        internal static void F36()
        {
            char betu = 'x';
            char betu2 = 'o';

            for (int j = 1; j <= 3; j++)
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.Write($"{betu}");
                    Console.Write($"{betu2}");
                }
                Console.WriteLine();
                for (int i = 1; i <= 3; i++)
                {
                    Console.Write($"{betu2}");
                    Console.Write($"{betu}");
                }
                Console.WriteLine();
            }

        }

        internal static void F37()
        {
            var szam = ReadNumberFromConsole("Adj meg egy számot: ");
            var szam2 = 0;
            char star = '*';

            for(int i = 1; i <= szam; i++)
            {

                for(int j = 0; j <= szam2; j++)
                {
                    Console.Write(star);
                    
                }
                Console.WriteLine();
                szam2 += 2;
            }
        }


        internal static void F38()
        {
            var szam = ReadNumberFromConsole("Adj meg egy számot: ");
            for (int i = 1; i <= szam; i++)
            {
                for (int j = 1; j <= szam - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// megprobaltam de nincs ötlet
        /// </summary>
        internal static void F39()
        {
            var magassag = ReadNumberFromConsole("Adj meg egy a magassagot: ");
            var szeles = ReadNumberFromConsole("Adj meg egy szelesseget: ");

            for (int i = 1; i <= magassag; i++)
            {
                for(int j = 1; j <= magassag; j++)
                {
                    Console.Write('*');

                }

                for (int j = 1; j <= szeles; j++)
                {
                    Console.Write("");
                }
                Console.WriteLine();
            }

        }
        internal static void F40()
        {
            double szam = ReadNumberFromConsole("Adj meg egy számot: ");
            int i = 1;
            double osszeg = 0;
            while (szam > i)
            {
                while (szam % i == 0)
                {
                    osszeg = osszeg + i;
                    i++;
                }
                i++;
            }
            if (szam == osszeg)
            {
                Console.WriteLine($"A szám tökéletes szám mert az eredmény {osszeg}");
            }
            else
            {
                Console.WriteLine($"A szám nem tökéletes szám mert az eredmeny {osszeg}");
            }
        }
        /// <summary>
        /// Nem nagyon tudtam elkezdeni sem
        /// </summary>
        internal static void F41()
        {

        }



        static void Main(string[] args)
        {
            Feladatsor.F31();
        }
    }
}