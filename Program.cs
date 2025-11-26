using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Esperto Contra Sabido ---");
        Console.Write("Quantos alimentos serão distribuídos? ");

        // Ler a quantidade de alimentos
        if (int.TryParse(Console.ReadLine(), out int totalAlimentos) && totalAlimentos > 0)
        {
            int alimentosRaposinha = 0;
            int alimentosPicaPau = 0;

            for (int i = 1; i <= totalAlimentos; i++)
            {
                // Distribuição de alimentos
                if (i % 2 == 1) // Ímpar para a Raposinha
                {
                    alimentosRaposinha++;
                    Console.WriteLine($"{i} para você. {string.Join(", ", Enumerable.Range(1, i).Select(n => n))} para mim.");
                }
                else // Par para o Pica-Pau
                {
                    alimentosPicaPau++;
                    Console.WriteLine($"{i} para você. {string.Join(", ", Enumerable.Range(1, i).Select(n => n))} para mim.");
                }

                // Verifica se atingiu o total de alimentos
                if (alimentosRaposinha + alimentosPicaPau >= totalAlimentos)
                {
                    break;
                }
            }

            // Exibir resultados finais
            Console.WriteLine($"\nPica-Pau recebeu {alimentosPicaPau} alimento(s).");
            Console.WriteLine($"Raposinha recebeu {alimentosRaposinha} alimento(s).");
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido de alimentos.");
        }
    }
}
