namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorDePalavras = 0;

            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            string[] palavras = frase.Split(' ');

            for (int i = 0; i < palavras.Length; i++)
            {
                if (palavras[i] == " ")
                {
                    continue;
                }
                else
                {
                    contadorDePalavras++;
                }

                Console.WriteLine($" Numero de palavras: {contadorDePalavras}");
            }
        }
    }
}