using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicasc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Alejandro";
            Console.WriteLine(nombre.Substring(4));
            Console.WriteLine(nombre);
            Calcular();
            Console.Read();
        }

        public static void Calcular()
        {
            Console.WriteLine("Ingresar un numero");
            string numero1 = Console.ReadLine();
            Console.WriteLine("Ingresar segundo numero");
            string numero2 = Console.ReadLine();

            int num1 = int.Parse(numero1);
            int num2 = int.Parse(numero2);
            int resultado = num1 + num2;
            Console.WriteLine("resultado de la suma de los numeros es: "+resultado);
        }
    }
}
