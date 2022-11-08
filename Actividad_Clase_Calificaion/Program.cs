using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Clase_Calificaion
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables
            string alum;
            double calf;

            //Color de fondo de la consola
            

            Console.WriteLine("Información del alumno para sus calificaciones");
            Console.WriteLine("Por favor ingrese sus datos");
          
            //Datos del alumno
            Console.WriteLine("Nombre del alumno:");
            alum = Console.ReadLine();
            Console.WriteLine("Cual es la calificacion del curso:");
            calf = Convert.ToDouble(Console.ReadLine());
           

            if (calf>=70)
            {


                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Usted ha acreditado el curso");



            }

            else
            {

                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("El alumno no ha acreditado el curso, debe volver a cursar la asignatura");
            }







            Console.ReadKey();
        }
    }
}
