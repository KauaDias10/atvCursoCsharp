/* 
Este aplicativo de console em C# é projetado para:
- Usar arrays para armazenar nomes de alunos e notas de tarefas.
- Usar uma instrução `foreach` para iterar pelos nomes dos alunos como um loop externo do programa.
- Usar uma instrução `if` dentro do loop externo para identificar o nome do aluno atual e acessar as notas das suas tarefas.
- Usar uma instrução `foreach` dentro do loop externo para iterar pelo array de notas de tarefas e somar os valores.
- Usar um algoritmo dentro do loop externo para calcular a média das notas dos exames para cada aluno.
- Usar uma estrutura `if-elseif-else` dentro do loop externo para avaliar a média das notas dos exames e atribuir uma nota final automaticamente.
- Integrar notas de crédito extra ao calcular a nota final e a letra correspondente do aluno da seguinte forma:
    - Detectar tarefas de crédito extra com base no número de elementos no array de notas do aluno.
    - Dividir os valores das tarefas de crédito extra por 10 antes de adicionar as notas de crédito extra à soma das notas dos exames.
- Usar o seguinte formato de relatório para reportar as notas dos alunos:

    Aluno           Nota

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/

int tarefasDeExame = 5;

string[] nomesDosAlunos = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] notasSophia = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] notasAndrew = new int[] { 92, 89, 81, 96, 90, 89 };
int[] notasEmma = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] notasLogan = new int[] { 90, 95, 87, 88, 96, 96 };

int[] notasDoAluno = new int[10];

string notaFinalDoAluno = "";

Console.Clear();
Console.WriteLine("Aluno\tNota do Exame\tNota Final\tNota em Letra\tCrédito Extra\n");

foreach (string nome in nomesDosAlunos)
{
    string alunoAtual = nome;

    if (alunoAtual == "Sophia")
        notasDoAluno = notasSophia;
    else if (alunoAtual == "Andrew")
        notasDoAluno = notasAndrew;
    else if (alunoAtual == "Emma")
        notasDoAluno = notasEmma;
    else if (alunoAtual == "Logan")
        notasDoAluno = notasLogan;

    int somaNotasExame = 0;
    int somaNotasCreditoExtra = 0;

    int tarefasCorrigidas = 0;

    foreach (int nota in notasDoAluno)
    {
        tarefasCorrigidas += 1;

        if (tarefasCorrigidas <= tarefasDeExame)
            somaNotasExame += nota;
        else
            somaNotasCreditoExtra += nota;
    }

    decimal mediaNotasExame = (decimal)somaNotasExame / tarefasDeExame;
    decimal mediaNotasCreditoExtra = (decimal)somaNotasCreditoExtra / (tarefasCorrigidas - tarefasDeExame);

    // Calcula a pontuação numérica final
    decimal pontuacaoFinal = somaNotasExame + (0.1m * somaNotasCreditoExtra);
    pontuacaoFinal /= tarefasDeExame;

    // Calcula os pontos de crédito extra
    decimal pontosCreditoExtra = (0.1m * somaNotasCreditoExtra) / tarefasDeExame;

    if (pontuacaoFinal >= 97)
        notaFinalDoAluno = "A+";
    else if (pontuacaoFinal >= 93)
        notaFinalDoAluno = "A";
    else if (pontuacaoFinal >= 90)
        notaFinalDoAluno = "A-";
    else if (pontuacaoFinal >= 87)
        notaFinalDoAluno = "B+";
    else if (pontuacaoFinal >= 83)
        notaFinalDoAluno = "B";
    else if (pontuacaoFinal >= 80)
        notaFinalDoAluno = "B-";
    else if (pontuacaoFinal >= 77)
        notaFinalDoAluno = "C+";
    else if (pontuacaoFinal >= 73)
        notaFinalDoAluno = "C";
    else if (pontuacaoFinal >= 70)
        notaFinalDoAluno = "C-";
    else if (pontuacaoFinal >= 67)
        notaFinalDoAluno = "D+";
    else if (pontuacaoFinal >= 63)
        notaFinalDoAluno = "D";
    else if (pontuacaoFinal >= 60)
        notaFinalDoAluno = "D-";
    else
        notaFinalDoAluno = "F";

    Console.WriteLine($"{alunoAtual}\t\t{mediaNotasExame:F2}\t{pontuacaoFinal:F2}\t\t{notaFinalDoAluno}\t\t{pontosCreditoExtra:F2}");
}

Console.WriteLine("\n\rPressione a tecla Enter para continuar");
Console.ReadLine();
