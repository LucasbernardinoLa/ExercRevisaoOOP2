using Exerc4.Entities;
try
{
    Console.WriteLine("Digite o nome da Pessoa a ser registrada: ");
    string nome = Console.ReadLine();
    Pessoa p = new Pessoa(nome);
    Console.WriteLine("Deseja criar uma certidão para essa pessoa? S/N ");
    char c = char.Parse(Console.ReadLine());

    if (c == 's' || c == 'S')
    {
        Console.WriteLine("Digite a data de emissão da certidão: ");
        DateTime data = DateTime.Parse(Console.ReadLine());

        Certidao cert = new Certidao(data, p);
        Console.WriteLine(cert);

    }
    Console.WriteLine(p);
}
catch (Exception e)
{

    Console.WriteLine(e.Message); ;
}

