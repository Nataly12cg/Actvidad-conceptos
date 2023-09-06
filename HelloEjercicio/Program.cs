﻿
namespace HelloEjercicio 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1: Positive Power
             Console.Write("Ingresa un número: ");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                if (numero > 0)
                {
                    double resultado = Math.Pow(numero, 2);
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("Resultado: Número negativo.");
                }
                else
                {
                    Console.WriteLine("Resultado: 0");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa un número válido.");
            }

            // Ejercicio 2: Double or Triple
            Console.Write("Ingresa el primer número: ");
            if (double.TryParse(Console.ReadLine(), out double numero1))
            {
                Console.Write("Ingresa el segundo número: ");
                if (double.TryParse(Console.ReadLine(), out double numero2))
                {
                    double resultado;

                    if (numero1 > numero2)
                    {
                        resultado = numero1 * 2;
                    }
                    else
                    {
                        resultado = numero2 * 3;
                    }

                    Console.WriteLine($"Resultado: {resultado}");
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el segundo número.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida para el primer número.");
            }

            // Ejercicio 3: Otro ejercicio
            
        }
    }
}



