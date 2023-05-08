using static System.Console;
//using static System.Math;

namespace ordenarNombres
{
    class Program
    {
        public static void ordenarNom()
        {
            List<string> listaNombres = new List<string>();
            while(true){
                WriteLine("Introduce un nombre o Intro para terminar: ");
                string? nombre = ReadLine();
                if (nombre == "") break;
                else if(nombre !=null) listaNombres.Add(nombre);
            }
            listaNombres.Sort();

            WriteLine("Lista ordenada alfabéticamente:");

            foreach (string nombre in listaNombres)
            {
                WriteLine(nombre);
            }
        }
    }
}