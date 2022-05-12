namespace Exerc1.Entities
{
    internal class Client
    {
        private NomeCli Nome { get; set; }
        private CpfCli Cpf { get; set; }
        private DataCli Data { get; set; }
        private Rendacli Renda { get; set; }
        private EstadoCli EstadoC { get; set; }
        private DependenteCli Dependente { get; set; }

        public Client(NomeCli nome, CpfCli cpf, DataCli data, Rendacli renda, EstadoCli estadoC, DependenteCli dependente)
        {
            Nome = nome;
            Cpf = cpf;
            Data = data;
            Renda = renda;
            EstadoC = estadoC;
            Dependente = dependente;
            Conversao();
        }

        private void Conversao()
        {
            long.Parse(Cpf.Cpf);
            DateTime.Parse(Data.Data);
            float.Parse(Renda.Renda);
            char.Parse(EstadoC.EstadoC);
            int.Parse(Dependente.Dependente);
        }

        public override string ToString()
        {
            return $"Nome: {Nome.Nome} \n" +
                   $"Cpf: {Cpf.Cpf} \n " +
                   $"Data de nascimento: {Data.Data}\n " +
                   $"Renda: {Renda.Renda:F2}\n " +
                   $"Estado civil: {EstadoC.EstadoC.ToString().ToUpperInvariant()}\n " +
                   $"Dependentes: {Dependente.Dependente}\n ";
        }
    }
}