// See https://aka.ms/new-console-template for more information
using Calculadora;
using System;

namespace CalculadoraConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la calculadora
            Operaciones calculadora = new Operaciones();

            double resultado = 0;

            while (true)
            {
                Console.WriteLine("Resultado: " + resultado);
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");


                //Console.Write("Ingrese el número: ");
                //double numero = Convert.ToDouble(Console.ReadLine());

                Console.Write("Elije la Opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
               
                if (opcion == 5)
                {
                    break;
                }

                Console.Write("Ingrese el número para la operacion: ");
                double numero = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        resultado = calculadora.Sumar(resultado, numero);
                        break;
                    case 2:
                        resultado = calculadora.Restar(resultado, numero);
                        break;
                    case 3:
                        resultado = calculadora.Multiplicar(resultado, numero);
                        break;
                    case 4:
                        resultado = calculadora.Dividir(resultado, numero);
                        break;
                    default:
                        Console.WriteLine("Ingresa el numero");
                        break;
                }

                Console.WriteLine("Resultado despues de la operacion es : " + resultado);
                Console.WriteLine();
            }

        }
    }
    }
