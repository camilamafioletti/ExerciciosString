using System;
internal class Program
{

    static string sequenciaNumero = "73167176531330624919225119674426574742355349194934" +
                            "96983520312774506326239578318016984801869478851843" +
                            "85861560789112949495459501737958331952853208805511" +
                            "12540698747158523863050715693290963295227443043557" +
                            "66896648950445244523161731856403098711121722383113" +
                            "62229893423380308135336276614282806444486645238749" +
                            "30358907296290491560440772390713810515859307960866" +
                            "70172427121883998797908792274921901699720888093776" +
                            "65727333001053367881220235421809751254540594752243" +
                            "52584907711670556013604839586446706324415722155397" +
                            "53697817977846174064955149290862569321978468622482" +
                            "83972241375657056057490261407972968652414535100474" +
                            "82166370484403199890008895243450658541227588666881" +
                            "16427171479924442928230863465674813919123162824586" +
                            "17866458359124566529476545682848912883142607690042" +
                            "32421902267105562632111110937054421750694165896040" +
                            "07198403850962455444362981230987879927244284909188" +
                            "84580156166097919133875499200524063689912560717606" +
                            "05886116467109405077541002256983155200055935729725" +
                            "71636269561882670428252483600823257530420752963450";

    static char[] sequencia = new char[5];

    static int j;
    static int n1, n2, n3, n4, n5;
    static int tamanho_string = sequenciaNumero.Length;
    static int multiplicado = 0;
    static int multiplicado_max = 0;

    public static void Main(string[] args)
    {
        Processamento();
        MostrarProdutoNaTela();
       
    }

    static void MostrarProdutoNaTela()
    {


        Console.Write("Maior produto sao dos numeros: ");

        for (j = 0; j < 5; j++)
        {
            Console.Write($"{sequencia[j]} ");
        }
        Console.WriteLine($" = {multiplicado_max}");
    }

    static void Processamento()
    {
        for (int i = 0; i < (tamanho_string - 5); i++)
        {
            n1 = sequenciaNumero[i + 0] - 48;
            n2 = sequenciaNumero[i + 1] - 48;
            n3 = sequenciaNumero[i + 2] - 48;
            n4 = sequenciaNumero[i + 3] - 48;
            n5 = sequenciaNumero[i + 4] - 48;

            multiplicado = n1 * n2 * n3 * n4 * n5;

            if (multiplicado > multiplicado_max)
            {
                multiplicado_max = multiplicado;
                for (j = 0; j < 5; j++)
                {
                    sequencia[j] = sequenciaNumero[i + j];
                }
                j = 0;
            }
        }
    }
}