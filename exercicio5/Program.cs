public class Program
{
    public static void Main(string[] args) {
        int valor1, valor2, dinheiro;

        Console.Write("digite o valor: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine(" digite as horas trabalhadas: ");
        valor2 = int.Parse(Console.ReadLine());

        dinheiro = valor1 * valor2;

        Console.WriteLine("O valor pago no mês é: \n" + dinheiro);
    }
}
