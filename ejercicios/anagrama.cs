using static System.Console;
//using static System.Math;

namespace anagrama
{
    class Program
    {
        public static void anag()
        {
            while(true)
            {
                WriteLine("Introduce la primera palabra");
                string? palabra1 = ReadLine();
                WriteLine("Introduce la segunda palabra");
                string? palabra2 = ReadLine();
                
                if(palabra1 != null && palabra2 != null)
                {
                    if(palabra1 != "" || palabra2 != "")
                    {
                        char[] letras1 = palabra1.ToLower().ToCharArray();
                        char[] letras2 = palabra2.ToLower().ToCharArray();

                        Array.Sort(letras1);
                        Array.Sort(letras2);

                        bool sonAnagramas = letras1.SequenceEqual(letras2);

                        if (sonAnagramas)
                        {
                            WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
                        }
                        else
                        {
                            WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
                        }
                        break;
                    }
                }
            }
        }
    }
}