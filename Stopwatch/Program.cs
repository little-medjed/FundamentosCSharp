using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\nSTOPWATCH\n");

            Console.WriteLine("Digite um s no final para segundos. Ex: 10s = 10 segundos");
            Console.WriteLine("Digite um m no final para minutos. Ex: 10m = 10 minutos");
            Console.WriteLine("x - Sair");
            Console.Write("\nQuanto tempo? ");
            string tempo = Console.ReadLine().ToLower();

            if(tempo == "x") System.Environment.Exit(0);

            char type = char.Parse(tempo.Substring(tempo.Length - 1,1).ToLower());
            int time = int.Parse(tempo.Substring(0,tempo.Length - 1));

            Temporizador(time, type);
        }

        static void Temporizador(int time, char type)
        {
            int currentTime = 0;
            int multiplier = 1;

            if(type == 'm') multiplier = 60;

            while(currentTime != time)
            {   
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000*multiplier);
            }

            Console.Clear();
            Console.WriteLine("Terminado!");
            Thread.Sleep(1000);
        }       
    }
}

