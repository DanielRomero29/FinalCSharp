using static System.Console;
//using static System.Math;

namespace parImpar
{
    class Program
    {
        public static void parIm()
        {
            while(true){
                int numero = 0;
                Write("Ingrese un número entero: ");
                if (int.TryParse(ReadLine(), out numero)){
                    if (numero % 2 == 0)
                    {
                        WriteLine("El número es par");
                    }
                    else
                    {
                        WriteLine("El número es impar");
                    }
                    break;
                } 
                else
                {
                    WriteLine("Ha entrado un número erroneo");
                }
            }
            
        }
    }
}