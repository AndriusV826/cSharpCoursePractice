using System;


class Program
{
    static void Main()
    {
        findMagicNumber();
        //printMineSweeperNumbers();
    }

    private static void findMagicNumber()
    {
        int skaicius1 = 100000;
        for (int q = skaicius1; q < 999999; q++)
        {

            string laikinas = skaicius1.ToString();
            int[] skaicius = new int[laikinas.ToString().Length];
            for (int i = 0; i < skaicius.Length; i++)
            {
                skaicius[i] = Convert.ToInt32(laikinas[i]);
            }
            int[] kopija = skaicius;
            bool b = false;
            bool c0 = false;
            bool c1 = false;
            bool c2 = false;
            bool c3 = false;
            bool c4 = false;
            ar_skirtingi(kopija, ref b);
            ar_vienodi_skaiciai_x2(kopija, ref c0, skaicius1);
            ar_vienodi_skaiciai_x3(kopija, ref c1, skaicius1);
            ar_vienodi_skaiciai_x4(kopija, ref c2, skaicius1);
            ar_vienodi_skaiciai_x5(kopija, ref c3, skaicius1);
            ar_vienodi_skaiciai_x6(kopija, ref c4, skaicius1);

            if ((b == true) && (c0 == true) && (c1 == true) && (c2 == true) && (c3 == true) && (c4 == true))
            {
                Console.WriteLine("Magiskasis skaicius yra " + skaicius1);
                Console.ReadKey();
                skaicius1++;
            }
            else
            {
                skaicius1++;
            }
        }
        Console.ReadKey();

    }

    static bool ar_skirtingi(int[] a, ref bool b)
    {
        if (a[0] != a[1] && a[0] != a[2] && a[0] != a[3] && a[0] != a[4] && a[0] != a[5] && a[1] != a[2] && a[1] != a[3] && a[1] != a[4] && a[1] != a[5] && a[2] != a[3] && a[2] != a[4] && a[2] != a[5] && a[3] != a[4] && a[3] != a[5] && a[4] != a[5])
        {
            b = true;
            return b;
        }
        else
        {
            b = false;
            return b;
        }
    }

