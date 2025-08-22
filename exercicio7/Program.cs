public class Program
{
   public static void Main(string [] args)
    {
        int numero;
        Console.Write("digite um numero: ");
        numero = int.Parse(Console.ReadLine());
        Console.Write("seu dobro é: \n"+(numero * 2) + "\n");
        Console.Write("seu triplo é: \n" + (numero * 3) + "\n");
        Console.Write("sua raiz quadrada é: \n" + (numero/numero) + "\n");

    }
}
