public class Program
{
    public static void Main(string[] args)
    {
        int numero;

        Console.Write("digite o valor: ");
        numero = int.Parse(Console.ReadLine());
        Console.WriteLine("O seu antecessor é: \n" + (numero - 1) + "\n");
        Console.WriteLine("O seu antecessor é: \n" + (numero + 1) + "\n");
    }

}
