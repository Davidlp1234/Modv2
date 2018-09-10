using System;

namespace Modv2
{
    class Program
    {
        static int? Menor(int a, int b)
        {
            if (a < b)
                return a;
            else if (a == b)
                return null;
            else return b;
        }


        static void Main(string[] args)
        {
            int primer, segundo
                ;
            int? resultado;

            Console.WriteLine("Ingrese el primer numero");
            primer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            segundo = Convert.ToInt32(Console.ReadLine());
            resultado = Menor(primer, segundo);
            if (resultado == null)
                Console.WriteLine("Ingresaste el mismo numero, son iguales");
            else
                Console.WriteLine("{0} es el Menor", resultado);
            Console.ReadKey();


        }
    }
}