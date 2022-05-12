namespace Exerc6.Entities
{
    internal class ProgressaoAritmetica : Progessao
    {
        public override int ProximoValor
        {
            get
            {
                if (Pa.Count > 0)
                {
                    return Primeiro + Razao;
                }
                else
                {
                    return Primeiro;
                }
            }
        }
        private List<int> Pa { get; set; } = new List<int>();
        
        public ProgressaoAritmetica(int primeiro, int razao) : base(primeiro, razao)
        {
        }
        
        public override int TermoAt(int posicao)
        {
            int r = Razao;
            int n = posicao - 1;
            if (Pa.Count == 0)
            {
                int a = Primeiro;
                return a + n * r;
            }
            else
            {
                int a = Pa[0];
                return a + n * r;
            }
        }

        public override void Reinicializar()
        {
            if(Pa.Count != 0)
            {
                Primeiro = Pa[0];
                Pa.RemoveAll(x => x > 0);
            }
            
        }

        public override void MostraProg()
        {
            Console.WriteLine("Quantos termos serão adicionados na PA? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Pa.Add(Primeiro);
            for (int i = 1; i < n; i++)
            {
                Pa.Add(Primeiro += Razao);
            }
            Console.WriteLine("PA: ");
            foreach (int i in Pa)
            {
                Console.WriteLine(i);
            }
        }
    }
}
