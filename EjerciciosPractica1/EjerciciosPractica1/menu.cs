﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPractica1
{
    class menu
    {
       public static void Main(string[] args)
        {

            reg:
            Console.WriteLine("1-)Ejercicio 1");
            Console.WriteLine("2-)Ejercicio 2");
            Console.WriteLine("3-)Ejercicio 3");
            Console.WriteLine("4-)Ejercicio 4");
            Console.WriteLine("5 -)Ejercicio 5");
            Console.WriteLine("5 -)Ejercicio 6");
            Console.Write("Elegir practica:");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Clear();
                    ejercicio1 e1 = new ejercicio1();
                    e1.ejercicio_1();
                    break;

                case 2:
                    Console.Clear();
                    ejercicio2 e2 = new ejercicio2();
                    e2.ejercicio_2();
                    break;
                case 3:
                    Console.Clear();
                    ejercicio3 e3 = new ejercicio3();
                    e3.ejercicio_3();
                    break;
                case 4:
                    Console.Clear();
                    ejercicio4 e4 = new ejercicio4();
                    e4.ejercicio_4();
                    break;
                case 5:
                    Console.Clear();
                    ejercicio5 e5 = new ejercicio5();
                    e5.ejercicio_5();
                    break;
                case 6:
                    Console.Clear();
                    ejercicio6 e6 = new ejercicio6();
                    e6.ejercicio_6();
                    break;

                default:
                    Console.WriteLine("Elegir entre 1-6");
                    Console.ReadKey();
                    goto reg;
                    
            }
            Console.ReadKey();
        }
    }
}
