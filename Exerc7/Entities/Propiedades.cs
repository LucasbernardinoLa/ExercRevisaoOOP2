namespace Exerc7.Entities
{
    internal class Propiedades
    {
        private string s;
        public string Path
        {
            get
            {
                return s;
            }
            set
            {
                try
                {
                    s = value;
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error: ");
                    Console.WriteLine(e.Message);
                }
            }
        }
        public Dictionary<string, string> Dict { get; set; }


        public Propiedades()
        {
        }

        public Propiedades(string path)
        {
            Path = path;
            Dict = TransformaEmDcit(path);
        }

        private static Dictionary<string, string> TransformaEmDcit(string path)
        {

            var result = new Dictionary<string, string>();

            var buffer = File.ReadAllLines(path);

            foreach (var line in buffer)
            {
                if (String.IsNullOrWhiteSpace(line)) continue;

                if (line.IndexOf('=') < 0) continue;

                var pair = line.Split('=');
                var key = pair[0].Trim();
                var value = pair[1].TrimStart();

                if (pair.Length > 3)
                {
                    for (int i = 2; i < pair.Length; i++) value += "=" + pair[i];
                }
                result.Add(key, value);
            }
            return result;
        }

        public void RecuperaValor(string key)
        {
            bool temValue = Dict.TryGetValue(key, out string value);
            if (temValue)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine($"A Chave {key} não existe");
            }
        }

        public void AlteraValor(string key)
        {
            
            if (Dict.ContainsKey(key))
            {
                Console.WriteLine($"Digite o novo valor da chave {key}:");
                string value = Console.ReadLine();
                Dict[key] = value;
            }
            else
            {
                throw new Exception($"A chave {key} não existe! ");
            }
        }
        public void VerficaSeExiste(string key)
        {
           
            if (Dict.ContainsKey(key))
            {
                Console.WriteLine($"A chave {key} existe no dicionário");
            }
            else
            {
                throw new Exception($"A {key} chave não existe! ");
            }
        }
        public void Add(string key)
        {
            if (Dict.ContainsKey(key))
            {
                throw new Exception($"Essa chave {key} já existe no dicionário");
            }
            else
            {
                Console.WriteLine($"Digite o valor da chave {key}: ");
                string value = Console.ReadLine();
                Dict.Add(key, value);
            }
        }
        public void SalvaTxt()
        {

            using (StreamWriter sw = new StreamWriter(Path))
            {
                foreach (var item in Dict)
                {
                    sw.WriteLine(item);
                }
            }
        }
    }
}
