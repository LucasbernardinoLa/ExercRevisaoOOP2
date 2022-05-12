using Exerc2.Entities;

Console.WriteLine("Digite quantos alunos serão cadastrados na turma: ");
Turma t = new Turma();
try
{
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine();
        Console.WriteLine("Digite o nome do aluno: ");
        string nome = Console.ReadLine();
        Console.WriteLine();
        Aluno a = new Aluno(nome);
        a.LancarNota();
        t.AddAluno(a);     
    }
    Console.WriteLine();
    t.ImprimeLista();
    t.ImprimeEstatisca();
}
catch(FormatException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


