public class Program
{
    public static void Main(string[] args) {
        int valor1, valor2, área;

        Console.Write("selecione um numero: \n");
        valor1 = int.Parse(Console.ReadLine());
        Console.Write("selecione um numero: \n");
        valor2 = int.Parse(Console.ReadLine());

        área = valor1 * valor2;

        Console.WriteLine("O valor da área é equivalente a : \n" + área + "\n\n");
    }
}
