using System;
using System.Formats.Asn1;

class Program
{
    static void Main()
    {
        string? input;

        // Verifica se a entrada não é vazia
        do
        {
            Console.Write("Digite a palavra que deseja verificar: ");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("A entrada não pode ser vazia. Por favor, tente novamente.");
            }

        } while (string.IsNullOrWhiteSpace(input));

        int lowercaseACount = 0;
        int uppercaseACount = 0;

        // Loop para verificar cada caractere
        foreach (char c in input)
        {
            if (c == 'a')
            {
                lowercaseACount++;
            }
            else if (c == 'A')
            {
                uppercaseACount++;
            }
        }

        int totalACount = lowercaseACount + uppercaseACount;
        
        if (totalACount > 0)
        {
            Console.WriteLine($"\nA letra 'A' foi encontrada {totalACount} vez(es).");
        }
        else
        {
            Console.WriteLine("\nA letra 'A' não foi encontrada na palavra.");
        }
    }
}