using static System.Console;

namespace menorMayor
{
    class Program
    {
        public void meMay()
        {
            List<int> listaNumeros = new List<int>();
            while(true)
            {
                WriteLine("Introduce un numero o Intro para terminar: ");
                string? numero = ReadLine();
                int numericValue;

                if(numero == "") break;
                else
                {
                    bool isNumber = int.TryParse(numero, out numericValue);
                    if (isNumber == true)
                    {
                        listaNumeros.Add(numericValue);
                    }
                    else WriteLine("El número no es correcto ");
                }
            }
            WriteLine($"El numero mayor de la lista es {listaNumeros.Max()} y el número menor es {listaNumeros.Min()}");
        }
    }
}