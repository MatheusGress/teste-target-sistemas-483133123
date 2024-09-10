namespace VerificaLetra
{
    static class Program
    {
        static void Main()
        {
            string? input;
            
            do
            {
                Console.Write("Digite a palavra que deseja verificar: ");
                input = Console.ReadLine();

                // Verifica se a entrada é nula ou apenas espaços em branco
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("A entrada não pode ser vazia. Por favor, tente novamente.");
                }

            } while (string.IsNullOrWhiteSpace(input));

            // Converte a entrada para maiúsculas
            input = input.ToUpper();

            int countA = 0;

            // Conta o número de ocorrências da letra 'A'
            foreach (char c in input)
            {
                if (c == 'A')
                {
                    countA++;
                }
            }

            // Define a frase conforme a quantidade
            string countLabel = countA == 1 ? "vez" : "vezes";
            
            // Determina o resultado com base na contagem de 'A'
            string result = countA > 0
                ? $"\nA letra 'A' foi encontrada {countA} {countLabel}."
                : "\nA letra 'A' não foi encontrada na palavra.";

            Console.WriteLine(result);
        }
    }
}