    static bool ar_vienodi_skaiciai_x2(int[] a1, ref bool c0, int skaicius1)
    {
        int a1_int = skaicius1;
        int a2_int = a1_int * 2;
        string holder = a2_int.ToString();
        int[] a2 = new int[holder.ToString().Length];
        for (int i = 0; i < a2.Length; i++)
        {
            a2[i] = Convert.ToInt32(holder[i]);
        }
        if ((a1[0] == a2[0])|| (a1[0] == a2[1]) || (a1[0] == a2[2]) || (a1[0] == a2[3]) || (a1[0] == a2[4]) || (a1[0] == a2[5]) && (a1[1] == a2[0]) || (a1[1] == a2[1]) || (a1[1] == a2[2]) || (a1[1] == a2[3]) || (a1[1] == a2[4]) || (a1[1] == a2[5]) && (a1[2] == a2[0]) || (a1[2] == a2[1]) || (a1[2] == a2[2]) || (a1[2] == a2[3]) || (a1[2] == a2[4]) || (a1[2] == a2[5]) && (a1[3] == a2[0]) || (a1[3] == a2[1]) || (a1[3] == a2[2]) || (a1[3] == a2[3]) || (a1[3] == a2[4]) || (a1[3] == a2[5]) && (a1[4] == a2[0]) || (a1[4] == a2[1]) || (a1[4] == a2[2]) || (a1[4] == a2[3]) || (a1[4] == a2[4]) || (a1[4] == a2[5]) && (a1[5] == a2[0]) || (a1[5] == a2[1]) || (a1[5] == a2[2]) || (a1[5] == a2[3]) || (a1[5] == a2[4]) || (a1[5] == a2[5]))
        {
            c0 = true;
            return c0;
        }
        else
        {
            c0 = false;
            return c0;
        }
    }
    static bool ar_vienodi_skaiciai_x3(int[] a1, ref bool c1, int skaicius1)
    {
        int a1_int = skaicius1;
        int a2_int = a1_int * 3;
        string holder = a2_int.ToString();
        int[] a2 = new int[holder.ToString().Length];
        for (int i = 0; i < a2.Length; i++)
        {
            a2[i] = Convert.ToInt32(holder[i]);
        }
        if ((a1[0] == a2[0]) || (a1[0] == a2[1]) || (a1[0] == a2[2]) || (a1[0] == a2[3]) || (a1[0] == a2[4]) || (a1[0] == a2[5]) && (a1[1] == a2[0]) || (a1[1] == a2[1]) || (a1[1] == a2[2]) || (a1[1] == a2[3]) || (a1[1] == a2[4]) || (a1[1] == a2[5]) && (a1[2] == a2[0]) || (a1[2] == a2[1]) || (a1[2] == a2[2]) || (a1[2] == a2[3]) || (a1[2] == a2[4]) || (a1[2] == a2[5]) && (a1[3] == a2[0]) || (a1[3] == a2[1]) || (a1[3] == a2[2]) || (a1[3] == a2[3]) || (a1[3] == a2[4]) || (a1[3] == a2[5]) && (a1[4] == a2[0]) || (a1[4] == a2[1]) || (a1[4] == a2[2]) || (a1[4] == a2[3]) || (a1[4] == a2[4]) || (a1[4] == a2[5]) && (a1[5] == a2[0]) || (a1[5] == a2[1]) || (a1[5] == a2[2]) || (a1[5] == a2[3]) || (a1[5] == a2[4]) || (a1[5] == a2[5]))
        {
            c1 = true;
            return c1;
        }
        else
        {
            c1 = false;
            return c1;
        }
    }
    static bool ar_vienodi_skaiciai_x4(int[] a1, ref bool c2, int skaicius1)
    {
        int a1_int = skaicius1;
        int a2_int = a1_int * 4;
        string holder = a2_int.ToString();
        int[] a2 = new int[holder.ToString().Length];
        for (int i = 0; i < a2.Length; i++)
        {
            a2[i] = Convert.ToInt32(holder[i]);
        }
        if ((a1[0] == a2[0]) || (a1[0] == a2[1]) || (a1[0] == a2[2]) || (a1[0] == a2[3]) || (a1[0] == a2[4]) || (a1[0] == a2[5]) && (a1[1] == a2[0]) || (a1[1] == a2[1]) || (a1[1] == a2[2]) || (a1[1] == a2[3]) || (a1[1] == a2[4]) || (a1[1] == a2[5]) && (a1[2] == a2[0]) || (a1[2] == a2[1]) || (a1[2] == a2[2]) || (a1[2] == a2[3]) || (a1[2] == a2[4]) || (a1[2] == a2[5]) && (a1[3] == a2[0]) || (a1[3] == a2[1]) || (a1[3] == a2[2]) || (a1[3] == a2[3]) || (a1[3] == a2[4]) || (a1[3] == a2[5]) && (a1[4] == a2[0]) || (a1[4] == a2[1]) || (a1[4] == a2[2]) || (a1[4] == a2[3]) || (a1[4] == a2[4]) || (a1[4] == a2[5]) && (a1[5] == a2[0]) || (a1[5] == a2[1]) || (a1[5] == a2[2]) || (a1[5] == a2[3]) || (a1[5] == a2[4]) || (a1[5] == a2[5]))
        {
            c2 = true;
            return c2;
        }
        else
        {
            c2 = false;
            return c2;
        }
    }
    static bool ar_vienodi_skaiciai_x5(int[] a1, ref bool c3, int skaicius1)
    {
        int a1_int = skaicius1;
        int a2_int = a1_int * 5;
        string holder = a2_int.ToString();
        int[] a2 = new int[holder.ToString().Length];
        for (int i = 0; i < a2.Length; i++)
        {
            a2[i] = Convert.ToInt32(holder[i]);
        }
        if ((a1[0] == a2[0]) || (a1[0] == a2[1]) || (a1[0] == a2[2]) || (a1[0] == a2[3]) || (a1[0] == a2[4]) || (a1[0] == a2[5]) && (a1[1] == a2[0]) || (a1[1] == a2[1]) || (a1[1] == a2[2]) || (a1[1] == a2[3]) || (a1[1] == a2[4]) || (a1[1] == a2[5]) && (a1[2] == a2[0]) || (a1[2] == a2[1]) || (a1[2] == a2[2]) || (a1[2] == a2[3]) || (a1[2] == a2[4]) || (a1[2] == a2[5]) && (a1[3] == a2[0]) || (a1[3] == a2[1]) || (a1[3] == a2[2]) || (a1[3] == a2[3]) || (a1[3] == a2[4]) || (a1[3] == a2[5]) && (a1[4] == a2[0]) || (a1[4] == a2[1]) || (a1[4] == a2[2]) || (a1[4] == a2[3]) || (a1[4] == a2[4]) || (a1[4] == a2[5]) && (a1[5] == a2[0]) || (a1[5] == a2[1]) || (a1[5] == a2[2]) || (a1[5] == a2[3]) || (a1[5] == a2[4]) || (a1[5] == a2[5]))
        {
            c3 = true;
            return c3;
        }
        else
        {
            c3 = false;
            return c3;
        }
    }
    static bool ar_vienodi_skaiciai_x6(int[] a1, ref bool c4, int skaicius1)
    {
        int a1_int = skaicius1;
        int a2_int = a1_int * 6;
        string holder = a2_int.ToString();
        int[] a2 = new int[holder.ToString().Length];
        for (int i = 0; i < a2.Length; i++)
        {
            a2[i] = Convert.ToInt32(holder[i]);
        }
        if ((a1[0] == a2[0]) || (a1[0] == a2[1]) || (a1[0] == a2[2]) || (a1[0] == a2[3]) || (a1[0] == a2[4]) || (a1[0] == a2[5]) && (a1[1] == a2[0]) || (a1[1] == a2[1]) || (a1[1] == a2[2]) || (a1[1] == a2[3]) || (a1[1] == a2[4]) || (a1[1] == a2[5]) && (a1[2] == a2[0]) || (a1[2] == a2[1]) || (a1[2] == a2[2]) || (a1[2] == a2[3]) || (a1[2] == a2[4]) || (a1[2] == a2[5]) && (a1[3] == a2[0]) || (a1[3] == a2[1]) || (a1[3] == a2[2]) || (a1[3] == a2[3]) || (a1[3] == a2[4]) || (a1[3] == a2[5]) && (a1[4] == a2[0]) || (a1[4] == a2[1]) || (a1[4] == a2[2]) || (a1[4] == a2[3]) || (a1[4] == a2[4]) || (a1[4] == a2[5]) && (a1[5] == a2[0]) || (a1[5] == a2[1]) || (a1[5] == a2[2]) || (a1[5] == a2[3]) || (a1[5] == a2[4]) || (a1[5] == a2[5]))
        {
            c4 = true;
            return c4;
        }
        else
        {
            c4 = false;
            return c4;
        }
    }

    private static void printMineSweeperNumbers()
    {
        throw new NotImplementedException("TODO: Sukurkite programą kuri liepia vartotojui įvesti MineSweeper žaidimo lauko duomenis. " +
            "Tada paskaičiuoja ir išspausdina lentelę su skaičiais kiek aplinkui(8 kryptyse įskaitant įstrižai) yra minų.");
    }
}

