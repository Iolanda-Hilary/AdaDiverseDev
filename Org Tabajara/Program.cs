using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o salário atual
        Console.Write("Digite o salário atual: R$ ");
        double salarioAtual;
        if (!double.TryParse(Console.ReadLine(), out salarioAtual))
        {
            Console.WriteLine("Valor inválido. Certifique-se de inserir um valor numérico válido.");
            return;
        }

        // Calcula o reajuste com base nas regras
        double percentualAumento;
        switch (salarioAtual)
        {
            case var _ when salarioAtual <= 280.00:
                percentualAumento = 20.0;
                break;
            case var _ when salarioAtual <= 700.00:
                percentualAumento = 15.0;
                break;
            case var _ when salarioAtual <= 1500.00:
                percentualAumento = 10.0;
                break;
            default:
                percentualAumento = 5.0;
                break;
        }

        double valorAumento = (percentualAumento / 100) * salarioAtual;
        double novoSalario = salarioAtual + valorAumento;

        // Exibe os resultados
        Console.WriteLine($"Salário antes do reajuste: R$ {salarioAtual:F2}");
        Console.WriteLine($"Percentual de aumento aplicado: {percentualAumento}%");
        Console.WriteLine($"Valor do aumento: R$ {valorAumento:F2}");
        Console.WriteLine($"Novo salário após o aumento: R$ {novoSalario:F2}");
    }
}

