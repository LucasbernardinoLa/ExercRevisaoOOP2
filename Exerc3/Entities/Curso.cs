namespace Exerc3.Entities
{
    internal class Curso
    {
        public string Nome { get; private set; }
        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();
        public List<Turma> Turmas { get; private set; } = new List<Turma>();

        public Curso(string nome)
        {
            Nome = nome;
        }

        public void CriaTurma()
        {
            Console.WriteLine();
            Console.WriteLine("Nova turma criada! ");
            Console.WriteLine();
            Turma t = new();
            AddTurma(t);
            Console.WriteLine("Deseja adicionar alunos nessa turma? S/N ");
            try
            {
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'S' || ch == 's')
                {
                    while (true)
                    {
                        Console.WriteLine();
                        Console.Write("Digite o nome do novo aluno: ");
                        Console.WriteLine();
                        string nome = Console.ReadLine();
                        Aluno alun = new Aluno(nome);

                        Console.WriteLine();
                        Console.WriteLine("O aluno será matriculado e vínculado com essa turma! Tem certeza disso? S/N");
                        ch = char.Parse(Console.ReadLine());
                        if (ch == 'S' || ch == 's')
                        {
                            alun.AddTurmaAluno(t);
                            AddAlunoCurso(alun);
                            t.AddAlunoTurma(alun);
                        }
                        Console.WriteLine("Deseja Remover esse aluno da turma? S/N");
                        ch = char.Parse(Console.ReadLine());
                        if (ch == 'S' || ch == 's')
                        {
                            t.RemoveAlunoTurma(alun);
                            alun.RemoveTurmaAluno(t);
                        }
                        Console.WriteLine("Deseja Remover esse aluno do curso? S/N");
                        ch = char.Parse(Console.ReadLine());
                        if (ch == 'S' || ch == 's')
                        {
                            RemoveAlunoCurso(alun);
                        }

                        Console.WriteLine("Ainda deseja adicionar mais alunos? S/N");
                        ch = char.Parse(Console.ReadLine());
                        if (ch == 'n' || ch == 'N')
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("Deseja remover essa turma do curso? S/N ");
                ch = char.Parse(Console.ReadLine());
                if (ch == 'S' || ch == 's')
                {
                    RemoveTurma(t);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        private void AddTurma(Turma t)
        {
            for (int i = 0; i < Turmas.Count; i++)
            {
                if (t.Equals(Turmas[i]))
                {
                    Console.WriteLine("turmas não podem ter códigos repetidos!");
                }
            }
            Turmas.Add(t);
        }
        private void RemoveTurma(Turma t)
        {
            if (t.Alunos.Count <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Turma removida!");
                Console.WriteLine();
                Turmas.Remove(t);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Só é possível remover turmas sem alunos! ");
                Console.WriteLine();
            }
        }
        public void AddAlunoCurso(Aluno a)
        {
            for (int i = 0; i < Alunos.Count; i++)
            {
                if (a.Equals(Alunos[i]))
                {
                    Console.WriteLine();
                    Console.WriteLine("Não podem haver Matrículas repetidas! ");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Aluno matriculado!");
            Console.WriteLine();
            Alunos.Add(a);
        }

        public void RemoveAlunoCurso(Aluno a)
        {
            if (a.Turma == null)
            {
                Console.WriteLine();
                Console.WriteLine("Aluno removido!");
                Console.WriteLine();
                Alunos.Remove(a);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Só é possível remover alunos sem turmas! ");
                Console.WriteLine();
            }
        }

        public void Imprime()
        {

            if (Turmas.Count == 0)
            {
                Console.WriteLine("Não existem Turmas para imprimir!");
            }
            else
            {
                Console.WriteLine();
                Turmas.Sort();
                foreach (Turma t in Turmas)
                {
                    if (t.Alunos.Count == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Não é possível imprimir turmas sem alunos");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(t);
                        t.Alunos.Sort();
                        foreach (Aluno a in t.Alunos)
                        {
                            Console.WriteLine(a);
                        }
                    }
                }
            }         
        }
        public void ImprimeTurmaEspecifica()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o código da turma que deseja imprimir: ");
            int c = int.Parse(Console.ReadLine());
            
            if(Turmas.Count == 0)
            {
                Console.WriteLine("Não existem Turmas para imprimir!");
            }
            else
            {
                foreach (Turma t in Turmas)
                {
                    if (c == t.Codigo)
                    {
                        Console.WriteLine(t);
                        t.Alunos.Sort();
                        foreach (Aluno a in t.Alunos)
                        {
                            Console.WriteLine(a);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível achar a turma!");
                    }
                }
            }
        }

    }
}
