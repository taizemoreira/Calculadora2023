/**Requisito 01
    Nossa calculadora deve ter a possibilidade de somar dois números [v]
*/
/**Requisito 02
    Nossa calculadora deve ter a possibilidade fazer várias operações de soma [v]
*/
/**Requisito 03
    Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração [v]
*/
/**Requisito 04
    Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática [v]
*/
/**Requisito 05
    Nossa calculadora deve realizar as operações com "0" [v]
*/
/**Requisito 06
    Nossa calculadora deve validar a opções do menu [v]
*/
/**Requisito 07
    Nossa calculadora deve realizar as operações com números com duas casas decimais [v]
*/
/**Requisito 08
    Nossa calculadora deve gerar a tabuada de multiplicação para um determinado número e apresentar numa visualização "rubro-negra" [v]
*/
/** Requisito 09
Nossa calculadora deve permitir visualizar as operações já realizadas [v]
* 
*  Critérios:
*      1 - A descrição da operação realizada deve aparecer assim, exemplo:
*          2 + 2 = 4
*          10 - 5 = 5
*/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "========== CALCULADORA ==========";
            int larguraTela = Console.WindowWidth;
            int larguraTexto = texto.Length;
            int espacos = (larguraTela / 2) + (larguraTexto / 2);
            Console.WriteLine(texto.PadLeft(espacos));

            double numero1, numero2, resultadoOperacao;

            Console.WriteLine("Informe o primeiro número: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            numero2 = double.Parse(Console.ReadLine());

            #region implementação do menu
                Console.WriteLine("(\nSelecione a operação desejada:\")");
                Console.WriteLine("1 - Somar dois números");
                Console.WriteLine("2 - Fazer várias operações de soma");
                Console.WriteLine("3 - Fazer subtração");
                Console.WriteLine("3 - Fazer multiplicação");
                Console.WriteLine("5 - Fazer divisao");
                Console.WriteLine("6 - Visualizar as operações já realizadas");
                Console.WriteLine("0 - Sair");

                // Lê a opção escolhida pelo usuário
                Console.Write("Digite sua opção (1/2/3/4/5/6/0): ");
                string opcaoOperacao = Console.ReadLine();                
            #endregion

            #region opcoes do menu             
            switch (opcaoOperacao)
            {

                case "1":
                    resultadoOperacao = numero1 + numero2;
                    break;

                case "2":
                    resultadoOperacao = numero1 - numero2;
                    break;

                case "3":
                    resultadoOperacao = numero1 * numero2;
                    break;

                case "4":
                    {
                        while (numero2 == 0)
                        {
                            Console.WriteLine("Segundo número não pode ser zero, tente de novo:");
                            Console.WriteLine();
                            Console.WriteLine("Digite o segundo número:");

                            numero2 = double.Parse(Console.ReadLine());
                        }
                        resultadoOperacao = numero1 / numero2;
                        break;
                    }

                default:
                    Console.WriteLine("mensagem...");
                    break;
            }                   
            #endregion

        }
    } 
}
            
            



