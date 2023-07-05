using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operaciones
    {
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return num1; // Retornar el mismo número para mantener el resultado anterior
            }
        }
    }

}

