using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPractica1
{
    class ejercicio3
    {
        public void ejercicio_3()
        {
            decimal multiplicacion,suma,resta,division,num1,num2;

            Console.WriteLine("Ingrese el primer numero en decimal");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero en decimal");
            num2 = Convert.ToDecimal(Console.ReadLine());

           
            multiplicacion = num1 * num2;
            division = num1 / num2;
            suma = num1 + num2;
            resta = num1 - num2;
            Console.WriteLine();
            Console.WriteLine("La suma de ambos numeros es: "+suma.ToString("N1"));
            Console.WriteLine("La resta de ambos numeros es: " + resta.ToString("N1"));
            Console.WriteLine("La multiplicación de ambos numeros es: " +multiplicacion.ToString("N1"));
            Console.WriteLine("La división de ambos numeros es: " +division.ToString("N1"));
        }
    }
}
