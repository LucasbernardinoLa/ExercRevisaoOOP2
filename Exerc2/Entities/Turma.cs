namespace Exerc2.Entities
{
    internal class Turma
    {
        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();

        public Turma()
        {
        }

        public void AddAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
        public void RemoveAluno(Aluno aluno)
        {
            Alunos.Remove(aluno);
        }
        
        public void ImprimeLista()
        {
            Alunos.Sort();
            foreach(Aluno a in Alunos)
            {
                Console.WriteLine(a);
            }
        }
        private void AchaMelhorAluno()
        {
            var amax = Alunos.Max(x => x.NF);

            foreach (Aluno a in Alunos)
            {
                if(amax == a.NF)
                {
                    Console.WriteLine($"Nome:{a.Nome}, Matricula: {a.Matricula}, nota final: {a.NF}");

                }            
            }
        }
        public void ImprimeEstatisca()
        {
            var a1 = Alunos.Select(x => x.P1).DefaultIfEmpty(0.0).Average();
            var a2 = Alunos.Select(x => x.P2).DefaultIfEmpty(0.0).Average();
            var a3 = Alunos.Select(x => x.NF).DefaultIfEmpty(0.0).Average();
            
            Console.WriteLine();           
            Console.WriteLine($"Média P1:{a1.ToString("F1")}");
            Console.WriteLine($"Média P2:{a2.ToString("F1")}");
            Console.WriteLine($"Média NF:{a3.ToString("F1")}");
            Console.WriteLine();
            AchaMelhorAluno();
        }
    }
}
