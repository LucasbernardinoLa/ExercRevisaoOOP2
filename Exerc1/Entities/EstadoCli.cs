namespace Exerc1.Entities
{
    internal class EstadoCli
    {
        private string e;
        public string EstadoC
        {
            get
            {
                return e;
            }
            set
            {
                while (true)
                {
                    if (!(ValidaEstado(value)))
                    {
                        Console.Write($"o valor digitado {value} é inválido, digite novamente o caractere: ");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        e = value;
                        break;
                    }
                }
            }
        }

        public EstadoCli(string estadoC)
        {
            EstadoC = estadoC;
        }

        private static bool ValidaEstado(string estado)
        {
            try
            {
                if (estado.Length > 1)
                {

                    Console.WriteLine();
                    Console.WriteLine("Deve haver somente um caracter no campo!");
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    char c_Estado = char.Parse(estado);
                    if (c_Estado == 'C' || c_Estado == 'c')
                    {
                        return true;
                    }
                    if (c_Estado == 'S' || c_Estado == 's')
                    {
                        return true;
                    }
                    if (c_Estado == 'D' || c_Estado == 'd')
                    {
                        return true;
                    }
                    if (c_Estado == 'V' || c_Estado == 'v')
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Digite somente uma das letras listadas acima! ");
                        Console.WriteLine();
                        return false;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite o input do caractere em um formato válido! ");
                Console.WriteLine();
                return false;
            }


        }
    }
}
