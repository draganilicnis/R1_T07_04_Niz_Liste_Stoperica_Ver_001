// R1 T07 04 Liste
// https://petlja.org/sr-Cyrl-RS/kurs/14606/35/1394

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class R1_T07_04_Niz_Liste_Stoperica_Ver_001
{
    static void Main()
    {
        Stopwatch t = new Stopwatch();
        int N = 100 * 1000 * 1000;       // int N = 1000 * 1000 * 1000;
        int[] A = new int[N];
        List<int> B = new List<int>();
        Niz_00_Napuni(A);
        List_00_Napuni(A, B);           // B.AddRange(A);

        Console.WriteLine("Niz".PadLeft(36) + "List".PadLeft(17));

        Console.Write("Napuni:".PadRight(20));
        t.Start(); Niz_00_Napuni(A); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); List_00_Napuni(A, B); t.Stop(); Console.Write(t.Elapsed + "\n"); t.Reset();

        Console.Write("Napuni Random:".PadRight(20));
        t.Start(); Niz_00_Napuni_Random(A); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset(); 
        t.Start(); B.Clear(); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); List_00_Napuni(A, B); t.Stop(); Console.Write(t.Elapsed + "\n"); t.Reset();

        Console.Write("for:".PadRight(20));
        t.Start(); Niz_01_For(A); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); List_01_For(B); t.Stop(); Console.Write(t.Elapsed + "\n"); t.Reset();

        Console.Write("foreach:".PadRight(20));
        t.Start(); Niz_02_ForEach(A); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); List_02_ForEach(B); t.Stop(); Console.Write(t.Elapsed + "\n"); t.Reset();

        Console.Write("FindIndex:".PadRight(20));
        t.Start(); Niz_03_FindIndex(A); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); List_03_FindIndex(B); t.Stop(); Console.Write(t.Elapsed + "\n"); t.Reset();

        Console.Write("FindLastIndex:".PadRight(20));
        t.Start(); Niz_04_FindLastIndex(A); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); List_04_FindLastIndex(B); t.Stop(); Console.Write(t.Elapsed + "\n"); t.Reset();

        Console.Write("FindAll:".PadRight(20));
        t.Start(); Niz_05_FindAll(A); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); List_05_FindAll(B); t.Stop(); Console.Write(t.Elapsed + "\n"); t.Reset();

        Console.Write("Sum For:".PadRight(20));
        t.Start(); Niz_06_Sum_For(A); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); List_06_Sum_For(B); t.Stop(); Console.Write(t.Elapsed + "\n"); t.Reset();

        Console.Write("Sum Array ForEach:".PadRight(20));
        t.Start(); Niz_07_Sum_Array_ForEach(A); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); List_07_Sum_List_ForEach(B); t.Stop(); Console.Write(t.Elapsed + "\n"); t.Reset();

        Console.Write("Sum Linq Aggregate:".PadRight(20));
        t.Start(); Niz_08_Sum_Linq_Aggregate(A); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); List_08_Sum_Linq_Aggregate(B); t.Stop(); Console.Write(t.Elapsed + "\n"); t.Reset();

        Console.Write("Sum Linq:".PadRight(20));
        //t.Start(); Niz_09_Sum_Linq(A); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        //t.Start(); List_09_Sum_Linq(B); t.Stop(); Console.Write(t.Elapsed + "\n"); t.Reset();
        Console.WriteLine();

        Console.Write("Sort:".PadRight(20));
        t.Start(); Niz_10_Sort(A); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); List_10_Sort(B); t.Stop(); Console.Write(t.Elapsed + "\n"); t.Reset();
        Console.WriteLine();

        Console.WriteLine("A[0] = ".PadRight(20) + A[0]);
        Console.WriteLine("B[0] = ".PadRight(20) + B[0]);
    }

    static void Niz_00_Napuni(int[] a)
    {
        for (int i = 0; i < a.Length; i++) a[i] = i + 1;
    }
    static void Niz_00_Napuni_Random(int[] a)
    {
        // for (int i = 0; i < a.Length; i++) a[i] = i + 1;
        var rand = new Random();
        for (int i = 0; i < a.Length; i++) a[i] = rand.Next();
    }
    static void List_00_Napuni(int[] a, List<int> b)
    {
        b.AddRange(a);      // ili b = new List<int>(a);
    }
    static void Niz_01_For(int[] a)
    {
        for (int i = 0; i < a.Length; i++) a[i] = a[i] + 1;
    }
    static void List_01_For(List<int> a)
    {
        for (int i = 0; i < a.Count; i++) a[i] = a[i] + 1;
    }
    static void Niz_02_ForEach(int[] a)
    {
        int p = 0;
        foreach (int x in a) p = p + 1;
    }
    static void List_02_ForEach(List<int> a)
    {
        int p = 0;
        foreach (int x in a) p = p + 1;
    }

    // FindIndex
    static bool bPredikat_Uslov(int x) { return x == 1000 * 1000 * 1000 + 7;  }
    static void Niz_03_FindIndex(int[] a)
    {
        int p = Array.FindIndex(a, bPredikat_Uslov);
    }
    static void List_03_FindIndex(List<int> a)
    {
        int p = a.FindIndex(bPredikat_Uslov);
    }
    static void Niz_04_FindLastIndex(int[] a)
    {
        int p = Array.FindLastIndex(a, bPredikat_Uslov);
    }
    static void List_04_FindLastIndex(List<int> a)
    {
        int p = a.FindLastIndex(bPredikat_Uslov);
    }
    static void Niz_05_FindAll(int[] a)
    {
        int[] p = Array.FindAll(a, bPredikat_Uslov);
    }
    static void List_05_FindAll(List<int> a)
    {
        List<int> p = a.FindAll(bPredikat_Uslov);
    }

    // SUM
    // https://www.c-sharpcorner.com/blogs/how-to-find-sum-of-an-array-of-numbers-in-c-sharp
    static void Niz_06_Sum_For(int[] a)
    {
        int s = 0;
        for (int i = 0; i < a.Length; i++) s = s + a[i];
    }
    static void List_06_Sum_For(List<int> a)
    {
        int s = 0;
        for (int i = 0; i < a.Count; i++) s = s + a[i];
    }
    static void Niz_07_Sum_Array_ForEach(int[] a)
    {
        int s = 0;
        Array.ForEach(a, i => s = s + i);
    }
    static void List_07_Sum_List_ForEach(List<int> a)
    {
        int s = 0;
        a.ForEach(i => s = s + i);
    }
    static void Niz_08_Sum_Linq_Aggregate(int[] a)
    {
        int s = a.Aggregate((result, next) => result + next);
    }
    static void List_08_Sum_Linq_Aggregate(List<int> a)
    {
        int s = a.Aggregate((result, next) => result + next);
    }
    static void Niz_09_Sum_Linq(int[] a)
    {
        long s = a.Sum();
    }
    static void List_09_Sum_Linq(List<int> a)
    {
        long s = a.Sum();
    }

    // Sort
    static void Niz_10_Sort(int[] a)
    {
        Array.Sort(a);
    }
    static void List_10_Sort(List<int> a)
    {
        a.Sort();
    }
}
