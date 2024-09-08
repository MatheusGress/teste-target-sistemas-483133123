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

        // Converte a entrada para maiúsculas
        input = input.ToUpper();

        int countA = 0;

        foreach (char c in input)
        {
            if (c == 'A')
            {
                countA++;
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