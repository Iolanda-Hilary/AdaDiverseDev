using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o peso dos peixes em quilos: ");
        double pesoDosPeixes = double.Parse(Console.ReadLine());
        double limiteDePeso = 50.0;

        if (pesoDosPeixes > limiteDePeso) 
        {
            double excesso = pesoDosPeixes - limiteDePeso;
            double valorDaMulta = excesso * 4.0;

            Console.WriteLine($"Excesso de peso: {excesso:F2} quilos");
            Console.WriteLine($"Valor da multa: R${valorDaMulta:F2}");
        }
        else
        {
            Console.WriteLine("Excesso de peso: 0,00 quilos");
            Console.WriteLine("Valor da multa: R$0,00");
        }
    }
}
