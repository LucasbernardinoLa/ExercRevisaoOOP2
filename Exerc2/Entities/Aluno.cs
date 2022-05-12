using System.Globalization;

namespace Exerc2.Entities
{
    internal class Aluno : IComparable
    {       
        private double n1;
        private double n2;
        public int Matricula { get; private set; }
        public string Nome { get; private set; }
        public double P1
        {
            get
            {
                return n1;
            }
            private set
            {
                while (true)
                {
                    if (value < 0.0 || value > 10.00)
                    {
                        Console.Write("Os Valores das notas devem ser de 0 a dez, digite novamente: ");
                        value = double.Parse(Console.ReadLine());
                    }
                    else
                    {
                        n1 = value;
                        break;
                    }
                }
            }
        }       
        public double P2
        {
            get
            {
                return n2;
            }
            private set
            {
                while (true)
                {
                    if (value < 0.0 || value > 10.00)
                    {
                        Console.Write("Os Valores das notas devem ser de 0 a dez e lidas com vírgula, digite novamente: ");
                        value = double.Parse(Console.ReadLine());
                    }
                    else
                    {
                        n2 = value;
                        break;
                    }
                }
            }
        }
        public double NF { get; private set; }

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
        
        private void CalcNf()
        {
            double calc = (P1 + P2);
            NF = calc / 2;
        }

        public void LancarNota()
        {
            Console.WriteLine();
            Console.Write("Digite a nota da P1: ");
            double p1 = double.Parse(Console.ReadLine());
            P1 = p1;

            Console.WriteLine();
            Console.Write("Digite a nota da P2: ");
            double p2 = double.Parse(Console.ReadLine());
            P2 = p2;
            CalcNf();
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Aluno))
            {
                throw new ArgumentException("O objeto deve ser do tipo aluno!");
            }
            Aluno other = obj as Aluno;
            return Nome.CompareTo(other.Nome);
        }
        public override string ToString()
        {
            return $"Nome: {Nome}" +
                $" Matrícula: {Matricula}" +
                $" Nota final: {NF:F1}";
        }
    }
}
