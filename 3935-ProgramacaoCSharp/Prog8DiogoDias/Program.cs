/*
 * Criar uma aplicação do tipo SlotMachine usando os números de 0 a 7 em que o apostador poderá fazer licitações de aposta.
 * O programa deverá sortear três números e contar o número de setes sorteados procedendo do seguinte modo:
 * - 0 Setes: escreve “Azar perdeu o Valor da Aposta"
 * - 1 Sete: escreve “Tente outra vez: Não perdeu o Valor da Aposta"
 * - 2 Setes: escreve “Sorte ganhou o dobro da Aposta"
 * - 3 Setes: escreve “SORTE GRANDE: Ganhou o Quíntuplo da Aposta"
 * Nesta aplicação o utilizador começa com 100 pontos e poderá apostar o valor menor ou igual ao valor dos
 * pontos que tem. Se atingir o valor de zero pontos escreve “Perdeu o Jogo e termina a aplicação.
 * OBS: Vamos adicionar uma tabela de pontuação para que o utilizador possa ver o seu progresso.
 * OBS2: Vamos guardar o nome do utilizador e a sua pontuação máxima em ficheiro txt e carregar a pontuação máxima e o nome do user.
 * A aplicação deverá ter um menu com as seguintes opções:
 * Novo jogo;
 * Pontuação Máxima;
 * Tabela Score;
 */
using System;
using System.IO;
using System.Linq;

namespace Prog8DiogoDias
{
    internal class Program
    {
        static int pontos = 100;  // Pontos iniciais
        static string nomeUser = "";
        static int pontuacaoMaxima = 0;
        static string caminhoArquivo = "pontuacaoMaxima.txt";  // Arquivo para salvar a pontuação máxima

        static void Main(string[] args)
        {
            CarregarPontuacaoMaxima();  // Carrega pontuação máxima do arquivo
            Menu();  // Exibe o menu principal
        }

        // Função principal do menu
        static void Menu()
        {
            bool sair = false;

            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("=== Slot Machine ===");
                Console.WriteLine("1. Novo Jogo");
                Console.WriteLine("2. Ver Pontuação Máxima");
                Console.WriteLine("3. Tabela de Score");
                Console.WriteLine("4. Sair");

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        NovoJogo();
                        break;
                    case "2":
                        VerPontuacaoMaxima();
                        break;
                    case "3":
                        TabelaScore();
                        break;
                    case "4":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        // Função que executa o novo jogo
        static void NovoJogo()
        {
            Console.Clear();
            Console.Write("Digite seu nome: ");
            nomeUser = Console.ReadLine();

            while (pontos > 0)
            {
                Console.WriteLine($"\nPontos disponíveis: {pontos}");
                Console.Write("Quanto deseja apostar? ");
                int aposta = int.Parse(Console.ReadLine());

                if (aposta > pontos || aposta <= 0)
                {
                    Console.WriteLine("Aposta inválida! Tente um valor dentro do seu saldo.");
                    continue;
                }

                // O jogador escolhe um número para apostar
                Console.Write("Escolha um número de 0 a 7 para apostar: ");
                int numeroApostado = int.Parse(Console.ReadLine());

                if (numeroApostado < 0 || numeroApostado > 7)
                {
                    Console.WriteLine("Número inválido! Escolha um número entre 0 e 7.");
                    continue;
                }

                // Sorteia três números de 0 a 7
                Random rand = new Random();
                int[] numeros = { rand.Next(0, 8), rand.Next(0, 8), rand.Next(0, 8) };
                int contadorSetes = numeros.Count(n => n == 7);

                // Exibe os números sorteados
                Console.WriteLine($"\nNúmeros sorteados: {numeros[0]} {numeros[1]} {numeros[2]}");

                // Avalia se o número apostado está entre os números sorteados
                if (numeros.Contains(numeroApostado))
                {
                    Console.WriteLine($"Você acertou! Ganhou o valor da aposta: {aposta} pontos.");
                    pontos += aposta;
                }
                else
                {
                    Console.WriteLine("Você não acertou o número apostado.");
                    Console.WriteLine("Azar, perdeu o valor da aposta!");
                    pontos -= aposta;
                }

                // Avalia o número de setes e aplica as regras do jogo
                switch (contadorSetes)
                {
                    case 1:
                        Console.WriteLine("Tente outra vez: Não perdeu o valor da aposta.");
                        break;
                    case 2:
                        Console.WriteLine("Sorte! Ganhou o dobro da aposta!");
                        pontos += aposta;
                        break;
                    case 3:
                        Console.WriteLine("SORTE GRANDE! Ganhou o quíntuplo da aposta!");
                        pontos += aposta * 4;
                        break;
                }

                // Atualiza a pontuação máxima se aplicável
                if (pontos > pontuacaoMaxima)
                {
                    pontuacaoMaxima = pontos;
                    SalvarPontuacaoMaxima();
                }

                // Verifica se o jogador perdeu todos os pontos
                if (pontos <= 0)
                {
                    Console.WriteLine("Você perdeu o jogo! Ficou sem pontos.");
                    break;
                }

                // Pergunta se deseja continuar jogando
                Console.WriteLine("Deseja continuar jogando? (s/n)");
                if (Console.ReadLine().ToLower() != "s")
                {
                    break;
                }
            }
        }


        // Função que exibe a pontuação máxima
        static void VerPontuacaoMaxima()
        {
            Console.Clear();
            Console.WriteLine($"Pontuação máxima: {pontuacaoMaxima} pontos por {nomeUser}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }

        // Função que exibe a tabela de score (pontuação atual do jogador)
        static void TabelaScore()
        {
            Console.Clear();
            Console.WriteLine("=== Tabela de Score ===");
            Console.WriteLine($"Nome: {nomeUser}");
            Console.WriteLine($"Pontuação Atual: {pontos}");
            Console.WriteLine($"Pontuação Máxima: {pontuacaoMaxima}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }

        // Função para salvar a pontuação máxima em arquivo
        static void SalvarPontuacaoMaxima()
        {
            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                writer.WriteLine(nomeUser);
                writer.WriteLine(pontuacaoMaxima);
            }
        }

        // Função para carregar a pontuação máxima de um arquivo
        static void CarregarPontuacaoMaxima()
        {
            if (File.Exists(caminhoArquivo))
            {
                using (StreamReader reader = new StreamReader(caminhoArquivo))
                {
                    nomeUser = reader.ReadLine();
                    pontuacaoMaxima = int.Parse(reader.ReadLine());
                }
            }
            else
            {
                nomeUser = "N/A";
                pontuacaoMaxima = 0;
            }
        }
    }
}
