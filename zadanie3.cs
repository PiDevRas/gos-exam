using System;

class Program
{
    static void Main()
    {
        Console.Write("a мәнін енгізіңіз: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b мәнін енгізіңіз: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c мәнін енгізіңіз: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (a == 0)
        {
            Console.WriteLine("Бұл квадрат теңдеу емес.");
        }
        else if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Екі түбірі бар: x1 = " + x1 + ", x2 = " + x2);
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Бір түбірі бар: x = " + x);
        }
        else
        {
            Console.WriteLine("Нақты түбірі жоқ.");
        }
    }
}
