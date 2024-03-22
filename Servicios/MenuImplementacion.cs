using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioFichero5.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenu() {

            Console.WriteLine("-----------------");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Modificar una línea específica");
            Console.WriteLine("2. Insertar texto en una posición específica de una línea");
            Console.WriteLine("-----------------");

            int opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            return opcionSeleccionada; 
        }


    }
}
