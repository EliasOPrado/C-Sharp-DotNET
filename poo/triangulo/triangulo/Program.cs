using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //    double xA, xB, xC, yA, yB, yC;

            //    Console.WriteLine("Entre com as medidas do triangulo X");
            //    xA = double.Parse(Console.ReadLine());
            //    xB = double.Parse(Console.ReadLine());
            //    xC = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Entre com as medidas do triangulo Y");
            //    yA = double.Parse(Console.ReadLine());
            //    yB = double.Parse(Console.ReadLine());
            //    yC = double.Parse(Console.ReadLine());

            //    double p = (xA + xB + xC) / 2.0;
            //    double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //    p = (yA + yB + yC) / 2.0;
            //    double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            //    Console.WriteLine("Area x = "+ areaX.ToString("F4"));
            //    Console.WriteLine("Area Y = "+ areaY.ToString("F4"));

            //    if(areaX > areaY)
            //    {
            //        Console.WriteLine("The biggest area is X");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The biggest area is ");
            //    }
            //}

            // applying the object way:

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area x = " + areaX.ToString("F4"));
            Console.WriteLine("Area Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("The biggest area is X");
            }
            else
            {
                Console.WriteLine("The biggest area is ");
            }

        }
    }
}
