using static System.Console;
//using static System.Math;

namespace palabraPalin
{
    class Program
    {
        public void palindroma()
        {
            bool palindroma = false;
        while (true)
        {
            WriteLine("Introduce una palabra o frase: ");
            string? palabra = ReadLine();
            if(palabra != null)
            {
                string palabraOriginal = palabra;
                palabra = palabra.ToLower().Replace(" ", "");
                
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
                if (palindroma == true) WriteLine($"{palabraOriginal} es palindroma");
                else WriteLine($"{palabraOriginal} no es palindroma");
                break;
            }
            else WriteLine("La palabra no es correcta");
        }
        }
    }
}
