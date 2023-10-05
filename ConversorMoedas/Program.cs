class Program{

    static void Main(string[] args)
    {
        Console.WriteLine("Oi, Digite o valor que voce gostaria de converter (Euro/Dolar)");
        float valor = Convert.ToSingle(Console.ReadLine());
        
        float euro = valor * 6.50;
        float dolar = valor * 5.50;

        Console.WriteLine($"Seus R${valor} valem {euro} Euros, e {dolar} Dolares");
    }
}