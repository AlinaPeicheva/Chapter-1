using System;


class Program
{
    static void Main()
    {
        //Програма, която извежда първите 100 члена на редицата 2,-3, 4, -5, 6, -7, 8.

        for (int i = 2; i < 103; i++)
        {
            if (i % 2 == 0) Console.WriteLine(i);
            else Console.Write("-{0}", i);
        }
    }
}
