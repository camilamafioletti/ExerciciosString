namespace Exercicio06
{
    internal class Program
    {
        static string[] ObterCidadesEhEstados(string caminhoDoArquivo)
        {
            const int POSICAO_CIDADE = 2;
            const int POSICAO_ESTADO = 3;

            string arquivo = File.ReadAllText(caminhoDoArquivo);

            string[] linhas = arquivo.Split("\r\n");

            string[] cidadesEstados = new string[linhas.Length];

            int j = 0;
            for (int i = 1; i < linhas.Length; i++)
            {
                string[] colunas = linhas[i].Split(";");

                cidadesEstados[j] = colunas[POSICAO_CIDADE] + ";" + colunas[POSICAO_ESTADO];

                j++;
            }

            return cidadesEstados;
        }

        static void MostrarCidadesAgrupadasPelaPrimeiraLetra(string[] cidadesEstados)
        {
            Console.Clear();

            char[] alfabeto = new char[]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                   'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            for (int i = 0; i < alfabeto.Length; i++)
            {
                Console.WriteLine($"\nCidades com a letra {alfabeto[i]}\n");

                for (int x = 0; x < cidadesEstados.Length; x++)
                {
                    char primeiraLetra = alfabeto[i];

                    
                    if (cidadesEstados[x] != null && cidadesEstados[x].StartsWith(primeiraLetra))
                    {
                        int posicaoInicioEstado = cidadesEstados[x].IndexOf(";");
                        string cidadeSemEstado = cidadesEstados[x].Remove(posicaoInicioEstado);
                        Console.WriteLine("\t" + cidadeSemEstado);
                    }
                }
            }
        }

        static void MostrarCidadesAgrupadasPorEstado(string[] cidadesEstados)
        {
            Console.Clear();
            string[] estados = new string[]
               {
                "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal",
                "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul",
                "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro",
                "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina",
                "São Paulo", "Sergipe", "Tocantins"
               };

            for (int i = 0; i < estados.Length; i++)
            {
                //mostrar o cabeçalho
                string estado = estados[i];

                Console.WriteLine($"\nCidades do estado: {estado}\n");

                for (int x = 0; x < cidadesEstados.Length; x++)
                {
                    if (cidadesEstados[x] != null && cidadesEstados[x].Contains(estado))
                    {
                        int posicaoInicioEstado = cidadesEstados[x].IndexOf(";");
                        string cidadeSemEstado = cidadesEstados[x].Remove(posicaoInicioEstado);
                        Console.WriteLine("\t" + cidadeSemEstado);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string caminhoArquivo = @"D:\Arquivos\Programas\ExerciciosString\Exercicio06\Cidades.csv";

            string[] cidadesEstados = ObterCidadesEhEstados(caminhoArquivo);

            Console.WriteLine("Menu de Escolha:");
            Console.WriteLine("");
            Console.WriteLine("(1) Cidades agrupadas pela primeira letra");
            Console.WriteLine("(2) Cidades agrupadas por estado");

            string opcao = Console.ReadLine();

            if (opcao == "1")
                MostrarCidadesAgrupadasPelaPrimeiraLetra(cidadesEstados);

            else if (opcao == "2")
                MostrarCidadesAgrupadasPorEstado(cidadesEstados);

            Console.ReadLine();
        }
    }
}