namespace binary_search;

internal class Program
{
    static int BuscaBinaria(int[] array, int elemento)
    {
        int inicio = 0;
        int fim = array.Length - 1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            if (array[meio] == elemento)
                return meio;

            if (array[meio] < elemento)
                inicio = meio + 1;
            else
                fim = meio - 1;
        }

        return -1;
    }

    static void Main()
    {
        int[] arrayOrdenado = { 2, 3, 5, 7, 8, 10, 12, 24, 134, 2535 };
        int elementoBusca = 5;

        int indice = BuscaBinaria(arrayOrdenado, elementoBusca);

        if (indice != -1)
        {
            Console.WriteLine($"O elemento {elementoBusca} foi encontrado no índice {indice}.");
        }
        else
        {
            Console.WriteLine($"O elemento {elementoBusca} não foi encontrado no array.");
        }
    }
}
