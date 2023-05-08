using static System.Console;
//using static System.Math;

namespace anioBisiesto
{
    class Program
    {
        public static void anioBi()
        {
            while(true){
                Write("Ingrese un año: ");
                int anio = 0;
                if (int.TryParse(ReadLine(), out anio))
                {
                     if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
                    {
                        WriteLine(anio + " es un año bisiesto");
                    }
                    else
                    {
                        WriteLine(anio + " no es un año bisiesto");
                    }
                break;
                }
                else
                    WriteLine("Ha entrado un año incorrecto");
            }
        }
    }
}

