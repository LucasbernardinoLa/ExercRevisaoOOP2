namespace Exerc4.Entities
{
    internal class Certidao
    {
        public DateTime DataDeEmissao { get; private set; }
        public Pessoa Pessoa { get; private set; }

        public Certidao(DateTime dataDeEmissao, Pessoa pessoa)
        {
            DataDeEmissao = dataDeEmissao;
            Pessoa = pessoa;
        }

        public override string ToString()
        {
            return $"Nome:{Pessoa.Nome}, data de emissão {DataDeEmissao.ToString("dd/MM/yyyy")}";
        }
    }
}
