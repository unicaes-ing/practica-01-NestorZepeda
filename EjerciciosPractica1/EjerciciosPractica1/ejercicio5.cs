using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPractica1
{
    class ejercicio5
    {
        public void ejercicio_5()
        {
            decimal trimestre1=0, trimestre2, trimestre3, trimestre4;
            Console.WriteLine("Ingrese las ventas realizadas en el primer trimestre");
            Console.Write("enero: ");
            int enero = Convert.ToInt32(Console.ReadLine());
            Console.Write("febrero: ");
            int febrero = Convert.ToInt32(Console.ReadLine());
            Console.Write("marzo: ");
            int Marzo = Convert.ToInt32(Console.ReadLine());
            trimestre1 =( enero + febrero + Marzo)/3;
            Console.Clear();
            Console.WriteLine("Ingrese las ventas realizadas en el segundo trimestre");
            Console.Write("Abril: ");
            int abril = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mayo: ");
            int mayo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Junio: ");
            int junio = Convert.ToInt32(Console.ReadLine());
            trimestre2 = (abril + mayo + junio) / 3;
            Console.Clear();
            Console.WriteLine("Ingrese las ventas realizadas en el tercer trimestre");
            Console.Write("Julio: ");
            int julio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Agosot: ");
            int agosto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Septiembre: ");
            int septiembre = Convert.ToInt32(Console.ReadLine());
            trimestre3 = (julio + agosto + septiembre) / 3;
            Console.Clear();
            Console.WriteLine("Ingrese las ventas realizadas en el cuarto trimestre");
            Console.Write("Octubre: ");
            int octubre = Convert.ToInt32(Console.ReadLine());
            Console.Write("Noviembre: ");
            int noviembre = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diciembre: ");
            int diciembre = Convert.ToInt32(Console.ReadLine());
            trimestre4 = (octubre + noviembre + diciembre) / 3;
            Console.Clear();
            Console.WriteLine("Promedio de ventas del primer trimestre:"+trimestre1);
            Console.WriteLine("Promedio de ventas del segundo trimestre:" + trimestre2);
            Console.WriteLine("Promedio de ventas del tercer trimestre:" + trimestre3);
            Console.WriteLine("Promedio de ventas del cuarto trimestre:" + trimestre4);
        }
    }
}
