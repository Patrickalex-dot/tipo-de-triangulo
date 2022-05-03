using System;

namespace tipo_de_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lado1;
            decimal lado2;
            decimal lado3;

            Console.WriteLine("Digite valor do primeiro lado do triangulo");
            lado1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite valor do segundo lado do triangulo");
            lado2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite valor do terceiro lado do triangulo");
            lado3 = Convert.ToDecimal(Console.ReadLine());

            if (lado1 + lado2 > lado3)
            {
                Console.WriteLine("é um triangulo");
            }
            else if (lado2 + lado3 > lado2)
            {
                Console.WriteLine("é um triangulo");
            }
            else if (lado1 + lado3 > lado2)
            {
                Console.WriteLine("é um triangulo");
            }
           else 
            {
                Console.WriteLine("não é um triangulo");
            }

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("é um triangulo equilátero");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
            {
                Console.WriteLine("é um triangulo isóceles");
            }

            else if (lado1 != lado2 && lado2 != lado3)
            {
                Console.WriteLine("é um triangulo Escaleno");
            }
        
        }
    }
}
