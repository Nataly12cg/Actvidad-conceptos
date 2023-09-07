

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

            // Ejercicio 3: Root or Square
            Console.Write("Ingresa un número: ");
            if (double.TryParse(Console.ReadLine(), out double numero3))
            {
                if (numero3 > 0)
                {
                    double resultado3 = Math.Sqrt(numero3);
                    Console.WriteLine($"Resultado: {resultado3}");
                }
                else
                {
                    double resultado3 = Math.Pow(numero3, 2);
                    Console.WriteLine($"Resultado: {resultado3}");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa un número válido.");
            }

            // Ejercicio 4: Circle Perimeter
            Console.Write("Ingresa el radio de un círculo: ");
            if (double.TryParse(Console.ReadLine(), out double radio))
            {
                if (radio > 0)
                {
                    double perimetro = 2 * Math.PI * radio;
                    Console.WriteLine($"Resultado: {perimetro:F2}");
                }
                else
                {
                    Console.WriteLine("Resultado: Radio no válido. Debe ser mayor que 0.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa un número válido.");
            }

            // Ejercicio 5: Midweek Day
            Console.Write("Ingresa un número entre 1 y 7: ");
            if (int.TryParse(Console.ReadLine(), out int numeroDia))
            {
                string diaSemana;

                switch (numeroDia)
                {
                    case 1:
                        diaSemana = "Lunes";
                        break;
                    case 2:
                        diaSemana = "Martes";
                        break;
                    case 3:
                        diaSemana = "Miércoles";
                        break;
                    case 4:
                        diaSemana = "Jueves";
                        break;
                    case 5:
                        diaSemana = "Viernes";
                        break;
                    default:
                        diaSemana = "Número fuera del rango laborable";
                        break;
                }

                Console.WriteLine($"Resultado: {diaSemana}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa un número entre 1 y 7.");
            }

            // Ejercicio 6: Tax Calculator
            Console.Write("Ingresa tu salario anual: ");
            if (double.TryParse(Console.ReadLine(), out double salarioAnual))
            {
                if (salarioAnual > 12000)
                {
                    double excedente = salarioAnual - 12000;
                    double impuesto = excedente * 0.15;
                    Console.WriteLine($"Resultado: {impuesto:F2}");
                }
                else
                {
                    Console.WriteLine("Resultado: No debe impuestos.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa un salario anual válido.");
            }

            // Ejercicio 7: Remainder Finder
            Console.Write("Ingresa el primer número: ");
            if (double.TryParse(Console.ReadLine(), out double numero11))
            {
                Console.Write("Ingresa el segundo número: ");
                if (double.TryParse(Console.ReadLine(), out double numero2) && numero2 != 0)
                {
                    double residuo = numero11 % numero2;
                    Console.WriteLine($"Resultado: {residuo}");
                }
                else
                {
                    Console.WriteLine("Resultado: El segundo número debe ser diferente de cero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa números válidos.");
            }

            // Ejercicio 8: Sum of Evens
            int sumaPares = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    sumaPares += i;
                }
            }

            Console.WriteLine($"Resultado: {sumaPares}");

              // Ejercicio 9: String Length
            Console.Write("Ingresa una palabra: ");
            string? palabra = Console.ReadLine();

            if (!string.IsNullOrEmpty(palabra))
            {
                int longitud = palabra.Length;
                Console.WriteLine($"Resultado: {longitud}");
            }
            else
            {
                Console.WriteLine("La entrada no puede estar vacía.");
            }

            Console.WriteLine("Ingrese cuatro números para calcular su promedio:");

            // Ejercicio 10: Average of Four
            double numero111 = PedirNumero("Número 1: ");
            double numero22 = PedirNumero("Número 2: ");
            double numero33 = PedirNumero("Número 3: ");
            double numero4 = PedirNumero("Número 4: ");

            double promedio = (numero111 + numero22 + numero33 + numero4) / 4;

            Console.WriteLine($"El promedio de los números ingresados es: {promedio}");

            // Ejercicio 11: Vowel Counter
            Console.Write("Ingresa una palabra: ");
            string? palabraVocales = Console.ReadLine();
            if (palabra != null)
            {
            int contadorVocales = ContarVocales(palabra);
             Console.WriteLine($"Resultado: {contadorVocales}");
            }
            else
            {
             Console.WriteLine("La entrada no puede estar vacía.");
             }

            // Ejercicio 12: Factorial Finder
            Console.Write("Ingresa un número para calcular su factorial: ");
            if (int.TryParse(Console.ReadLine(), out int numeroFactorial))
            {
                long factorial = CalcularFactorial(numeroFactorial);
                Console.WriteLine($"Resultado: {factorial}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa un número entero válido.");
            }

            // Ejercicio 13,14,15: InRange Validator
            Console.Write("Ingresa un número para verificar si está en el rango de 10 a 20: ");
            if (int.TryParse(Console.ReadLine(), out int numeroRango))
            {
                if (numeroRango >= 10 && numeroRango <= 20)
                {
                    Console.WriteLine("Resultado: Está en el rango.");
                }
                else
                {
                    Console.WriteLine("Resultado: Fuera del rango.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa un número entero válido.");
            }
        }

        static double PedirNumero(string mensaje)
        {
            double numero;
            do
            {
                Console.Write(mensaje);
            } while (!double.TryParse(Console.ReadLine(), out numero));

            return numero;
        }

        static int ContarVocales(string palabra)
        {
            int contador = 0;
            foreach (char letra in palabra.ToLower())
            {
                if ("aeiouáéíóú".Contains(letra))
                {
                    contador++;
                }
            }
            return contador;
        }

        static long CalcularFactorial(int numero)
        {
            if (numero == 0)
            {
                return 1;
            }
            return numero * CalcularFactorial(numero - 1);
        }
    }
}
