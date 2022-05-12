namespace Exerc1.Entities
{
    internal class CpfCli
    {
        private string s;
        public string Cpf
        {
            get
            {
                return s;
            }
            set
            {
                while (true)
                {
                    if (!(Validacpf(value)))
                    {
                        Console.WriteLine();
                        Console.Write("Cpf inválido, digite novamente: ");
                        Console.WriteLine();
                        value = Console.ReadLine();
                    }
                    else
                    {
                        s = value;
                        break;
                    }
                }
            }
        }

        public CpfCli(string cpf)
        {
            Cpf = cpf;
        }

        private static bool Validacpf(string cpf)
        {
            try
            {
                int[] mult1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] mult2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                cpf = cpf.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
                if (cpf.Length != 11)
                {
                    Console.WriteLine();
                    Console.WriteLine("O cpf deve conter exatamente 11 dígitos! ");
                    Console.WriteLine();
                    return false;
                }
                for (int i = 0; i < 10; i++)
                {
                    if (i.ToString().PadLeft(11, char.Parse(i.ToString())) == cpf)
                    {
                        Console.WriteLine();
                        Console.WriteLine("O cpf não pode conter números repetidos! ");
                        Console.WriteLine();
                        return false;
                    }
                }

                string existeCpf = cpf.Substring(0, 9);
                int sum = 0;

                for (int i = 0; i < 9; i++)
                {
                    sum += int.Parse(existeCpf[i].ToString()) * mult1[i];
                }

                int resto = sum % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                string digito = resto.ToString();
                existeCpf += digito;
                sum = 0;
                for (int i = 0; i < 10; i++)
                    sum += int.Parse(existeCpf[i].ToString()) * mult2[i];

                resto = sum % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();

                return cpf.EndsWith(digito);
            }
            catch (FormatException)
            {

                Console.WriteLine();
                Console.WriteLine("O cpf deve ser escrito em números! ");
                Console.WriteLine();
                return false;
            }
        }
    }
}