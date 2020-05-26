using System;

namespace Producto_de_0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que multiplique dos números enteros de la siguiente forma:
            pedirá al usuario un primer número entero. Si el número que se que teclee es 0,
            escribirá en pantalla &quot;El producto de 0 por cualquier número es 0&quot;. Si se ha
            tecleado un número distinto de cero, se pedirá al usuario un segundo número y
            se mostrará el producto de ambos.*/

            int num1, num2, mult;

            Console.WriteLine("Digite un número");
            num1 = Convert.ToByte(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            }
            else
            {
                Console.WriteLine("Digite otro número");
                num2 = Convert.ToByte(Console.ReadLine());

                mult = num1 * num2;
                Console.WriteLine("El producto de ambos números es: " + mult);
            }
            Console.Read();
        }
    }
}
