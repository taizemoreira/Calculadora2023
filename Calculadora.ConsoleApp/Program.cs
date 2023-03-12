//Primeiro Exercício da Academia do Programador 2023
//A Dona Mariana precisa de um sistema para calcular operações matemáticas simples, como adição, subtração,
//multiplicação e divisão entre dois números. Ela gostaria também de visualizar um histórico das operações realizadas.
//Requisito 01 --> Nossa calculadora deve ter a possibilidade de somar dois números [ok]
//Requisito 02 --> Nossa calculadora deve ter a possibilidade fazer várias operações de soma [ok]
//Requisito 03 --> Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração [ok]
//Requisito 04 --> Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática [ok]
//Requisito 05 --> Nossa calculadora deve realizar as operações com "0" [ok]
//Requisito 06 --> Nossa calculadora deve validar as opções do menu [ok]
//Requisito 07 --> Nossa calculadora deve realizar as operações com números com casas decimais [ok]
//Requisito 08 --> Nossa calculadora deve gerar a tabuada de multiplicação para um determinado número [ok]
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

                Console.WriteLine("Digite 1 para adicionar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite 5 para gerar tabuada");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if(operacao == "S" || operacao == "s")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5" && operacao != "S" && operacao != "s")
                {
                    Console.WriteLine("Operação inválida, tente novamente...");
                    Console.ReadLine();
                    continue;
                }

                if(operacao == "5")
                {
                    Console.WriteLine("Digite o número para gerar a tabuada: ");
                   
                    int tabuada = Convert.ToInt32(Console.ReadLine());

                    for(int i = 1; i <= 10; i = i + 1)
                    {
                        int resultadoMultiplicacao = tabuada * i;
                        Console.WriteLine(tabuada + " x " + i + " = " + resultadoMultiplicacao);
                    }
                
                    #region montando a tabuada com while
                    //int numero = 1;

                    //while (numero <= 10)
                    //{
                    //    int resultadoMultiplicacao = tabuada * numero;

                    //    Console.WriteLine(tabuada + " x " + numero + " = " + resultadoMultiplicacao);

                    //    // incremento
                    //    numero = numero + 1;
                    //}
                    #endregion

                    Console.ReadLine();
                    continue;
                }
                
                Console.WriteLine();

                Console.Write("Digite o primeiro número: ");

                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");

                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());
                
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
                                        Console.WriteLine("Segundo número não pode ser ZERO, tente novamente.");

                                        Console.ReadLine();

                                        Console.Write("Digite o segundo número");

                                        segundoNumero = Convert.ToInt32(Console.ReadLine());
                                    }

                            resultado = primeiroNumero / segundoNumero; 
                            break;
                        }

                    default:
                        break;
                }

                #region verifica o tipo de operação utilizando if- else if
                //bool ehAdicao = operacao == "1";
                //bool ehSubtracao = operacao == "2";
                //bool ehMultiplicacao = operacao == "3";
                //bool ehDivisao = operacao == "4";

                //if (ehAdicao)
                //{
                //    resultado = primeiroNumero + segundoNumero;
                //}
                //else if(ehSubtracao)
                //{
                //    resultado = primeiroNumero - segundoNumero;                  
                //}
                //else if(ehMultiplicacao)
                //{
                //    resultado = primeiroNumero * segundoNumero;                 
                //}
                //else if (ehDivisao)
                //{
                //    while(segundoNumero == 0)
                //    {
                //        Console.WriteLine("Segundo número não pode ser ZERO, tente novamente.");

                //        Console.ReadLine();

                //        Console.Write("Digite o segundo número");

                //        segundoNumero = Convert.ToInt32(Console.ReadLine());
                //    }
                //}
                #endregion

                decimal resultadoFormatado = Math.Round(resultado, 2);

                Console.WriteLine("O resultado da operação é: " + resultadoFormatado);
                
                Console.ReadLine();        

            } while (true);  

        }
    
    }
}