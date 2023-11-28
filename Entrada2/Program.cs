public class Entrada2
{
  public static void Main(string[] args)
  {
    Console.Write("Entre com seu nome completo: ");
    string nome = Console.ReadLine();

    Console.Write("Quantos quartos tem em sua casa? ");
    int quartos = int.Parse(Console.ReadLine());

    Console.Write("Quanto você ganha? ");
    float price = float.Parse(Console.ReadLine());

    Console.WriteLine(nome);
    Console.WriteLine(quartos);
    Console.WriteLine(price);
  }
}