class Program{
    static void Main( string[] args)
    {
        Console.Write("Valor total da Conta: ")
        float valorConta = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Quanto de gorjeta você quer deixar? ")
        int valorGorjeta = Convert.ToInt32(Console.ReadLine());

        float gorjetaFinal = valorConta * valorGorjeta / 100;
        float valorTotal = gorjetaFinal + valorConta;
        Console.WriteLine($"Você pagará {valorTotal} no total esta noite")


    }
}