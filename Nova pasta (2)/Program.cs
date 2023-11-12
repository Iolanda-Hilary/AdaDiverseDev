class Program{
    static void Main(){

        string resp = "";

        while (resp.ToLower() != "sair" || "X") {

        int pares = 0;
        int impares =0;
        int positivos = 0;
        int negativos = 0;

        for (int i = 0, i<5; i++){
            try {
                Console.Write($"Escreva o { i + 1}º numero");
                int numeroDig = int.tryParse(Console.Readline());

                if (numeroDig == 0)
                {
                    Console.WriteLine("O numero zero não atende aos requisitos, tente outro numero!")
                }
                else if (numeroDig % 2 == 0){
                    pares++;
                }
                else {
                    impares++;
                }
                if (numeroDig == 0){
                    Console.WriteLine("O numero zero não atende aos requisitos, tente outro numero!")
                }
                else if (numeroDig > 0){
                    positivos++;
                }
                else{
                    negativos++;
                }
               
            }
            catch(FormatException){
                Console.WriteLine("Digite um numero válido - Inteiro")
                i--;
            }

        }
            }
        Console.WriteLine($"Numeros pares Digitados: ");
        Console.WriteLine($"Numeros ímpares Digitados: ");
        Console.WriteLine($"Valores Positivos: ");
        Console.WriteLine($"Valores Negativos : ");
        Console.WriteLine($"Para Sair, Digite 'sair' ou 'X'")
        resp = Console.ReadLine();
        }
    }
}