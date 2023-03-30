namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Frase em maiusculo: " +frase.ToUpper());

            Console.WriteLine();
            Console.Write("Frase em minusculo: " +frase.ToLower());

            Console.WriteLine();
            Console.Write("Contagem de caracteres: " + frase.Count());

            string[] palavras = frase.Split(" ");

            Console.WriteLine();    
            string primeiraPalavra = palavras[0].ToString();
            Console.Write("Primeira palavra da frase: " + primeiraPalavra);

            Console.WriteLine();
            string[] ultimaPalavra = frase.Split(" ");
            Console.WriteLine("Ultima palvra: " + ultimaPalavra[ultimaPalavra.Length - 1]);
        }
    }
}