using System;

class Program
{
    static void Main()
    {
        Console.Write("t санын енгізіңіз: ");
        int t = int.Parse(Console.ReadLine());

        Console.Write("p санын енгізіңіз: ");
        int p = int.Parse(Console.ReadLine());

        if (p != 0 && t % p == 0)
        {
            int result = t / p;
            Console.WriteLine("Бөлінді: " + result);
        }
        else
        {
            Console.WriteLine("m-ден p-ге бөлінбейді");
        }
    }
}
