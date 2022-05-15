using Exerc7.Entities;

string path = @"C:\Users\lucas\source\repos\ExercRevisaoOOP2\file.txt";

Propiedades p = new(path);
p.AlteraValor("url");
p.VerficaSeExiste("url");
p.Add("lucas");
p.RecuperaValor("url");
p.RecuperaValor("melb");
p.SalvaTxt();