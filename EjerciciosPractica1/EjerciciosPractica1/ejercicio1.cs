using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPractica1
{
    class ejercicio1
    {
        public void ejercicio_1()
        {
            Console.WriteLine("Ingresar informacion de su mascota");
            string nombremascota, especie;
            int edad;
            Console.Write("Ingrese el nombre de su mascota:");
            nombremascota = Console.ReadLine();
            Console.Write("Ingrese la espeie de su mascota:");
            especie = Console.ReadLine();
            Console.Write("Ingrese la edad de su mascota:");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Nombre de la mascota: " + nombremascota);
            Console.WriteLine("Especie de su mascota: " + especie);
            Console.WriteLine("Edad de su mascota: " + edad);
            Console.ReadKey();
        }

    }
}
