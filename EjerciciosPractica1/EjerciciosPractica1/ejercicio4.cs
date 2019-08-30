using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPractica1
{
    class ejercicio4
    {
        public void ejercicio_4()
        {
          
            
            Console.WriteLine("Ingrese un numero entero");
            Double numero = Convert.ToDouble(Console.ReadLine());
            if (numero > 0)
            {
                numero = Math.Sqrt(numero);
                Console.WriteLine("La raíz del número ingresado es: " + numero);
            }
            else
            {
                Console.WriteLine("El numero insertado era incorrecto");
            }
            
            Console.ReadKey();
        }
    }
}
