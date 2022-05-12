using Exerc3.Entities;

Console.Write("Digite o nome do curso: ");
try
{
    string cnome = Console.ReadLine();
    Curso c = new Curso(cnome);
    Console.WriteLine("Deseja criar quantos alunos? ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("digite o nome do aluno: ");
        string nome = Console.ReadLine();
        Aluno a = new Aluno(nome);

        Console.WriteLine("Deseja matricular esse aluno no curso? S/N");
        char cha = char.Parse(Console.ReadLine());
        if (cha == 'S' || cha == 's')
        {
            c.AddAlunoCurso(a);
        }
        Console.WriteLine("Deseja Remover esse aluno no curso? S/N");
        cha = char.Parse(Console.ReadLine());
        if (cha == 'S' || cha == 's')
        {
            c.RemoveAlunoCurso(a);
        }
    }
    Console.WriteLine("Deseja criar quantas turmas? ");
    n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        c.CriaTurma();
    }
    c.Imprime();
    c.ImprimeTurmaEspecifica();
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}




