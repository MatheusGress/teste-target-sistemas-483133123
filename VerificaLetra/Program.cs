namespace VerificaLetra
{
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

            // Operação ternária para determinar "vez" ou "vezes"
            string resultado = countA > 0
                ? $"\nA letra 'A' foi encontrada {countA} {(countA == 1 ? "vez" : "vezes")}."
                : "\nA letra 'A' não foi encontrada na palavra.";

            Console.WriteLine(resultado);
        }
    }
}

