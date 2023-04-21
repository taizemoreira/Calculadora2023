using System;

namespace Calculadora
{
    class Program 
    {       
            //escopo global
            static string[] descricoesOperacao = new string[100]; //declaração e inicialização de arrays
            static int quantidadeOperacoesRealizadas = 0;

            static void Main(string[] args)
            {
                while (true)
                {
                    string opcao = MostrarMenu();

                    if (opcao == "S" || opcao == "s")
                        break;

                    if (OpcaoInvalida(opcao))
                        ApresentarMensagem("Opção inválida, tente novamente...", "ERRO");

                    else if (opcao == "5")
                        GerarTabuada();

                    else if (opcao == "6")
                        VisualizarOperacoesRealizadas();

                    else
                        RealizarOperacao(opcao);
                }
            }

            #region funções da calculadora
            static string MostrarMenu()
            {
                Console.Clear();

                // Defina as cores do console
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                // Imprime o cabeçalho personalizado
                Console.WriteLine("+=========================================+");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|             CALCULADORA C#              |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("+=========================================+\n");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");
                Console.WriteLine("Digite 5 para Gerar Tabuada");
                Console.WriteLine("Digite 6 para Visualizar as operações realizadas");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                return operacao;
            }

            static bool OpcaoInvalida(string opcao)
            {
                bool opcaoInvalida =
                    opcao != "1" &&
                    opcao != "2" &&
                    opcao != "3" &&
                    opcao != "4" &&
                    opcao != "5" &&
                    opcao != "6" &&
                    opcao != "S" &&
                    opcao != "s";

                return opcaoInvalida;
            }

            static void ApresentarMensagem(string mensagem, string tipo)
            {
                if (tipo == "ERRO")
                    Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(mensagem);
                Console.ReadLine();
                Console.ResetColor();
            }

            static void GerarTabuada()
            {
                Console.Write("Digite o número para gerar a tabuada: ");

                int tabuada = Convert.ToInt32(Console.ReadLine()); //5              

                for (int i = 1; i <= 10; i++) //i = i + 1 
                {
                    int resto = i % 2;
                    if (resto == 0)
                        Console.BackgroundColor = ConsoleColor.Red;
                    else
                        Console.BackgroundColor = ConsoleColor.Black;

                    int resultadoMultiplicacao = tabuada * i;

                    Console.WriteLine(tabuada + " x " + i + " = " + resultadoMultiplicacao);
                }

                Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;
            }

            static void VisualizarOperacoesRealizadas()
            {
                for (int i = 0; i < descricoesOperacao.Length; i++)
                {
                    if (descricoesOperacao[i] != null)
                        Console.WriteLine(descricoesOperacao[i]);
                }

                Console.ReadLine();
            }

            static decimal ObterValorDecimal(string mensagem)
            {
                Console.WriteLine();

                Console.Write(mensagem);

                decimal numero = Convert.ToDecimal(Console.ReadLine());

                return numero;
            }

            static void RegistrarCalculo(decimal primeiroNumero, string sinalOperacao, decimal segundoNumero, decimal resultado)
            {
                descricoesOperacao[quantidadeOperacoesRealizadas] =
                        primeiroNumero + " " + sinalOperacao + " " + segundoNumero + " = " + resultado;

                quantidadeOperacoesRealizadas++;
            }

            static void RealizarOperacao(string operacao)
            {
                decimal primeiroNumero = ObterValorDecimal("Digite o primeiro número: ");

                decimal segundoNumero = ObterValorDecimal("Digite o segundo número: ");

                decimal resultado = ObterResultado(operacao, primeiroNumero, ref segundoNumero);

                Console.ForegroundColor = ConsoleColor.Yellow;
                ApresentarMensagem($"O resultado da operação é: {resultado}", "SUCESSO");
                
                Console.ResetColor();

                string sinalOperacao = ObterSinalOperacao(operacao);

                RegistrarCalculo(primeiroNumero, sinalOperacao, segundoNumero, resultado);
            }

            static string ObterSinalOperacao(string operacao)
            {
                string sinalOperacao = "";

                switch (operacao)
                {
                    case "1": sinalOperacao = "+"; break;
                    case "2": sinalOperacao = "-"; break;
                    case "3": sinalOperacao = "*"; break;
                    case "4": sinalOperacao = "/"; break;

                    default:
                        break;
                }

                return sinalOperacao;
            }

            static decimal ObterResultado(string operacao, decimal primeiroNumero, ref decimal segundoNumero)
            {
                decimal resultado = 0;

                switch (operacao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;
                    case "2": resultado = primeiroNumero - segundoNumero; break;
                    case "3": resultado = primeiroNumero * segundoNumero; break;
                    case "4":
                        {
                            while (segundoNumero == 0)
                            {
                                ApresentarMensagem("Segundo número não pode ser ZERO, tente novamente", "ERRO");

                                Console.Write("Digite o segundo número: ");

                                segundoNumero = Convert.ToInt32(Console.ReadLine());
                            }

                            resultado = primeiroNumero / segundoNumero;
                            break;
                        }

                    default:
                        break;
                }

                return Math.Round(resultado, 2);
            }

            #endregion
     }
}
