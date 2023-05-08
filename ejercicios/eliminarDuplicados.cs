using static System.Console;
//using static System.Math;

namespace eliminarDuplicados
{
    class Program
    {
        public static void elimDupli()
        {
            List<int> numeros = new List<int>();

            List<int> numerosSinDuplicados = new List<int>();
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
                        numeros.Add(numericValue);
                    }
                    else WriteLine("El número no es correcto ");
                }
            }
            foreach (int numero in numeros)
            {
                if (!numerosSinDuplicados.Contains(numero))
                {
                    numerosSinDuplicados.Add(numero);
                }
            }

            WriteLine("Números originales: " + string.Join(", ", numeros));
            WriteLine("Números originales: " + string.Join(", ", numerosSinDuplicados));
        }
    }
}