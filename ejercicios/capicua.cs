using static System.Console;
//using static System.Math;

namespace capicua
{
    class Program
    {
        public void capi()
        {
            while(true){
                Console.Write("Ingresa un número: ");
                int num = 0;
                if (int.TryParse(ReadLine(), out num))
                {
                    int originalNum = num;
                    int reversedNum = 0;

                    while (num > 0)
                    {
                        int digit = num % 10;
                        reversedNum = (reversedNum * 10) + digit;
                        num /= 10;
                    }

                    if (originalNum == reversedNum)
                    {
                        Console.WriteLine("El número es capicúa.");
                    }
                    else
                    {
                        Console.WriteLine("El número no es capicúa.");
                    }
                    break;
                }
                else WriteLine("El numero es incorrecto");
            }
        }
    }
}