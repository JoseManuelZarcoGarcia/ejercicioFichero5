using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioFichero5.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public void escrituraDeFila(string fichero)
        {
            string[] lineas = File.ReadAllLines(fichero);

            try
            {
                Console.WriteLine("En que linea deseas escribir: ");
                int numeroLinea = Convert.ToInt32(Console.ReadLine());

                if (numeroLinea >= 1 && numeroLinea <= lineas.Length)
                {
                    Console.WriteLine("Que desea escribir: ");
                    string nuevoTexto = Console.ReadLine();

                    lineas[numeroLinea - 1] = nuevoTexto;

                    File.WriteAllLines(fichero, lineas);
                }
                else
                {
                    Console.WriteLine("La linea en la que desea escribir esta fuera de rango");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer o escribir en el archivo: " + e.Message);
            }
        }


        public void escrituraDePosicion(string fichero)
        {
            Console.WriteLine("En que posicion deseas escribir: ");
            int numeroPosicion = Convert.ToInt32(Console.ReadLine());

            string[] filas = File.ReadAllLines(fichero);

            if (numeroPosicion >= 0 && numeroPosicion <= filas.Length)
            {
                Console.WriteLine("Que desea escribir: ");
                string nuevoTexto = Console.ReadLine();

                try
                {
                    string nuevaLinea = filas[0].Insert(numeroPosicion, nuevoTexto);
                    filas[0] = nuevaLinea;
                    File.WriteAllLines(fichero, filas);
                }
                catch (Exception e)
                {
                    Console.WriteLine(Console.Error);
                }

            }
            else
            {
                Console.WriteLine("La posición especificada está fuera del rango del archivo.");
            }

        }

    }
}
