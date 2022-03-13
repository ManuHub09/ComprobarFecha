using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobarFechas
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AñoActual = 2022;
            //Entrada de Datos
            //Mirar lo de año bisiesto y el mes de febrero
            int[] FechaPersona1=FuncionesEntrada.Datos1(AñoActual);
            int[] FechaPersona2 = FuncionesEntrada.Datos2(AñoActual);
            //Cálculos

            //La salida de Datos
           
            Console.WriteLine("...");
            Console.ReadKey();
        }
    }
}
