/*4) Guardar en un arreglo la cantidad de días que tiene cada mes del año (año no bisiesto) y
luego pedir al usuario que ingrese un mes (1=enero 12=diciembre) y según dicho valor mostrar
por pantalla los días de dicho mes.*/

using System;

namespace Ej4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            string[] mesees={"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Dicienmbre"};
            int[] dias={31,28,31,30,31,30,31,31,30,31,30,31};

            Console.Clear();
            System.Console.WriteLine( "--------BIENVENIDO AL SISTEMA--------");
            System.Console.WriteLine("Por favor ingrese un mes de El 1 al 12");
            dia=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("El elegido es {0} y tiene {1} dias" , mesees[dia-1], dias[dia-1]);

        }
    }
}
