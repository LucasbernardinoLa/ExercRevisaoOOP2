using Exerc6.Entities;

List<Progessao> pList = new List<Progessao>();
try
{
    Console.WriteLine("Digite o valor do primeiro número das duas progressões: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor da razão das duas progressões: ");
    int n2 = int.Parse(Console.ReadLine());

    pList.Add(new ProgressaoGeometrica(n1, n2));
    pList.Add(new ProgressaoAritmetica(n1, n2));

    foreach (Progessao p in pList)
    {
        p.MostraProg();
        Console.Write("Escolha a posição do termo que irá ser retornado: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"Termo na posição {n}: " + p.TermoAt(n));
        Console.WriteLine();
        p.Reinicializar();
    }
}
catch (Exception e)
{

    Console.WriteLine(e.Message); 
}