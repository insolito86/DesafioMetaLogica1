using System;
class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[] { 2, 7, 11, 15 };
        Console.WriteLine(String.Format("Digite um número inteiro para localizar o índice dos dois elementos que são necessários para sua soma{0}O array atual é: {1}", Environment.NewLine, String.Join(", ", numeros)));
        int somaAlvo = Convert.ToInt32(Console.ReadLine());
        bool somaEncontrada = false;
        for (int x = 0; x < numeros.Length; x++)
        {
            for (int y = x + 1;y < numeros.Length; y++)
            {
                if (x != y && numeros[x] + numeros[y] == somaAlvo)
                {
                    somaEncontrada = true;
                    Console.WriteLine(String.Format("Os índices necessários para a soma são [{0}] e [{1}] pois {2} + {3} = {4}", x, y, numeros[x], numeros[y], somaAlvo));
                }
            }
        }
        if (!somaEncontrada) Console.WriteLine(String.Format("Nenhuma soma de dois elementos distintos do array pode chegar ao total de {0}", somaAlvo));
        Console.ReadKey();
    }
}