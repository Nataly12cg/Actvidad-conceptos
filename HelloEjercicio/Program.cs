
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
              double residuo = numero1 % numero2;
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



             // Ejercicio 8: Otro ejercicio
             // Ejercicio 9: Otro ejercicio
             // Ejercicio 10: Otro ejercicio
             // Ejercicio 11: Otro ejercicio
             // Ejercicio 12: Otro ejercicio
             // Ejercicio 13: Otro ejercicio
             // Ejercicio 14: Otro ejercicio
             // Ejercicio 5: Otro ejercicio
        
            
        }
    }
}



