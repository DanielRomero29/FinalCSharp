using static System.Console;
//using static System.Math;

namespace palabraPalin
{
    class Program
    {
        public static void palindroma()
        {
            bool palindroma = false;
        while (true)
        {
            WriteLine("Introduce una palabra de minimo 2 letras: ");
            string? palabra = ReadLine();
            if(palabra != null && palabra.Length > 2)
            {

                List<char> palabraInversa = new List<char>(palabra.Reverse());
                for (int i = 0; i < palabra.Length; i++)
                {
                    if(palabra[i] == palabraInversa[i]) palindroma = true;
                    else
                    {
                        palindroma = false;
                        break;
                    }
                }
                if (palindroma == true) WriteLine($"{palabra} es palindroma");
                else WriteLine($"{palabra} no es palindroma");
                break;
            }
            else WriteLine("La palabra no es correcta");
        }
        }
    }
}
