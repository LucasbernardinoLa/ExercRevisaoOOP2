namespace Exerc1.Entities
{

    internal class NomeCli
    {
        private string n;
        public string Nome
        {
            get
            {
                return n;
            }
            set
            {
                while (true)
                {
                    if (value.Length < 5)
                    {
                        Console.WriteLine();
                        Console.Write($"o valor digitado {value} é inválido, o nome deve conter ao menos 5 caracteres, digite um nome válido: ");
                        Console.WriteLine();
                        value = Console.ReadLine();
                    }
                    else
                    {
                        n = value;
                        break;
                    }
                }
            }
        }
        public NomeCli(string nome)
        {
            Nome = nome;
        }
    }
}
