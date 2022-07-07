using System;

namespace Calculator
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
            Console.WriteLine("\nCALCULADORA \n");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.Write("\nSelecione uma operação: ");
            short operacao = short.Parse(Console.ReadLine());

            Console.WriteLine("\n-----------------------------\n");

            switch(operacao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine("Operação invalida\n"); Console.ReadKey(); Menu(); break;
            }
        }

        static void Soma()
        {
            Console.WriteLine("Insira um valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nResultado: " + (v1 + v2));

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Insira um valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nResultado: " + (v1 - v2));

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Insira um valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nResultado: " + (v1 * v2));

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Insira um valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nResultado: " + (v1 / v2));

            Console.ReadKey();
            Menu();
        }
    }
}
