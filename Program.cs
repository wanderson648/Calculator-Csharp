using System;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuCalculadora();
        }

        static void MenuCalculadora() 
        {
            Console.Clear();
            Console.WriteLine("\t\tCALCULADORA\n");
            Console.WriteLine("\t[ 1 ] - Operações básicas\n\n\t[ 2 ] - Outras operações\n\n\t[ 3 ] para sair");

            short op = short.Parse(Console.ReadLine());

            switch(op) 
            {
                case 1: CalcPadrao(); break;
                case 2: CalcCompleta(); break;
                case 3: FecharCalc(); break;
                default: MenuCalculadora(); break;
            }

        }

        static void FecharCalc() 
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tObrigado por usar nosso Sistema!\n");
            Console.WriteLine();
            System.Environment.Exit(0);
        }

        static void CalcPadrao() 
        {
           
            Console.Clear();

            Console.WriteLine("====================\n");
            Console.WriteLine("[1]: Soma");
            Console.WriteLine("[2]: Subtração");
            Console.WriteLine("[3]: Multiplicação");
            Console.WriteLine("[4]: Divisão\n\n");
            Console.WriteLine("[5]: Tela inicial");
            Console.WriteLine("\n=========================== ");
            Console.WriteLine("Selecione uma opção: ");

            short op = short.Parse(Console.ReadLine());

            switch(op) 
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Sair(); break;
                default: CalcPadrao(); break;
            }

            Console.ReadKey();

        }

        static void CalcCompleta() 
        {
            
            Console.Clear();
            Console.WriteLine("====================\n");
            Console.WriteLine("[1]: Raiz Quadrada ");
            Console.WriteLine("[2]: Porcentagem\n\n");
            Console.WriteLine("[3]: Tela inicial");

            Console.WriteLine("\n=========================== ");
            Console.WriteLine("Selecione uma opção: ");

            short op = short.Parse(Console.ReadLine());

            switch(op) 
            {
                case 1: RaizQuadrada(); break;
                case 2: Porcentagem(); break;
                case 3: MenuCalculadora(); break;
                default: CalcCompleta(); break;
            }

            Console.ReadKey();

        }

        static void Sair() 
        {
            MenuCalculadora();
            System.Environment.Exit(0);
        }

        static void Soma() 
        {
            Console.Clear();

            // usando a biblioteca Globalization 
            Console.WriteLine("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = valor1 + valor2;      

            Console.WriteLine($"O resultado é = [ {resultado.ToString("F1", CultureInfo.InvariantCulture)} ]");  
            Console.ReadKey();
            CalcPadrao();
        }

        static void Subtracao() 
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 - valor2;
            Console.WriteLine($"O resultado é = [ {resultado}] ");
            Console.ReadKey();
            CalcPadrao();
        }

        static void Multiplicacao() 
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            
            Console.WriteLine("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 * valor2;

            Console.WriteLine($"O resultado é = [ {resultado}] ");
            Console.ReadKey();
            CalcPadrao();

        }

        static void Divisao() 
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 / valor2;

            Console.WriteLine($"O resultado é = [ {resultado} ]");
            Console.ReadKey();
            CalcPadrao();
        }

        static void RaizQuadrada() 
        {
            Console.Clear();
            Console.WriteLine("Raiz quadrada de:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            double resultado = Math.Sqrt(valor);
            Console.WriteLine($"Raiz é = [ {resultado.ToString("F2", CultureInfo.InvariantCulture)} ]");

            Console.ReadKey();
            CalcCompleta();

        }

        static void Porcentagem() 
        {
            Console.Clear();
            Console.Write(": ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write(" % de: ");

            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            double resultado = valor1 * valor2 / 100;

            Console.WriteLine($" = [ {resultado.ToString("F2", CultureInfo.InvariantCulture)} ]");

            Console.ReadKey();
            CalcCompleta();
        }
    }
}
