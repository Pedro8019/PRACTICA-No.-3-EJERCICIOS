using System;

namespace Multiplo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario dos números enteros y diga si el primero
            es múltiplo del segundo*/

            int num1, num2;
            Console.WriteLine("Digite un número");
            num1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digite otro número");
            num2 = Convert.ToByte(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine("El primer número es múltiplo del segundo");
            }
            else
            {
                Console.WriteLine("El primer número no es múltiplo del segundo");
            }
            Console.Read();
        }
    }
}
