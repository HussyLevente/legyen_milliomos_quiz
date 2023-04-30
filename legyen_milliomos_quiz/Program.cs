using System.Text;
using System.IO;

namespace legyen_milliomos_quiz
{
    internal class Program
    {
        static List<Kerdesek> Kerdesek_List = new List<Kerdesek>();
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Felt();
            Prgrm();
        }

        private static void Prgrm()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("14: 40'000'000\n13: 20'000'000\n12: 10'000'000\n11: 5'000'000\n10: 3'000'000\n9:  1'500'000\n8:  800'000\n7:  300'000\n6:  200'000\n5:  100'000\n4:  50'000\n3:  25'000\n2:  10'000\n1:  5'000");
            Console.WriteLine("-------------------------------------------------------");
            int Rnd_Szam = rnd.Next(Kerdesek_List.Count);
            int index = 1;
            int Megoldas_Szam = 0;
            int Kznsg_valasz;
            int Tlfn_valasz;
            foreach (var k in Kerdesek_List)
            {
                Console.WriteLine($"\n{index}. {k.Kerdes}");
                Console.WriteLine($"\n{k.A}   {k.B}   {k.C}   {k.D}");
                Console.WriteLine("\nFelhasználható lehetőségek válaszok: A, B, C, D, Segítségek: T/telefonos, K/közönség");
                Console.Write("\nKérem adja meg a választ vagy kérjen segítséget: ");
                string Felh_valasz = Console.ReadLine();

                //Közönség segítsége
                if (Felh_valasz == "k".ToLower())
                {
                    Kznsg_valasz = rnd.Next(0, 2);
                    Console.WriteLine("A felhasználó a Közönség segítségét kérte.");
                    if (Kznsg_valasz == 0)
                    {
                        Console.WriteLine("A közönség rossz választ adott, így a felhasználó nem kap pontot.");
                    }
                    if (Kznsg_valasz == 1)
                    {
                        Console.WriteLine("A közönség jó választ adott, így a felhasználó szerzett egy pontot.");
                        Megoldas_Szam++;
                    }
                }

                //Telefonos segítség
                if (Felh_valasz == "t".ToLower())
                {
                    Tlfn_valasz=rnd.Next(0, 2);
                    Console.WriteLine("A felhasználó telefonos segítséget kért.");
                    if (Tlfn_valasz == 0)
                    {
                        Console.WriteLine("A telefonos segítség nem érte el a hatását, ennek értelmében a felhasználó nem kap pontot.");
                        Console.WriteLine("Vége a játéknak!");
                        break;
                    }
                    if (Tlfn_valasz == 1)
                    {
                        Console.WriteLine("A telefonos segítséggel a felhasználó szerzett egy pontot.");
                        Megoldas_Szam++;
                    }
                }

                //Ha a felhasználó nem kér segístéget, de helyes a megoldása
                if (Felh_valasz.ToUpper() == k.Valasz)
                {
                    Megoldas_Szam++;
                }
                index++;
                Console.WriteLine("\n-------------------------------------------------\n");

                if (Felh_valasz.ToUpper() != k.Valasz && Felh_valasz.ToUpper() != "t".ToUpper() && Felh_valasz.ToUpper() != "k".ToUpper())
                {
                    Console.WriteLine("Vége a játéknak!");
                    break;
                }

            }

            //Játék végén kiírandó
            Console.WriteLine($"Helyes megoldások száma: {Megoldas_Szam}");
            if (Megoldas_Szam == 0)
            {
                Console.WriteLine("Nem nyertél semmit :(");
            }
            if (Megoldas_Szam == 1)
            {
                Console.WriteLine("Nyereményed: 5'000Ft");
            }
            if (Megoldas_Szam == 2)
            {
                Console.WriteLine("Nyereményed: 10'000Ft");
            }
            if (Megoldas_Szam == 3)
            {
                Console.WriteLine("Nyereményed: 25'000Ft");
            }
            if (Megoldas_Szam == 4)
            {
                Console.WriteLine("Nyereményed: 50'000Ft");
            }
            if (Megoldas_Szam == 5)
            {
                Console.WriteLine("Nyereményed: 100'000Ft");
            }
            if (Megoldas_Szam == 6)
            {
                Console.WriteLine("Nyereményed: 200'000Ft");
            }
            if (Megoldas_Szam == 7)
            {
                Console.WriteLine("Nyereményed: 300'000Ft");
            }
            if (Megoldas_Szam == 8)
            {
                Console.WriteLine("Nyereményed: 800'000Ft");
            }
            if (Megoldas_Szam == 9)
            {
                Console.WriteLine("Nyereményed: 1'500'000Ft");
            }
            if (Megoldas_Szam == 10)
            {
                Console.WriteLine("Nyereményed: 3'000'000Ft");
            }
            if (Megoldas_Szam == 11)
            {
                Console.WriteLine("Nyereményed: 5'000'000Ft");
            }
            if (Megoldas_Szam == 12)
            {
                Console.WriteLine("Nyereményed: 10'000'000Ft");
            }
            if (Megoldas_Szam == 13)
            {
                Console.WriteLine("Nyereményed: 20'000'000Ft");
            }
            if (Megoldas_Szam == 14)
            {
                Console.WriteLine("Nyereményed: 40'000'000Ft");
            }
        }

        private static void Felt()
        {
            var sr = new StreamReader(@"legyenmilliomos.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                Kerdesek_List.Add(new Kerdesek(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}