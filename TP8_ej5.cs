using System;
/*5) En base al ejercicio anterior, se debe solicitar al usuario que ingrese un día y mes del año,
para luego calcular y mostrar por pantalla la cantidad de días que quedan hasta el fin de año.*/
namespace TP8C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int valorMes = 0;
            int valorDia = 0;
            int restoAno = 0;
            int [] arrayMes = {31,28,31,30,31,30,31,31,30,31,30,31};
            String [] arrayNombre = {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
            Console.WriteLine("Ingrese un numero entero para identificar el mes");
            Console.WriteLine("(Ejemplo: 1 - Enero))");
            valorMes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un numero entero para identificar el día de "+ arrayNombre [valorMes-1]);
            valorDia = Convert.ToInt32(Console.ReadLine());
            restoAno = arrayMes [valorMes-1] - valorDia;
            for (int i = valorMes; i < arrayMes.Length; i++)
            {
                restoAno = restoAno + arrayMes[i];
            }
            Console.WriteLine("La cantidad de días restantes del año es: "+restoAno);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
    }
}
