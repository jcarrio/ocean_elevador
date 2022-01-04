using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usuário define a capacidade de pessoas no elevador, e o total de andares do prédio
            Console.Write("Capacidade do elevador: ");
            var capacidade = int.Parse(Console.ReadLine());
            Console.Write("Total de andares: ");
            var andares = int.Parse(Console.ReadLine());

            // Inicializa uma instância do elevador com a capacidade de pessoas e o total de andares
            // definidos pelo usuário
            Elevador elevador = new Elevador();
            elevador.Inicializar(capacidade, andares);

            int acao;
            string mensagem = null;
            // Repete código enquanto usuário não pede para fechar o programa
            do
            {
                // Exibe na tela as propriedades do elevador
                Console.Clear();
                Console.WriteLine($"Capacidade do elevador: {capacidade}");
                Console.WriteLine($"Total de andares: {andares}");
                Console.WriteLine($"Pessoas no elevador: {elevador.Pessoas()}");
                Console.WriteLine($"Andar atual: {elevador.Andar()}\n");
                // Exibe na tela um menu de opções para o usuário escolher
                Console.WriteLine("1 - Entrar");
                Console.WriteLine("2 - Sair");
                Console.WriteLine("3 - Subir");
                Console.WriteLine("4 - Descer");
                Console.WriteLine("5 - Fechar\n");
                // Se existir alguma mensaem de erro, exibe na tela, e limpa a mensagem em seguida
                if (mensagem != null)
                {
                    Console.WriteLine($"Erro: {mensagem}");
                    mensagem = null;
                }
                else
                    Console.WriteLine();
                // Pergunta ao usuário qual ação deve ser executada, conforme as opções do menu
                Console.Write("Informe a ação: ");
                // Verifica se usuário digitou um número inteiro
                if (!int.TryParse(Console.ReadLine(), out acao))
                    acao = 0;
                // Valida as opções disponíveis no menu
                switch (acao)
                {
                    case 1:
                        // Informa entrada de uma pessoa no elevador, e se já estiver cheio, define mensagem de erro
                        if (!elevador.Entrar())
                            mensagem = "Elevador já está cheio";
                        break;
                    case 2:
                        // Informa saída de uma pessoa do elevador, e se já estiver vazio, define mensagem de erro
                        if (!elevador.Sair())
                            mensagem = "Elevador já está vazio";
                        break;
                    case 3:
                        // Informa subida de um andar do prédio, e se já estiver no último andar, define mensagem de erro
                        if (!elevador.Subir())
                            mensagem = "Elevador já está no último andar";
                        break;
                    case 4:
                        // Informa descida de um andar do prédio, e se já estiver no térreo, define mensagem de erro
                        if (!elevador.Descer())
                            mensagem = "Elevador já está no térreo";
                        break;
                    case 5:
                        // Informa que o programa está sendo fechado
                        Console.WriteLine("Fechando elevador...");
                        break;
                    default:
                        // Define mensagem de erro para ação inválida
                        mensagem = "Ação inválida";
                        break;
                }
            // Repete enquanto ação diferente de 5, fechar
            } while (acao != 5);
        }
    }
}
