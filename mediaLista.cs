using static System.Console;
//using static System.Math;

namespace mediaLista
{
    class Program
    {
        public static void media()
        {
            List<int> listaNumeros = new List<int>();
            while(true){
                WriteLine("Introduce un numero o Intro para terminar: ");
                string? numero = ReadLine();
                int numericValue;

                if(numero == "") break;
                else{
                    if(int.TryParse(numero, out numericValue)) listaNumeros.Add(numericValue);
                    else WriteLine("El número no es correcto ");
                } 
            }
            WriteLine("La media es: " + listaNumeros.Average());
        }
    }
}