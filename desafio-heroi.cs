using System;

class DesafioHeroi
{
    static void Main(string[] args)
    {
       
        Console.Write("Digite o nome do Herói: ");
        string nomeDoHeroi = Console.ReadLine();

        
        while (true)
        {
            
            Console.Write($"\nDigite a quantidade de XP para {nomeDoHeroi} (ou 'sair' para terminar): ");
            string entradaXP = Console.ReadLine();

            
            if (entradaXP.ToLower() == "sair")
            {
                break; // Encerra o laço de repetição
            }

           
            int xpHeroi;
            if (int.TryParse(entradaXP, out xpHeroi))
            {
                

                string nivelDoHeroi = "";

               
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
                else 
                    nivelDoHeroi = "Radiante";
                }

               
                Console.WriteLine($"O Herói de nome **{nomeDoHeroi}** está no nível de **{nivelDoHeroi}**");
            }
            else
            {
                
                Console.WriteLine("Entrada inválida. Por favor, digite um número para o XP ou 'sair'.");
            }
        }

        Console.WriteLine("\nJogo finalizado.");
    }
}