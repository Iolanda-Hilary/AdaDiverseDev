using System;

class Program
{
    static void Main()
    {
        int[] A = new int[10];
        int[] B = new int[10];
        int[] C = new int[10];

    

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o valor de A[" + i + "]: ");
            A[i] = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B[" + i + "]: ");
            B[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < 10; i++)
        {
            C[i] = A[i] + B[9 - i];
        }

    
        Console.WriteLine("Vetor C:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("C[" + i + "] = " + C[i]);
        }
    }
}
