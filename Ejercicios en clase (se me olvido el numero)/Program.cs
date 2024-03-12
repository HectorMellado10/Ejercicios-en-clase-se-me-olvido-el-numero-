using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            MostrarMenu();
            opcion = ObtenerOpcion();

            switch (opcion)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    AdivinarNumeroNuevo();
                    break;
                case 3:
                    ContadorPalabras();
                    break;
                case 4:
                    VerificarPalindromo();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                    break;
            }

        } while (opcion != 0);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Menú:");
        Console.WriteLine("1. Ejercicio 1 - Números Mayor y Menor");
        Console.WriteLine("2. Ejercicio 2 - Adivinar Número");
        Console.WriteLine("3. Ejercicio 3 - Contador de Palabras y Vocales");
        Console.WriteLine("4. Ejercicio 4 - Verificar Palíndromo");
        Console.WriteLine("0. Salir del programa");
    }

    static int ObtenerOpcion()
    {
        Console.Write("Ingresa tu opción: ");
        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            return opcion;
        }
        else
        {
            Console.WriteLine("Opción no válida. Por favor, ingresa un número.");
            return -1;
        }
    }

    static void Ejercicio1()
    {
        int numero;
        int maximo = int.MinValue;
        int minimo = int.MaxValue;

        do
        {
            Console.Write("Ingresa un número aleatorio (0 se utiliza para cerrar el programa o para finalizar el conteo): ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero != 0)
                {
                    if (numero > maximo)
                        maximo = numero;

                    if (numero < minimo)
                        minimo = numero;
                }
            }
            else
            {
                Console.WriteLine("Número no válido. Por favor, ingresa un número válido.");
            }

        } while (numero != 0);

        Console.WriteLine($"El número máximo ingresado fue: {maximo}");
        Console.WriteLine($"El número mínimo ingresado fue: {minimo}");
    }

    static void AdivinarNumeroNuevo()
    {
        Console.Write("Ingrese el número que salga de esta operacion: " +
            "1:Use un numero cualquiera  " +
            "2-Dicho numero lo multiplica por 2:  " +
            "3-Súmale 8 al resultado  " +
            "4-Al resultado multiplícalo por 5: " +
            "el resultado pongalo en el programa: ");

        if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
        {
            int resultado = RealizarNuevaAdivinanza(numeroIngresado);
            Console.WriteLine($"El resultado de la operación es: {resultado}");
        }
        else
        {
            Console.WriteLine("Número no válido. Por favor, ingresa un número válido.");
        }
    }

    static int RealizarNuevaAdivinanza(int numero)
    {
        int resultado = numero / 10;  
        resultado -= 4;  
        return resultado;
    }

    static void ContadorPalabras()
    {
        Console.Write("Ingresa una frase: ");
        string frase = Console.ReadLine();

        int contadorPalabras = 0;
        int contadorVocales = 0;

        foreach (char caracter in frase)
        {
            if (char.IsWhiteSpace(caracter))
            {
                contadorPalabras++;
            }
            else if ("aeiouAEIOU".Contains(caracter))
            {
                contadorVocales++;
            }
        }

        
        contadorPalabras++;

        Console.WriteLine($"Número de palabras: {contadorPalabras}");
        Console.WriteLine($"Número de vocales: {contadorVocales}");
    }

    static void VerificarPalindromo()
    {
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine();

        bool esPalindromo = true;
        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - i - 1])
            {
                esPalindromo = false;
                break;
            }
        }

        if (esPalindromo)
        {
            Console.WriteLine($"{palabra} es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"{palabra} no es un palíndromo.");
        }
    }
}
