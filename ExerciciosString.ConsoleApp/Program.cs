namespace ExerciciosString.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            string[] palavras = frase.Split(' ');

            for (int i = 0; i < palavras.Length; i++)
            {
                palavras[i] = palavras[i].Trim();
            }
        }
    }
}