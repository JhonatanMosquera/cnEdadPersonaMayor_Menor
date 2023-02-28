using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnEdadPersonaMayor_menor
{ 
internal class Program
{
    /// <summary>
    /// Nombre: Jhonatan Stiven Mosquera Moreno
    /// fecha: 24/02/2023
    /// descripcion: Identificar persona mayor o mejor 
    /// </summary>


    static void Main(string[] args)
    {
        ComprobadorEdad();
        Console.ReadKey();
    }

    //metodo para comprar si es mayor o menor de edad
    static void ComprobadorEdad()
    {

        Console.WriteLine("Ingrese tu nombre por favor");
        string Nombre = Console.ReadLine();
        Console.WriteLine("ingresa tu edad");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 0 && edad < 18)
        {
            Console.WriteLine("Joven " + Nombre + " usted es menor de edad y tienes " + edad + " años");


        }
        else if (edad > 18)
        {
            Console.WriteLine("señor " + Nombre + " usted es mayor de edad y tienes " + edad + " años");

        }
        else
        {
            Console.WriteLine("Ingrese una edad correcta");
        }
    }
}
}

