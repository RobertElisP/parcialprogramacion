using System;
using System.Collections.Generic;
using System.Linq;

namespace SegundoParcial
{
    class Program
    {

        public static decimal[] Salario = new decimal[5];
        public static string[] Nombre = new string[5];
        public static bool repetir = true;


        static void Main(string[] args)
        {
            
            while (repetir)
            {

                string desicion = default;
                Console.Clear();
                Console.WriteLine("Seleccione una Opcion: ");
                Console.WriteLine("A) Cargar Usuario: ");
                Console.WriteLine("B) Ver Salario mayor: ");
                Console.WriteLine("B) Salir: ");
                Console.WriteLine("");
                Console.Write("Respuesta: ");
                desicion = Console.ReadLine().ToUpper();
                switch (desicion)
                {
                    case "A":
                        Cargar();
                        break;
                    case "B":
                        SalarioMayor();
                        break;
                    case "C":
                        repetir = false;
                        Console.WriteLine("Hasta Luego");
                        break;
                }
            }





        }

        public static void Cargar() {

            int contador = 0;
            Console.WriteLine("Sistema de Empleados");
            Console.WriteLine("Nota: Solo puede agregar 5 empleados");


            for (int i = 0; i < Nombre.Length; i++)
            {
                Console.WriteLine("----------------------------------");
                contador++;
                Console.WriteLine("");

                Console.WriteLine("Agregando el empleado {0}:",contador);
                Console.Write("Nombre del Empleado: ");
                Nombre[i] = Console.ReadLine();
                Console.Write("Salario del Empleado: ");
                Salario[i] =  Convert.ToDecimal(Console.ReadLine());
                
            }

        }

        public static void SalarioMayor() 
        {
            Console.Clear();

            if (Salario != null)
            {
                if (Nombre != null)
                {

                    Console.WriteLine("------------------------------------------");
                    decimal mayorSalario = Salario[0];
                    string NombreSalarioMayor = Nombre[0];
                    for (int i = 0; i < Salario.Length; i++)
                    {
                        if (Salario[i] > mayorSalario)
                        {
                            mayorSalario = Salario[i];
                            NombreSalarioMayor = Nombre[i];
                        }

                    }
                    Salario = null;
                    Nombre = null;
                    Console.WriteLine("El Empleado con el salario mayor es {0} \n" +
                        "Tiene un salario de:  ${1}", NombreSalarioMayor, mayorSalario);
                    Console.WriteLine("------------------------------------------");

                    Console.WriteLine("Presione Enter para salir del programa");
                    Console.ReadLine();
                    repetir = false;

                }

            }
            else {
                Console.WriteLine("No Hay Empleados Registrados");
                Console.WriteLine("Presione Enter para Ejecutar el programa de nuevo");
                Console.ReadLine();

            }



        }

       
    }
}
