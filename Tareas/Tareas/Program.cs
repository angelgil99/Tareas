using System;

namespace Tareas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, voy a contar del 1 a 10");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Hola voy a contar hasta 10 ahora con un while...");
            int iContador = 1;
            while (iContador <= 10)

            {
                Console.WriteLine($"La Variable Icontador vale {iContador} ");
                iContador = iContador + 1;


            }

            Console.WriteLine();

            Console.WriteLine("Ahora voy a contas hasta 10 con un do.... while.");
            int iContadorDoWhile = 1;
            do
            {
                Console.Write($"{iContadorDoWhile} ");
                iContadorDoWhile++;
            } while (iContadorDoWhile <= 10);
            Console.WriteLine();

            //Console.WriteLine("Ingrese un numero n");
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 10;
            Console.WriteLine($"Se mostraran los numeros de 1 a {n} de dos en dos");
            int iContadorWhileDosEnDos = 1;
            while (iContadorWhileDosEnDos <= n)
            {
                Console.WriteLine(iContadorWhileDosEnDos);
                iContadorWhileDosEnDos = iContadorWhileDosEnDos + 2;
            }

            Console.WriteLine();

            Console.WriteLine("La Cuenta regresiva al despegue...");
            int iCuentaRegresiva = 10;
            do
            {
                //Thread.Sleep(1000);
                Console.WriteLine(iCuentaRegresiva);

                iCuentaRegresiva--;
            } while (iCuentaRegresiva > 0);
            Console.WriteLine("Despegue......!!!!!!");
            Console.WriteLine();

            Console.WriteLine("Los numeros del 1 al 10 menos el 2,5 y 9");
            /*for (int i=1; i<=10; i++)
            {
                if ((i !=2) && (i !=5) && (i !=9))
                {
                    Console.WriteLine(i);
                }
            }*/

            int iContadorSalteado = 1;
            while (iContadorSalteado <= 10)
            {
                if ((iContadorSalteado != 2) &&
                    (iContadorSalteado != 5) &&
                    (iContadorSalteado != 9))
                {
                    Console.WriteLine(iContadorSalteado);
                }
                iContadorSalteado++;
            }
            Console.WriteLine();




            Console.WriteLine("Imprimimos los numeros del uno al 30 salteando del 10 al 20");
            int iContador1a30 = 1;
            do
            {
                if ((iContador1a30 <= 10) || (iContador1a30 >= 20))
                {
                    Console.WriteLine(iContador1a30);
                }
                iContador1a30++;
            } while (iContador1a30 <= 30);
            Console.WriteLine();


            int iSumatoria = 0;
            int iContadorSumatoria = 1;
            while (iContadorSumatoria <= 10)
            {
                iSumatoria = iSumatoria + iContadorSumatoria;
                iContadorSumatoria++;
            }
            Console.WriteLine($"La sumatoria de numeros del 1 al 10 es {iSumatoria}");
            Console.WriteLine();

            Console.WriteLine("Imprimir la suma de los numeros pares entre 1 y 25");
            int iSumatoriaEntre1y25 = 0;
            int iContadorDe1a25 = 1;
            do
            {
                if ((iContadorDe1a25 % 2) == 0)


                {
                    iSumatoriaEntre1y25 += iContadorDe1a25;
                }
                iContadorDe1a25++;
            } while (iContadorDe1a25 <= 25);
            Console.WriteLine();



            Console.WriteLine("Multiplicacion de impares entre -10 y 10");
            int iMultipliacionImpares = 1;
            int iContadorImpares = -10;
            while (iContadorImpares <= 10)
            {
                if ((iContadorImpares % 2) != 0)
                {
                    iMultipliacionImpares *= iContadorImpares;
                }
                iContadorImpares++;
            }
            Console.WriteLine($"El Resultado es {iMultipliacionImpares}");
            Console.WriteLine();

            Console.WriteLine("Imprimimos la bella figura, triangulito");
            string salida = "@";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(salida);
                salida = salida + "@";
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("@");
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            Console.WriteLine("El Triangulo inverso. La maestria en for anidado");
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }

            Random random = new
                Random(DateTime.Now.Second);
            int iNumeroSecreto = random.Next(1, 50);
            int iNumeroIngresado;
            int iOportunidadActual = 1;

            Console.WriteLine("Pense un numero, trata de adivinarlo....");
            do
            {
                Console.WriteLine("Ingrese un numero");
                iNumeroIngresado = Convert.ToInt32(Console.ReadLine());

                if (iNumeroIngresado > iNumeroSecreto)
                {
                    Console.WriteLine("Ingresaste un Numero Mayor al que pense");
                }
                else if (iNumeroIngresado < iNumeroSecreto)
                {
                    Console.WriteLine("Ingresaste un Numero Menor al que pense");
                }
                else
                {
                    Console.WriteLine("Felicitaciones!! Adivinaste");
                }

                iOportunidadActual++;
            } while ((iOportunidadActual < 5) && (iNumeroIngresado != iNumeroSecreto));

            Console.WriteLine("********************************************************");
            Console.WriteLine(" Adivinaste!");
            Console.WriteLine("********************************************************");







            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
