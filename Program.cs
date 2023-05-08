using static System.Console;

class Program
{
    public static void Main()
    {
        //Menú
        while (true)
        {
            WriteLine("Bienvenidos a los ejercicios de Algoritmos de C#.");
            WriteLine("1-dada una lista de números enteros, determina cuál es el mayor y cuál es el menor. ");
            WriteLine("2- Dado un número entero, determine si es par o impar.");
            WriteLine("3-determine si un año es bisiesto o no.");
            WriteLine("4- determine si una cadena de texto es un palíndromo o no.");
            WriteLine("5- Dada una lista de nombres, ordene la lista alfabéticamente.");
            WriteLine("6- calcule el factorial de un número entero. ");
            WriteLine("7- Dado un número entero, determine si es primo o no.");
            WriteLine("8- calcule el área y volumen de un cubo dado su lado. ");
            WriteLine("9- Dada una lista de números enteros, calcule la suma de todos los números pares de la lista.");
            WriteLine("10- determine si un número es positivo, negativo o cero.");
            WriteLine("11- Dada una lista de números enteros, calcule la media de la lista.");
            WriteLine("12- genere un número aleatorio entre 1 y 100, y adivinarlo.");
            WriteLine("13- determine si una cadena de texto es un anagrama de otra cadena de texto.");
            WriteLine("14- Dada una lista de números enteros, elimine los números duplicados de la lista.");
            WriteLine("15- determine si un número es capicúa o no.");
            WriteLine("0- Terminar ");

            WriteLine("Escoja una opción o 0 para terminar el programa: ");
            string? opcion = ReadLine();
            if(opcion == "1") new menorMayor.Program().meMay();
            if(opcion == "2") new parImpar.Program().parIm();
            if(opcion == "3") new anioBisiesto.Program().anioBi();
            if(opcion == "4") new palabraPalin.Program().palindroma();
            if(opcion == "5") new ordenarNombres.Program().ordenarNom();
            if(opcion == "6") new factorial.Program().fac();
            if(opcion == "7") new numeroPrimo.Program().primo();
            if(opcion == "8") new areaVolum.Program().areaVolumen();
            if(opcion == "9") new sumaNumeros.Program().numerosPares();
            if(opcion == "10") new posNegCero.Program().posNegaCero();
            if(opcion == "11") new mediaLista.Program().media();
            if(opcion == "12") new adivinarNumero.Program().adivNum();
            if(opcion == "13") new anagrama.Program().anag();
            if(opcion == "14") new eliminarDuplicados.Program().elimDupli();
            if(opcion == "15") new capicua.Program().capi();
            if(opcion == "0"){
                WriteLine("Nos vemos!");
                break;
            } 

            WriteLine("Pulsa para continuar");
            ReadLine();
            Clear();
        }
    }
}
