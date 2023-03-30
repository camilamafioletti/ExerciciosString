namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;

            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetoLetras = alfabeto.ToCharArray();

            Console.WriteLine("Escreve um texto para criptografar: ");
            string texto = Console.ReadLine();

            char[] textoArray = texto.ToUpper().ToCharArray();

            Console.WriteLine("Quantas posicoes a frente deseja substituir? ");
            int x = int.Parse(Console.ReadLine());

            while (true)
            {
                for (int i = 0; i < alfabetoLetras.Length - x && j < textoArray.Length; i++)
                {
                    if (textoArray[j] == alfabetoLetras[i])
                    {
                        textoArray[j] = alfabetoLetras[i + x];
                        Console.Write(textoArray[j]);
                        j++;
                    }
                }
            }
        }
    }
}
