using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPractica1
{
    class ejercicio2
    {
        public void ejercicio_2()
        {
            Console.WriteLine("Ingrese datos");
            string nombre, cargo, correo;
            Console.WriteLine();
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su cargo:");
            cargo = Console.ReadLine();
            Console.Write("Ingrese su Correo:");
            correo = Console.ReadLine();
            Console.Write("Ingrese su edad:");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su fecha de contratacion:");
            string fecha = Console.ReadLine();
            Console.Write("Ingrese su sueldo:");
            decimal sueldo = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Datos ingresados ");
            Console.WriteLine("Presione <enter> para mostrar datos ingresados");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Nommbre: " + nombre, "\n Cargo:" + cargo, "Correo: \n" + correo,
                "Edad: \n" + edad
                );
            Console.ReadKey();
        }

    }
    }

