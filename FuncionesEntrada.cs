using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobarFechas
{
    class FuncionesEntrada
    {
        public static int[] Datos1(int AñoActual)
        {
            Console.WriteLine("A continuación ingrese los datos de la persona número 1");
            int[] Persona_1 = new int[3];// Para tener solo 3 posiciones, año-mes-día
            Persona_1[0] = IntroducirAño(AñoActual);
            Persona_1[1] = IntroducirMes();
            Persona_1[2] = IntroducirDia();
            return (Persona_1);
        }
        public static int[] Datos2(int AñoActual)
        {
            Console.WriteLine("A continuación ingrese los datos de la persona número 2");
            int[] Persona_2 = new int[3];// Para tener solo 3 posiciones, año-mes-día
            Persona_2[0] = IntroducirAño(AñoActual);
            Persona_2[1] = IntroducirMes();
            Persona_2[2] = IntroducirDia();
            return (Persona_2);
        }
        public static int IntroducirAño(int AñoActual)
        {
            int año = 0;
            bool leido = false;
            do
            {
                Console.WriteLine("Introduzca el año de nacimiento");
                if (!Int32.TryParse(Console.ReadLine(), out año))
                {
                    Console.WriteLine("el año tiene que ser numero entero");
                    Console.WriteLine("vuelve a intentarlo");
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                   if(año>0)//Era de Cristo
                   {
                       if(año<=AñoActual)
                       {
                            leido = true;
                       }
                       else
                       {
                            Console.WriteLine("el año tiene que ser menor al año Actual {0}", AñoActual);
                            Console.WriteLine("vuelve a intentarlo");
                            Console.ReadKey();
                            Console.Clear();
                        }
                   }
                   else
                   {
                        Console.WriteLine("el año no puede ser menor Cristo");
                        Console.WriteLine("vuelve a intentarlo");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

            } while (!leido) ;
            return (año);
        }
        public static int IntroducirMes()
        {
            int mes = 0;
            bool leido = false;
            do
            {
                
                Console.WriteLine("Introduzca el mes de nacimiento");
                if (!Int32.TryParse(Console.ReadLine(), out mes))
                {
                    Console.WriteLine("el mes tiene que ser un número entero");
                    Console.WriteLine("vuelve a intentarlo");
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    if (mes > 0)//Tiene que ser positivo
                    {
                        if (mes <=12)
                        {
                            leido = true;
                        }
                        else
                        {
                            Console.WriteLine("el mes no puede ser mayor que 12 ");
                            Console.WriteLine("vuelve a intentarlo");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("el mes no puede ser menor 0");
                        Console.WriteLine("vuelve a intentarlo");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

            } while (!leido);
            return (mes);
        }
        public static int IntroducirDia()
        {
            int dia = 0;
            bool leido = false;
            do
            {
                Console.WriteLine("Introduzca el dia de nacimiento");
                if (!Int32.TryParse(Console.ReadLine(), out dia))
                {
                    Console.WriteLine("el dia tiene que ser un número entero");
                    Console.WriteLine("vuelve a intentarlo");
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    if (dia > 0)//Tiene que ser positivo
                    {
                        if (dia <= 31)
                        {
                            leido = true;
                        }
                        else
                        {
                            Console.WriteLine("el dia no puede ser mayor que 31 ");
                            Console.WriteLine("vuelve a intentarlo");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("el dia no puede ser menor 0");
                        Console.WriteLine("vuelve a intentarlo");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

            } while (!leido);
            return (dia);
        }


    }
}
