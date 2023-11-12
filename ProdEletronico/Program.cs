using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite os dados do produto:");

        Console.Write("Código do produto: ");
        int codigoProduto = int.Parse(Console.ReadLine());

        Console.Write("Nome do produto: ");
        string nomeProduto = Console.ReadLine();

        Console.Write("Quantidade comprada: ");
        int quantidadeComprada = int.Parse(Console.ReadLine());

        Console.Write("Valor unitário: ");
        double valorUnitario = double.Parse(Console.ReadLine());

    
        double valorTotal = quantidadeComprada * valorUnitario;

        Console.WriteLine("\nResumo da venda:");
        Console.WriteLine($"Código do produto: {codigoProduto}");
        Console.WriteLine($"Nome do produto: {nomeProduto}");
        Console.WriteLine($"Quantidade comprada: {quantidadeComprada}");
        Console.WriteLine($"Valor unitário: R${valorUnitario:F2}");
        Console.WriteLine($"Valor total: R${valorTotal:F2}");
         Console.WriteLine($"Obrigadx e volte sempre!");
    }
}
