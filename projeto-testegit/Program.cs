using System;

namespace projeto_testegit
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;

            //instanciar os triangulos
            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Escreva as medidas do triangulo X");
            //para ir apanhar os dados a,b,c do triangulo
            x.A= double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());


            Console.WriteLine("Escreva as medidas do triangulo Y");
            //para ir apanhar os dados a,b,c do triangulo
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("A area de x = " + areaX);
            Console.WriteLine("A area de x = " + areaY);

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}
