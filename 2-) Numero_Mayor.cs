using System;

namespace Numero_Mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario dos números enteros y diga cuál es el
            mayor de ellos*/

            int n1, n2;
            Console.WriteLine("Digite un número");
            n1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digite otro número");
            n2 = Convert.ToByte(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("El primer número es mayor");
            }
            else if (n1 == n2)
            {
                Console.WriteLine("Los números Son iguales");

            }
            else
            {
                Console.WriteLine("El segundo número es mayor");
            }

            Console.Read();
        }
    }
}
