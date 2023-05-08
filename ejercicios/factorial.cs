using static System.Console;
//using static System.Math;

namespace factorial
{
    class Program
    {
        public static void fac()
        {
            int num; 
            int factorial = 1;
            while(true){
                Write("Introduce un número entero positivo: ");
                if (int.TryParse(ReadLine(), out num))
                {

                    for (int i = 0; i < num; i++)
                    {
                        factorial = factorial * (i+1);
                    }

                    WriteLine("El factorial de {0} es {1}", num, factorial);
                    break;
                }
                else
                    WriteLine("Número inválido");
            }
        }
    }
}