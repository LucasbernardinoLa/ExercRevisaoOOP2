using System.Globalization;
using Exerc5.Entities;

try
{
    
    Console.WriteLine("Digite os dados do carro: ");
    Console.Write("Placa: ");
    string p1 = Console.ReadLine();
    Console.Write("Modelo: ");
    string mod1 = Console.ReadLine();
    Console.WriteLine("Cilindrada do motor: ");
    double cil1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Motor m1 = new(cil1);
    Carro c1 = new(p1, mod1, m1);
    Console.WriteLine();
    Console.WriteLine(c1);
    c1.CalcVelCarro();

    Console.WriteLine();
    Console.WriteLine("Digite os dados de um novo carro: ");
    Console.Write("Placa: ");
    string p2 = Console.ReadLine();
    Console.Write("Modelo: ");
    string mod2 = Console.ReadLine();
    Console.WriteLine("Cilindrada do motor: ");
    double cil2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    Motor m2 = new(cil2);
    Carro c2 = new(p2, mod2, m2);
    Console.WriteLine();
    Console.WriteLine(c2);
    c2.CalcVelCarro();

    Console.WriteLine();
    Motor m3 = new(2.0);

    Console.WriteLine();
    m3.InstlarMotor(c2);

    Console.WriteLine(c2);
    c2.CalcVelCarro();

    Console.WriteLine();
    
}
catch (Exception e)
{

    Console.WriteLine(e.Message); 
}


