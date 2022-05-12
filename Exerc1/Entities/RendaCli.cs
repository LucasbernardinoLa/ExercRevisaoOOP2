namespace Exerc1.Entities
{
    internal class Rendacli
    {
        private string r;
        public string Renda
        {
            get
            {
                return r;
            }
            set
            {
                while (true)
                {
                    if (!(ValidaRenda(value)))
                    {
                        Console.Write("Digite uma renda válida: ");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        r = value;
                        break;
                    }
                }
            }
        }

        public Rendacli(string renda)
        {
            Renda = renda;
        }

        private static bool ValidaRenda(string renda)
        {
            try
            {
                float r_Renda = float.Parse(renda);
                if (r_Renda <= 0.0)
                {
                    Console.WriteLine("A renda deve ser maior que zero! ");
                    return false;
                }
                return true;
            }

            catch (FormatException)
            {

                Console.WriteLine();
                Console.WriteLine("Digite a renda em um formato válido!");
                Console.WriteLine();
                return false;
            }
        }
    }
}