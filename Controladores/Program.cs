using ejercicioFichero5.Servicios;

namespace ejercicioFichero5.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            int opcionSeleccionada;
            bool cerrarMenu = false;
            string rutaFile = "C:\\Users\\csi22-jzarcia\\Desktop\\textoACambiar.txt";


            do
            {
                opcionSeleccionada = mi.mostrarMenu();
                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu |= true;
                        break;
                    case 1:
                        oi.escrituraDeFila(rutaFile);
                        break;
                    case 2:
                        oi.escrituraDePosicion(rutaFile);
                        break;
                    default:
                        Console.WriteLine("No es una opcion valida, vuelvalo a intentar");
                        break;
                }

            }while (!cerrarMenu);

        }

    }

}