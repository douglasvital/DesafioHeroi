using System;

class DesafioHeroi
{
    static void Main(string[] args)
    {
        // Pede o nome do herói uma vez no início do programa
        Console.Write("Digite o nome do Herói: ");
        string nomeDoHeroi = Console.ReadLine();

        // Inicia um laço de repetição para continuar perguntando o XP
        while (true)
        {
            // Pede ao usuário para inserir o XP ou sair do programa
            Console.Write($"\nDigite a quantidade de XP para {nomeDoHeroi} (ou 'sair' para terminar): ");
            string entradaXP = Console.ReadLine();

            // Se o usuário digitar "sair" (ignorando maiúsculas/minúsculas), o loop para
            if (entradaXP.ToLower() == "sair")
            {
                break; // Encerra o laço de repetição
            }

            // Tenta converter o texto digitado para um número inteiro
            int xpHeroi;
            if (int.TryParse(entradaXP, out xpHeroi))
            {
                // Se a conversão for bem-sucedida, o código continua aqui

                string nivelDoHeroi = "";

                // Estrutura de decisão para classificar o nível com base no XP
                if (xpHeroi < 1000)
                {
                    nivelDoHeroi = "Ferro";
                }
                else if (xpHeroi >= 1001 && xpHeroi <= 2000)
                {
                    nivelDoHeroi = "Bronze";
                }
                else if (xpHeroi >= 2001 && xpHeroi <= 5000)
                {
                    nivelDoHeroi = "Prata";
                }
                else if (xpHeroi >= 5001 && xpHeroi <= 7000)
                {
                    nivelDoHeroi = "Ouro";
                }
                else if (xpHeroi >= 7001 && xpHeroi <= 8000)
                {
                    nivelDoHeroi = "Platina";
                }
                else if (xpHeroi >= 8001 && xpHeroi <= 9000)
                {
                    nivelDoHeroi = "Ascendente";
                }
                else if (xpHeroi >= 9001 && xpHeroi <= 10000)
                {
                    nivelDoHeroi = "Imortal";
                }
                else // Se for maior ou igual a 10001
                {
                    nivelDoHeroi = "Radiante";
                }

                // Exibe a mensagem final com o nível atualizado
                Console.WriteLine($"O Herói de nome **{nomeDoHeroi}** está no nível de **{nivelDoHeroi}**");
            }
            else
            {
                // Se o usuário digitar algo que não é um número, exibe esta mensagem de erro
                Console.WriteLine("Entrada inválida. Por favor, digite um número para o XP ou 'sair'.");
            }
        }

        Console.WriteLine("\nJogo finalizado.");
    }
}