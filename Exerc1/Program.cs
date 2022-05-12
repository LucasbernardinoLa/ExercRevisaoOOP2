using Exerc1.Entities;


Console.WriteLine("Digite os dados do cliente: ");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("CPF: ");
string cpf = Console.ReadLine();
Console.Write("Data de nascimento (dd/MM/AAAA): ");
string data = Console.ReadLine();
Console.Write("Renda: ");
string renda = Console.ReadLine();
Console.WriteLine("Estado civil (C, S, V OU D): ");
string estadoC = Console.ReadLine();
Console.WriteLine("Digite o número de dependentes (de 0 a 10): ");
string dependente = Console.ReadLine();

NomeCli n = new(nome);
CpfCli c = new(cpf);
DataCli d = new(data);
Rendacli r = new(renda);
EstadoCli e = new(estadoC);
DependenteCli dep = new(dependente);

Client client = new(n, c, d, r, e, dep);
Console.WriteLine(client);