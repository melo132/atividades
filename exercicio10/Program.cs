class program
{
    static void Main()
    {
        Console.Write("Digite o valor do produto (R$): ");
        double valorProduto = double.Parse(Console.ReadLine());

        Console.Write("Digite o percentual de desconto (%): ");
        double percentualDesconto = double.Parse(Console.ReadLine());

        double valorDesconto = valorProduto * (percentualDesconto / 100);

        double valorFinal = valorProduto - valorDesconto;

        Console.WriteLine($"\nValor do desconto: R$ {valorDesconto:F2}");
        Console.WriteLine($"Valor final com desconto: R$ {valorFinal:F2}");
    }
}
