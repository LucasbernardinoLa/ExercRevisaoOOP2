using System.Globalization;

namespace Exerc1.Entities
{
    internal class DataCli
    {
        private string d;
        public string Data
        {
            get
            {
                return d;
            }
            set
            {
                while (true)
                {
                    if (!(ValidaData(value)))
                    {
                        Console.WriteLine();
                        Console.Write($"o valor digitado {value} é inválido, digite uma nova data válida: ");
                        Console.WriteLine();
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

        public DataCli(string data)
        {
            Data = data;
        }

        private static bool ValidaData(string data)
        {
            try
            {
                DateTime d_Data = DateTime.ParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                var idade = DateTime.Today.Year - d_Data.Year;
                if (DateTime.Today.DayOfYear < d_Data.DayOfYear)
                {
                    idade--;
                    if (idade < 18)
                    {
                        Console.WriteLine();
                        Console.WriteLine("O usuário precisa ter no minímo 18 anos!: ");
                        Console.WriteLine();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("O o input deve ser feito exatamente no formato especificado (dd/mm/aaaa)");
                Console.WriteLine();
                return false;
            }
        }
    }
}
