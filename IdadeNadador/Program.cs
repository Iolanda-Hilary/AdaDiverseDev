using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a idade do nadador: ");
        int idade = int.Parse(Console.ReadLine());

        string categoria = "";

        switch (idade)
        {
            case int i when i >= 5 && i <= 7:
                categoria = "Infantil A";
                break;
            case int i when i >= 8 && i <= 11:
                categoria = "Infantil B";
                break;
            case int i when i >= 12 && i <= 13:
                categoria = "Juvenil A";
                break;
            case int i when i >= 14 && i <= 17:
                categoria = "Juvenil B";
                break;
            case int i when i >= 18:
                categoria = "Adultos";
                break;
            default:
                categoria = "Idade não válida para categorias de nadador.";
                break;
        }


        Console.WriteLine($"O nadador está na categoria: {categoria}");
    }
}
