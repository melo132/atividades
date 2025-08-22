class program
{
    static void Main()
    {
        Console.Write("Digite o primeiro valor (A): ");
        string inputA = Console.ReadLine();
        Console.Write("Digite o segundo valor (B): ");
        string inputB = Console.ReadLine();

        int a = int.Parse(inputA);
        int b = int.Parse(inputB);

        Console.WriteLine($"\nAntes da troca:\nA = {a}, B = {b}");

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"\nDepois da troca:\nA = {a}, B = {b}");
    }
}
