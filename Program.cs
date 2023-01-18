using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr_first = new int[20];
        int[] bigData = new int[3];
        int[] smallData = new int[3];

        for (int i = 0; i < 20; i++)
        {
            arr_first[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr_first);

        for (int i = 0; i < 3; i++)
        {
            smallData[i] = arr_first[i];
        }

        for (int i = 19; i > 16; i--)
        {
            bigData[19-i] = arr_first[i]; 
        }


        double sumBigData = 0;
        double sumSmallData = 0;

        System.Console.WriteLine("** Big Data **");
        foreach (int item in bigData)
        {
            sumBigData += item;
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("** Small Data **");
        foreach (int item in smallData)
        {
            sumSmallData += item;
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("Average Big " + Convert.ToDouble(sumBigData/3));
        System.Console.WriteLine("Average smak" + Convert.ToDouble(sumSmallData/3));
    }
}