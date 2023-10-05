
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o Ano Atual: ");
        int AnoAtual = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o Ano do seu Nascimento: ");
        int AnoNasc = Convert.ToInt32(Console.ReadLine());
        int idade = AnoNasc - AnoAtual;

        Console.WriteLine($"Sua idade é {idade} anos");

    }
}
