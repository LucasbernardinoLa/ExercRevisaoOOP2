namespace Exerc6.Entities
{
    internal class ProgressaoGeometrica : Progessao
    {
        public override int ProximoValor
        {
            get
            {
                if(Pg.Count > 0 )
                {
                    return Primeiro * Razao;
                }
                else
                {
                    return Primeiro;
                }
            }
        }
        private List<int> Pg { get; set; } = new List<int>();
        
        public ProgressaoGeometrica(int primeiro, int razao) : base(primeiro, razao)
        {
        }

        public override int TermoAt(int posicao)
        {
            double q = Razao;
            double n  = posicao - 1;
            if (Pg.Count == 0)
            {
                double a = Primeiro;
                return (int)(a * Math.Pow(q, n));
            }
            else
            {
                double a = Pg[0];
                return (int)(a * Math.Pow(q, n));
            }
        }

        public override void Reinicializar()
        {
            Primeiro = Pg[0];
            Pg.RemoveAll(x => x > 0);
        }

        public override void MostraProg()
        {
            Console.WriteLine("Quantos termos serão adicionados na PG? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Pg.Add(Primeiro);
            for (int i = 1; i < n; i++)
            {
                Pg.Add(Primeiro *= Razao);
               
            }
            Console.WriteLine("PG: ");
            foreach (int i in Pg)
            {
                Console.WriteLine(i);
            }
        }
    }
}
