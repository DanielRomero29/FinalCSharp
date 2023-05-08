using static System.Console;
//using static System.Math;

namespace posNegCero
{
    class Program
    {
        public static void posNegaCero()
        {
            int num;
            while(true){
                Write("Introduce un número entero: ");
                if (int.TryParse(ReadLine(), out num))
                {
                    if (num > 0)
                        WriteLine("{0} es un número positivo", num);
                    else if (num < 0)
                        WriteLine("{0} es un número negativo", num);
                    else
                        WriteLine("{0} es cero", num);
                    break;
                }
                else WriteLine("Número invalido");
            }
        }
    }
}