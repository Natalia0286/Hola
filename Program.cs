using System;

namespace Hola
{
    class Program
    {
        static void Main(string[] args)
        {
                 
           String nombre = "Natalia"; 
           int edad = 31;         
           
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hola"+ nombre);
            Console.WriteLine("¿Cuántos años tenés?");
            Console.WriteLine(edad);



            int n = args.Length;
            switch(n) {

                case 0:
                     Console.WriteLine("No se pasaron parámetros");
                break;

                case 1:
                     Console.WriteLine("Se pasó un parámetro");
                break;

                default:
                     Console.WriteLine($"Se pasaron {n} parámetros");
                break;

            }
        }
    }
}
