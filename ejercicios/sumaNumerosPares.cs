using static System.Console;
//using static System.Math;

namespace sumaNumeros
{
    class Program
    {
        public void numerosPares()
        {
            List<int> numeros = new List<int>();
            int suma = 0;
            while(true){
                WriteLine("Introduce un numero o Intro para terminar: ");
                string? numero = ReadLine();
                int numericValue;

                if(numero == "") break;
                else
                {
                    bool isNumber = int.TryParse(numero, out numericValue);
                    if (isNumber == true)
                    {
                        numeros.Add(numericValue);
                    }
                    else WriteLine("El número no es correcto ");
                }
            }
            foreach (int num in numeros)
            {
                if (num % 2 == 0)
                    suma += num;
            }

            WriteLine("La suma de los números pares es {0}", suma);

        }
    }
}