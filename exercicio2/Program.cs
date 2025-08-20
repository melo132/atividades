public class Program
{
    public static void Main(string[] args) { 

        int neymar1, neymar2, neymar3, soma, divisão;

        Console.Write("Escreva três números: \n");
        neymar1 = int.Parse(Console.ReadLine());
        neymar2 = int.Parse(Console.ReadLine());
        neymar3 = int.Parse(Console.ReadLine());

        soma = (neymar1 + neymar2 + neymar3)/3;

        Console.WriteLine("O resultado da media é: \n" + soma);
    }
} 

