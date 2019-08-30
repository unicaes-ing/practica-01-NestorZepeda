using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPractica1
{
   class ejercicio6
    {
        public void ejercicio_6()
        {
            decimal renta=0.00m, sueldo, afp, isss=0.00m,totalsueldo;
            Console.WriteLine("Ingrese nombre del empleado");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese sueldo del empleado");
            Console.Write("Sueldo: ");
            sueldo = Convert.ToDecimal(Console.ReadLine());
            
            if (sueldo >= 472.01m && sueldo <= 895.24m)
            {
                renta = sueldo * 0.10m;
            } else
                if (sueldo >= 895.25m && sueldo <= 2038.10m)
            {
                renta = sueldo * 0.20m;
            } else
                if (sueldo >= 2038.11m)
            {
                renta = sueldo * 0.30m;
            }
            if (sueldo >= 1000.01m)
            {
                isss = 1000 * 0.03m;
            }
            afp = sueldo * 0.0725m;
            
            totalsueldo = ((sueldo - renta) - afp) - isss;
            Console.WriteLine("Empleado: " + nombre);
            Console.WriteLine();
            Console.WriteLine("Sueldo: " + sueldo.ToString("C2"));
            Console.WriteLine();
            Console.WriteLine("Renta: " + renta.ToString("C2"));
            Console.WriteLine();
            Console.WriteLine("AFP: "+afp.ToString("C2"));
            Console.WriteLine();
            Console.WriteLine("ISSS: "+isss.ToString("C2"));
            Console.WriteLine();
            Console.WriteLine("Total sueldo: "+totalsueldo.ToString("C2"));
        }
    }
}
