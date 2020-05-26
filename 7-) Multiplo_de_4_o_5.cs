using System;

namespace Multiplo_de_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario un número enteros y diga si es múltiplo
            de 4 o de 5.*/

            int numero;
            Console.WriteLine("Digite un número ");
            numero = Convert.ToByte(Console.ReadLine());

            if (numero % 4 == 0)
            {
                Console.WriteLine("El número es múltiplo de 4");
            }
            else if (numero % 5 == 0)
            {
                Console.WriteLine("El número es múltiplo de 5");
            }
            else
            {
                Console.WriteLine("El número no es múltiplo de 4 ni de 5!");
            }
            Console.Read();
        }
    }
}
