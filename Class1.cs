using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_operaciones
{
    internal class Class1
    {

        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Elije una opcion \n" +
                "\n1.- Operadores" +
                "\n2.-Condiciones" +
                "\n3.-Ciclos" +
                "\n4.-Arreglos" +
                "\n5.-Salir");
            Console.WriteLine("----------------------------");

            String s1 = null;
             


            s1 = Console.ReadLine().ToString();
         


            switch (s1)
            {
                case "1": 
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Selecciono la opcion operadores");
                    Console.WriteLine("\n1- Seleccione la operacion que desea realizar");
                    Console.WriteLine("\n2- Volver al menu principal");
                    Console.WriteLine("---------------------------------------");    
                   break; 



            }
            Console.WriteLine("Elejiste el apartado de operaciones ");
           
            String s2 = null;   

            s2 = Console.ReadLine().ToString();

            switch (s2)

            {

                case "1":
                    Console.WriteLine("\n1- Suma");
                    Console.WriteLine("\n2- Area del triangulo");
                    Console.WriteLine("\n3- Numero elevado al cuadrado");
                    Console.WriteLine("\n4- area de un cilindro y volumen");
                    Console.WriteLine("\n5- Algoritmo que pida el lado de un cuadrado y muestre el valor del área y delperímetro.");
                    Console.WriteLine("\n6- Escribir un algoritmo que convierta de euros a dólares.");
                    Console.WriteLine("\n7- Realizar un algoritmo que lea el radio de una circunferencia y escriba la longitud de la misma y el área (pi * r) ^ 2 del círculo inscrito.");
                    Console.WriteLine("\n8- Calcular el promedio de tres (3) números ingresados por teclado.");


                    break;
            
            
            }
            Console.WriteLine("Elija la operacion que desea realizar");

            String s3 = null;   

            s3 = Console.ReadLine().ToString();

            switch (s3)
            {
                case "1":
                    Console.WriteLine("Ingrese un numero entero");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese un numero entero");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("El resultado de la operacion es");
                    Console.WriteLine(num1 + num2);

                    break;

                case "2":
                    Console.WriteLine("Ingrese un numero entero");
                    num1 = Convert.ToInt32((Console.ReadLine()));
                    Console.WriteLine("Ingrse un numero entero");
                    num2 = Convert.ToInt32((Console.ReadLine()));
                    Console.WriteLine("El resultado de la operacion es:");
                    Console.WriteLine((num1 * num2) / 2);

                    break;


                case "3":
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Ingrese un numero entero");
                    num1 = Convert.ToInt32((Console.ReadLine()));
                    Console.WriteLine("El resultado de la operacion es");
                    Console.WriteLine (Math.Pow(num1, 2));

                    break;

                    case "4":
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Ingrese un numero entero");
                    num1 = Convert.ToInt32((Console.ReadLine()));   
                    Console.WriteLine("Ingrese un numero entero");
                    num2 = Convert.ToInt32((Console.ReadLine())); 
                    Console.WriteLine("El resultado de la operacion es");
                    Console.WriteLine(2 * Math.PI *num1 * num2);
                    break;

                    case "5":
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Ingrese un numero entero");
                    num1 = Convert.ToInt32((Console.ReadLine()));
                    Console.WriteLine("El area de un cuadrado es");
                    Console.WriteLine(num1 * num1);
                    Console.WriteLine("El perimetro de un cuadrado es");
                    Console.WriteLine(num1 + num1 + num1 + num1);

                    break;

                case "6":
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Ingrese el valor en Euros");
                    num1 = Convert.ToInt32((Console.ReadLine()));
                    Console.WriteLine("El valor de Euros en dolares es:");
                    Console.WriteLine(num1 * 1.06);

                    break;

                case "7":
                    double Rad;
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Ingrese el Diametro de la circunferencia");
                    num1 = Convert.ToInt32((Console.ReadLine()));
                    Console.WriteLine("El valor del radio es:");
                    Console.WriteLine(Rad = num1 / 2);
                    Console.WriteLine("El valor del area de la circunferencia es");
                    Console.WriteLine((Math.PI * (Rad * Rad)));
                    Console.WriteLine("La longitud de la circunferencia es:");
                    Console.WriteLine(Math.PI * 2 * Rad);
                    Console.WriteLine("--------------------------");
                    break;


                case "8":

                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Ingrese el primer numero");
                    num1 = Convert.ToInt32((Console.ReadLine()));
                    Console.WriteLine("Ingrese el segundo numero");
                    num2 = Convert.ToInt32((Console.ReadLine()));
                    Console.WriteLine("Ingrese el tercer numero");
                    num3 = Convert.ToInt32((Console.ReadLine()));
                    Console.WriteLine("El promedio de los tres numero es:");
                    Console.WriteLine((num1 + num2 + num3) / 3);






                    







                    break;

            }

              



        }






    }   
    
}
