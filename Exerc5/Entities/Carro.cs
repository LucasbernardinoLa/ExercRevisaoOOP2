using System.Globalization;
namespace Exerc5.Entities
{
    internal class Carro
    {
        private string p;
        private string m;
        private Motor mot;
        public string Placa
        {
            get
            {
                return p;
            }
            private set
            {
                while (true)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("O contéudo da string placa não pode ser vazio! digite novamente: ");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        p = value;
                        break;
                    }
                }   
            }
        }
        public string Modelo
        {
            get
            {
                return m;
            }
            private set
            {
                while (true)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("O contéudo da string modelo não pode ser vazio! digite novamente: ");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        m = value;
                        break;
                    }
                }

            }
        }
        public Motor Motor
        {
            get
            {
                return mot;
            }
            set
            {
                if(value.Carro == null)
                {
                    mot = value;
                }
                else
                {
                    Console.WriteLine("O motor já está em outro carro! ");
                }
            }
        }

        public Carro(string placa, string modelo, Motor motor)
        {
            Placa = placa;
            Modelo = modelo;
            Motor = motor;
            motor.Carro = this;
        }

        public void CalcVelCarro()
        {
            if(Motor.Cilindrada <= 1.0)
            {
                Console.WriteLine("A velocidade maxima do carro é 140km/h");
            }
            else if (Motor.Cilindrada <= 1.6)
            {
                Console.WriteLine("A velocidade maxima do carro é 160km/h");
            }
            else if (Motor.Cilindrada <= 2.0)
            {
                Console.WriteLine("A velocidade maxima do carro é 180km/h");
            }
            else
            {
                Console.WriteLine("A velocidade maxima do carro é 220km/h");
            }
        }
        public override string ToString()
        {
            return $"Placa: {Placa}, Modelo: {Modelo}, Motor: {Motor.Cilindrada.ToString("F1", CultureInfo.InvariantCulture )}";
        }
    }
}
