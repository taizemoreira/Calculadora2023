using System.Drawing;

namespace Calculadora.ConsoleApp
{
    internal class Program //classe
    {
         static void Main(string[] args)
        {
         do {
                Console.Clear();

                Console.WriteLine("Calculadora Top 2023");

                Console.WriteLine("Digite 1 para Adicionar: ");  
                Console.WriteLine("Digite 2 para Subtrair: ");
                Console.WriteLine("Digite 3 para Multiplicar: ");
                Console.WriteLine("Digite 4 para Dividir: ");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if(operacao == "S" || operacao == "s")
                {
                    break;
                }

                if(operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "S" && operacao != "s" )
                {
                    Console.WriteLine("Operação inválida, tente novamente...");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine();

                Console.Write("Digite o primeiro número: ");

                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite o segundo número: ");

                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                bool ehAdicao = operacao == "1";
                bool ehSubtracao = operacao == "2";
                bool ehMultiplicacao = operacao == "3";
                bool ehDivisao = operacao == "4";

                if (ehAdicao)
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                else if (ehSubtracao)
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                else if (ehMultiplicacao)
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                else if (ehDivisao)
                {
                    while(segundoNumero == 0)
                    {
                        Console.WriteLine("Segundo número não pode ser ZERO, tente novamente");

                        Console.ReadLine();

                        Console.Write("Digite o segundo número: ");

                        segundoNumero = Convert.ToInt32(Console.ReadLine());
                    }

                    resultado = primeiroNumero / segundoNumero;
                }

                decimal resultadoFormatado = Math.Round(resultado, 2);

                Console.WriteLine("O resultado da operação é: " + resultadoFormatado);

                Console.ReadLine();

                } while (true);            
        }
    }
}