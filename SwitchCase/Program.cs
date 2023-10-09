using System;

class Program
{
    const int CursoProgramacao = 1;
    const int CursoDesignGrafico = 2;
    const int CursoMarketingDigital = 3;

    const char TurmaManha = 'A';
    const char TurmaTarde = 'B';
    const char TurmaNoite = 'C';

    static void Main()
    {
        MostrarOpcoesDeCursos();

        int escolhaCurso = int.Parse(Console.ReadLine());

        switch (escolhaCurso)
        {
            case CursoProgramacao:
                EscolherTurma("Programação", TurmaManha, TurmaTarde, TurmaNoite);
                break;
            case CursoDesignGrafico:
                EscolherTurma("Design Gráfico", 'X', 'Y', 'Z');
                break;
            case CursoMarketingDigital:
                EscolherTurma("Marketing Digital", 'I', 'II', 'III');
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha um curso válido.");
                break;
        }
    }

    static void MostrarOpcoesDeCursos()
    {
        Console.WriteLine("Escolha um curso:");
        Console.WriteLine($"{CursoProgramacao} - Curso de Programação");
        Console.WriteLine($"{CursoDesignGrafico} - Curso de Design Gráfico");
        Console.WriteLine($"{CursoMarketingDigital} - Curso de Marketing Digital");
        Console.Write("Digite o número do curso desejado (Apenas o numero): ");
    }

    static void EscolherTurma(string curso, char turmaManha, char turmaTarde, char turmaNoite)
    {
        Console.WriteLine($"Você escolheu o Curso de {curso}.");
        Console.WriteLine("Turmas disponíveis:");
        Console.WriteLine($"{turmaManha} - Turma da manhã");
        Console.WriteLine($"{turmaTarde} - Turma da tarde");
        Console.WriteLine($"{turmaNoite} - Turma da noite");
        Console.Write("Digite a letra da turma desejada(Aponas a letra): ");
        char escolhaTurma = char.Parse(Console.ReadLine());
        Console.WriteLine($"Você está na Turma {escolhaTurma} do Curso de {curso}.");
    }
}
