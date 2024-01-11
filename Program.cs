using System;

namespace TPFinal_BertiSebastian
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            //a. El mayor de los números pares.
            //b. La cantidad de números impares.
            //c. El menor de los números primos.

            //Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
            int numero, maximoPar = 0, contadorImpares = 0, menorPrimo = 0;
            bool banderaPar = false;
            bool banderaPrimo = false;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {

                if (numero % 2 == 0)
                {
                    if (banderaPar == false)
                    {
                        maximoPar = numero;
                        banderaPar = true;
                    }

                    else if (numero > maximoPar)
                        maximoPar = numero;
                }
                else
                {
                    contadorImpares++;
                }

                if (buscarPrimo(numero) == true)
                {
                    if (banderaPrimo == false)
                    {
                        menorPrimo = numero;
                        banderaPrimo = true;
                    }

                }


                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El mayor de los numeros pares es: " + maximoPar);
            Console.WriteLine("La cantidad de numeros impares es: " + contadorImpares);
            Console.WriteLine("El menor de los numeros primos es: " + menorPrimo);

        }


        static bool buscarPrimo(int n)
        {
            int con = 0;
            for (int x = 1; x <= n; x++)
            {
                if (n % x == 0)
                    con++;
            }
            if (con == 2)
                return true;
            else
                return false;
        }
    }
}
