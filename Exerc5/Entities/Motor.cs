using System.Globalization;


namespace Exerc5.Entities
{
    internal class Motor
    {
        private double c;
        public double Cilindrada
        {
            get
            {
                return c;
            }
            private set
            {
                while (true)
                {
                    if (value < 1.0)
                    {
                        Console.Write("A cilindrada deve ser no mínimo 1.0, digite um novo valor:  ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        c = value;
                        break;
                    }
                }       
            }
        }
        public Carro? Carro { get; set; }

        public Motor(double cilindrada)
        {
            Cilindrada = cilindrada;
        }

        public void InstlarMotor(Carro car)
        {
            car.Motor = null;
            if(Carro == null)
            {
                
                Console.WriteLine($"O motor de {Cilindrada.ToString("F1", CultureInfo.InvariantCulture)} cilindradas será instalado no {car.Modelo} com placa: {car.Placa}");
                car.Motor = this;
                Carro = car;

            }
            else
            {
                throw new Exception("Esse motor já está instalado em outro carro!");
            }
        }
    }
}
