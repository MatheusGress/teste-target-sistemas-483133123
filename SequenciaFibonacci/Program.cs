class Program
{
    static bool IsPerfectSquare(int x)
    {
        int square = (int)Math.Sqrt(x);
        return square * square == x;
    }

    static void Main()
    {
        // Verifica se o valor recebido mão é null
        try
        {
            Console.WriteLine("Digite o valor que deseja verificar na lista:");
            string? input = Console.ReadLine() ?? throw new ArgumentNullException();

            int number = int.Parse(input);
            
        // Verifica se o valor é uma raiz exata
            int sumCheck = 5 * number * number + 4;
            int subCheck = 5 * number * number - 4;

            if (IsPerfectSquare(sumCheck) || IsPerfectSquare(subCheck))
            {
                Console.WriteLine($"\nO número {number} pertence à sequência Fibonacci");
            }
            else
            {
                Console.WriteLine($"\nO número {number} não pertence à sequência Fibonacci");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
