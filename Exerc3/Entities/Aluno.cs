

namespace Exerc3.Entities
{
    internal class Aluno : IComparable
    {
        public string Nome { get; private set; }
        public int Matricula { get; private set; }
        public Turma? Turma { get; private set; }

        public Aluno(string nome)
        {
           Nome = nome;
            GeraMat();
        }

        private void GeraMat()
        {
            Random r = new Random();
            Matricula = r.Next();
            
        }
        public void AddTurmaAluno(Turma t)
        {
            if (t.Equals(Turma))
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível associar a mesma turma ao mesmo aluno! ");
                Console.WriteLine();
            }
            else
            {
                Turma = t;
            }  
        }
        public void RemoveTurmaAluno(Turma t)
        {
            Console.WriteLine();
            Console.WriteLine("Aluno desvinculado da turma! ");
            Console.WriteLine();
            Turma = null;
        }

        public override bool Equals(object obj)
        {
            if (obj is Aluno other)
            {
                if(other.Matricula == Matricula)
                {
                    return true;
                }
            }
            return false;
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Aluno))
            {
                throw new ArgumentException("o parámetro deve ser do tipo Aluno! ");
            }
            Aluno other = obj as Aluno;
            return Nome.CompareTo(other.Nome);
        }
        public override string ToString()
        {
            return $"Nome dos alunos : {Nome}";
        }
    }
}
