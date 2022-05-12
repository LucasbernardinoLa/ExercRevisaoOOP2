namespace Exerc6.Entities
{
    abstract class Progessao
    {
        public int Primeiro { get; set; }
        public int Razao { get; set; }
        
        public abstract int ProximoValor 
        {
            get;    
        }
        
        public Progessao(int primeiro, int razao)
        {
            Primeiro = primeiro;
            Razao = razao;        
        }

        public virtual void Reinicializar()
        {
        }
        
        public abstract int TermoAt(int posicao);
        public abstract void MostraProg();
    }
}
