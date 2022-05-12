namespace Exerc3.Entities
{
    internal class Turma : IComparable
    {
        public int Codigo { get; private set; }
        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();

        public Turma()
        {
            GeraCode();
        }
        private void GeraCode()
        {
            Random r = new Random();
            Codigo = r.Next(0, 100);
            Console.WriteLine($"Codígo de turma gerado: {Codigo} ");
        }
        public override bool Equals(object obj)
        {
            if (obj is Turma other)
            {
                if (other.Codigo == Codigo)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddAlunoTurma(Aluno a)
        {
            for (int i = 0; i < Alunos.Count; i++)
            {
                if (a.Equals(Alunos[i]))
                {
                    Console.WriteLine();
                    Console.WriteLine("Não podem haver Matrículas repetidas! O aluno será excluído da turma!");
                    Console.WriteLine();
                    Alunos.RemoveAt(i);
                }
            }
            Alunos.Add(a);
        }
        public void RemoveAlunoTurma(Aluno a)
        {
            Console.WriteLine();
            Console.WriteLine("Aluno Removido!");
            Console.WriteLine();
            Alunos.Remove(a);
        }
        public int CompareTo(object? obj)
        {
            if (!(obj is Turma))
            {
                throw new ArgumentException("o parámetro deve ser do tipo Turma! ");
            }
            Turma other = obj as Turma;
            return Codigo.CompareTo(other.Codigo);
        }
        public override string ToString()
        {
            return $"Código da turma : {Codigo}";
        }
    }
}
