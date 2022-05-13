namespace Exerc1.Entities
{
    internal class DependenteCli
    {
        private string d;
        public string Dependente
        {
            get
            {
                return d;
            }
            set
            {
                while (true)
                {
                    if (!(VerificaDepen(value)))
                    {
                        Console.Write($"o valor digitado {value} é inválido, digite novamente o número de dependentes: ");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        d = value;
                        break;
                    }
                }
            }
        }

        public DependenteCli(string dependente)
        {
            Dependente = dependente;
        }

        private static bool VerificaDepen(string dependente)
        {
            try
            {
                int i_Dependente = int.Parse(dependente);
                if (i_Dependente <= 10 && i_Dependente >= 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Só podem ser aceitos os números de 0 a 10!");
                    Console.WriteLine();
                    return false;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite a quantidade de dependentes em um formato válido! ");
                Console.WriteLine();
                return false;
            }

        }
    }
}
