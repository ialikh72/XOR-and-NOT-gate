using System;
class Program
{
    static void Main()
    {
        bool a, b;
        Console.WriteLine("XOR");
        for (int i = 0; i < 2; i++)
        {
            a = (i == 1);
            for (int j = 0; j < 2; j++)
            {
                b = (j == 1);
                Console.WriteLine(a + "^" + b + "=" + (a ^ b));
            }
        }
        Console.WriteLine("NOT");
        for (int i = 0; i < 2; i++)
        {
            a = (i == 1);
            Console.WriteLine(a + "=" + !a);
        }
    }
}