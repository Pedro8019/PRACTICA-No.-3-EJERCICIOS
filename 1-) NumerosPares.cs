using System;

namespace NumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario un número entero y diga si es par.

            double num;

            Console.WriteLine("Escriba un número ");
            num = Convert.ToDouble(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }

            Console.Read();
        }
    }
}