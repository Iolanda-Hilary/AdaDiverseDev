using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        if (EhPalindromo(palavra))
        {
            Console.WriteLine($"A palavra '{palavra}' é um palíndromo.");
        }
        else
        {
            Console.WriteLine($"A palavra '{palavra}' não é um palíndromo.");
        }
    }

    static bool EhPalindromo(string palavra)
    {
        int comprimento = palavra.Length;
        for (int i = 0; i < comprimento / 2; i++)
        {
            if (palavra[i] != palavra[comprimento - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
