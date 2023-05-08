using static System.Console;
using static System.Math;

namespace areaVolum
{
    class Program
    {
        public static void areaVolumen()
        {
            double lado = 0, area, volumen;
            while(true){
                Write("Introduce el valor del lado del cubo: ");
                if (double.TryParse(ReadLine(), out lado))
                {
                    area = 6 * Pow(lado, 2);
                    volumen = Pow(lado, 3);

                    WriteLine("El área del cubo es {0}", area);
                    WriteLine("El volumen del cubo es {0}", volumen);
                    break;
                }
                else WriteLine("Has introducido un dato incorrecto");
                
            }
        }
    }
}