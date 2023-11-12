using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a nota da Prova 1: ");
        double prova1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota da Prova 2: ");
        double prova2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota da Prova 3: ");
        double prova3 = double.Parse(Console.ReadLine());

        double media = (prova1 + prova2 + prova3) / 3.0;

        if (media >= 7.0)
        {
            Console.WriteLine("O aluno foi aprovado com média " + media.ToString("F2"));
        }
        else
        {
            Console.Write("Digite a nota do exame final: ");
            double notaExame = double.Parse(Console.ReadLine());

            double mediaFinal = (media + notaExame) / 2.0;

            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("O aluno ficou para o exame final e foi aprovado com média final " + mediaFinal.ToString("F2"));
            }
            else
            {
                Console.WriteLine("O aluno ficou para o exame final, mas não foi aprovado. A média final é " + mediaFinal.ToString("F2"));
            }
        }
    }
}
