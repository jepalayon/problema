using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public static void Criar()
        {
            while (true)
            {
                String mensagem = "Olá usuário, bem vindo ao programa\n" +
                    "\n  Utilizando programação funcional" +
                    "\n" +
                    "\n  Digite uma das opções abaixo:" +
                    "\n   0 - Sair do Programa" +
                    "\n   1 - Para Ler Arquivo" +
                    "\n   2 - Para Executar a Tabuada" +
                    "\n   3 - Calcular Média de Aluno";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());



                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVO)
                {
                    Console.WriteLine("================ Opção Ler Arquivo ======================");
                    Arquivo.Ler(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("================ Opção Tabuada ======================");
                    Console.WriteLine("Digite o número que deseja na Tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("================ Média do Aluno =======================");
                    Media.Aluno();


                }
                else
                {
                    Console.WriteLine("Opção inválida digita novamente!");
                }

            }
        }
    }
}
